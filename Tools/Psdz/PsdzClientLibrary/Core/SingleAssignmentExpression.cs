﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsdzClient.Core
{
	[Serializable]
	public abstract class SingleAssignmentExpression : RuleExpression
	{
		public long Value
		{
			get
			{
				return this.value;
			}
		}

        // ToDo: Check on update
        // [UH] dataProvider replaced by vec
        public static RuleExpression Deserialize(Stream ms, EExpressionType type, ILogger logger, Vehicle vec)
        {
            byte[] buffer = new byte[8];
            ms.Read(buffer, 0, 8);
            long num = BitConverter.ToInt64(buffer, 0);
            SingleAssignmentExpression singleAssignmentExpression;
            switch (type)
            {
                case EExpressionType.COUNTRY:
                    singleAssignmentExpression = new CountryExpression();   // [UH] dataProvider removed
                    break;
                case EExpressionType.ECUCLIQUE:
                    singleAssignmentExpression = new EcuCliqueExpression();
                    break;
                case EExpressionType.ECUREPRESENTATIVE:
                    singleAssignmentExpression = new EcuRepresentativeExpression();
                    break;
                case EExpressionType.ECUGROUP:
                    singleAssignmentExpression = new EcuGroupExpression();
                    break;
                case EExpressionType.ECUVARIANT:
                    singleAssignmentExpression = new EcuVariantExpression();
                    break;
                case EExpressionType.ECUPROGRAMMINGVARIANT:
                    singleAssignmentExpression = new EcuProgrammingVariantExpression();
                    break;
                case EExpressionType.EQUIPMENT:
                    singleAssignmentExpression = new EquipmentExpression();
                    break;
                case EExpressionType.ISTUFE:
                    singleAssignmentExpression = new IStufeExpression();   // [UH] dataProvider removed
                    break;
                case EExpressionType.SALAPA:
                    singleAssignmentExpression = new SaLaPaExpression();
                    break;
                case EExpressionType.SIFA:
                    singleAssignmentExpression = new SiFaExpression();
                    break;
                case EExpressionType.VALID_FROM:
                    singleAssignmentExpression = new ValidFromExpression();
                    break;
                case EExpressionType.VALID_TO:
                    singleAssignmentExpression = new ValidToExpression();
                    break;
                default:
                    logger.Warning("SingleAssignmentExpression.Deserialize()", "unhandled SingleAssignmentExpression found: {0}", type.ToString());
                    throw new Exception("Unknown expression type");
            }
            singleAssignmentExpression.value = num;
            singleAssignmentExpression.vecInfo = vec;   // [UH] added
            return singleAssignmentExpression;
        }

        public override bool Evaluate(Vehicle vec, IFFMDynamicResolver ffmResolver, IRuleEvaluationServices ruleEvaluationUtils, ValidationRuleInternalResults internalResult)
		{
			return false;
		}

		public override long GetExpressionCount()
		{
			return 1L;
		}

		public override long GetMemorySize()
		{
			return 16L;
		}

		public override void Serialize(MemoryStream ms)
		{
			ms.Write(BitConverter.GetBytes(this.value), 0, 8);
		}

		protected long value;

        protected Vehicle vecInfo;
    }
}
