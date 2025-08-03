﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BMW.Rheingold.CoreFramework.Contracts.Vehicle;

namespace PsdzClient.Core
{
	[Serializable]
	public class CharacteristicExpression : RuleExpression
	{
        private readonly long dataclassId;

        private readonly long datavalueId;

        private string characteristicRoot;

        private string characteristicValue;

        private readonly PsdzDatabase dataProvider;

        private ILogger logger;

        public long DataClassId => dataclassId;

        public long DataValueId => datavalueId;

        private string CharacteristicRoot
        {
            get
            {
                if (string.IsNullOrEmpty(characteristicRoot))
                {
                    CharacteristicRoot = GetCharacteristicRootFromDb(dataProvider);
                }
                return characteristicRoot;
            }
            set
            {
                characteristicRoot = value;
            }
        }

        private string CharacteristicValue
        {
            get
            {
                if (string.IsNullOrEmpty(characteristicValue))
                {
                    CharacteristicValue = GetCharacteristicValueFromDb(dataProvider);
                    return characteristicValue;
                }
                return characteristicValue;
            }
            set
            {
                characteristicValue = value;
            }
        }
        public CharacteristicExpression(long dataclassId, long datavalueId, Vehicle vec)
        {
            this.dataclassId = dataclassId;
            this.datavalueId = datavalueId;
            this.dataProvider = ClientContext.GetDatabase(vec);
            CharacteristicRoot = GetCharacteristicRootFromDb(this.dataProvider);
            CharacteristicValue = GetCharacteristicValueFromDb(this.dataProvider);
        }

        public static CharacteristicExpression Deserialize(Stream ms, Vehicle vec)
        {
            byte[] array = new byte[16];
            ms.Read(array, 0, 16);
            long num = BitConverter.ToInt64(array, 0);
            long num2 = BitConverter.ToInt64(array, 8);
            return new CharacteristicExpression(num, num2, vec);
        }

        public override bool Evaluate(Vehicle vec, IFFMDynamicResolver ffmResolver, IRuleEvaluationServices ruleEvaluationServices, ValidationRuleInternalResults internalResult)
        {
            logger = ruleEvaluationServices.Logger;
            string value = null;
            bool flag;
            if (vec == null || vec.VCI == null || vec.VCI.VCIType == VCIDeviceType.UNKNOWN)
            {
                if (CharacteristicRoot.Equals("Marke"))
                {
                    return ruleEvaluationServices.ConfigSettings.SelectedBrand.Any((BrandName b) => string.Equals(GetBrandNameAsString(b), CharacteristicValue, StringComparison.InvariantCultureIgnoreCase));
                }
                if ("Sicherheitsrelevant".Equals(CharacteristicRoot, StringComparison.OrdinalIgnoreCase) || "Sicherheitsfahrzeug".Equals(CharacteristicRoot, StringComparison.OrdinalIgnoreCase))
                {
                    ruleEvaluationServices.Logger.Info("CharacteristicExpression.Evaluate()", "Failed to evaluate {0} without vehcile context; will answer false for 'Sicherheitsrelevant'", CharacteristicRoot);
                    flag = false;
                }
                else
                {
                    ruleEvaluationServices.Logger.Warning("CharacteristicExpression.Evaluate()", "Failed to evaluate {0} without vehcile context; will answer true", CharacteristicRoot);
                    flag = true;
                }
            }
            else
            {
                // [UH]  VehicleHelper replaced
                flag = vec.getISTACharacteristics(dataclassId, out value, datavalueId, internalResult);
            }
            ruleEvaluationServices.Logger.Debug("CharacteristicExpression.Evaluate()", "rule: {0}={1} result: {2} (session context: {3}) [original rule: {4}={5}]", CharacteristicRoot, CharacteristicValue, flag, value, dataclassId, datavalueId);
            return flag;
        }

        public override EEvaluationResult EvaluateVariantRule(ClientDefinition client, CharacteristicSet baseConfiguration, EcuConfiguration ecus)
        {
            if (baseConfiguration.Characteristics.TryGetValue(dataclassId, out var value))
            {
                if (value == datavalueId)
                {
                    return EEvaluationResult.VALID;
                }
                return EEvaluationResult.INVALID;
            }
            return EEvaluationResult.MISSING_CHARACTERISTIC;
        }

        public override long GetExpressionCount()
        {
            return 1L;
        }

        public override long GetMemorySize()
        {
            return 24L;
        }

        public override IList<long> GetUnknownCharacteristics(CharacteristicSet baseConfiguration)
        {
            List<long> list = new List<long>();
            if (!baseConfiguration.Characteristics.ContainsKey(dataclassId))
            {
                list.Add(dataclassId);
            }
            return list;
        }

        public override void Serialize(MemoryStream ms)
        {
            ms.WriteByte(17);
            ms.Write(BitConverter.GetBytes(datavalueId), 0, 8);
        }

        public override string ToFormula(FormulaConfig formulaConfig)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(FormulaSeparator(formulaConfig));
            stringBuilder.Append(formulaConfig.CheckStringFunc);
            stringBuilder.Append("(\"");

            stringBuilder.Append(this.CharacteristicRoot);
            stringBuilder.Append("\", ");

            stringBuilder.Append("\"");
            stringBuilder.Append(this.CharacteristicValue);
            stringBuilder.Append("\")");
            stringBuilder.Append(FormulaSeparator(formulaConfig));

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            string[] obj = new string[8] { CharacteristicRoot, "=", CharacteristicValue, " [", null, null, null, null };
            long num = dataclassId;
            obj[4] = num.ToString(CultureInfo.InvariantCulture);
            obj[5] = "=";
            num = datavalueId;
            obj[6] = num.ToString(CultureInfo.InvariantCulture);
            obj[7] = "]";
            return string.Concat(obj);
        }

        private string GetCharacteristicRootFromDb(PsdzDatabase database)
        {
            string result = string.Empty;
            PsdzDatabase.CharacteristicRoots characteristicRootsById = database?.GetCharacteristicRootsById(this.dataclassId.ToString(CultureInfo.InvariantCulture));
            if (characteristicRootsById != null && !string.IsNullOrEmpty(characteristicRootsById.EcuTranslation.TextDe))
            {
                result = characteristicRootsById.EcuTranslation.TextDe;
            }
            return result;
        }

        private string GetCharacteristicValueFromDb(PsdzDatabase database)
        {
            return database?.LookupVehicleCharDeDeById(this.datavalueId.ToString(CultureInfo.InvariantCulture));
        }

        private string GetBrandNameAsString(BrandName brand)
        {
            switch (brand)
            {
                case BrandName.BMWPKW:
                    return "BMW PKW";
                case BrandName.MINIPKW:
                    return "MINI PKW";
                case BrandName.ROLLSROYCEPKW:
                    return "ROLLS-ROYCE PKW";
                case BrandName.BMWMOTORRAD:
                    return "BMW MOTORRAD";
                case BrandName.BMWMGmbHPKW:
                    return "BMW M GmbH PKW";
                case BrandName.BMWUSAPKW:
                    return "BMW USA PKW";
                case BrandName.BMWi:
                    return "BMW i";
                case BrandName.TOYOTA:
                    return BrandName.TOYOTA.ToString();
                default:
                    logger?.Warning(logger.CurrentMethod(), $"Unknown vehicle brand: {brand}");
                    return string.Empty;
            }
        }
    }
}
