﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BMW.Rheingold.Psdz.Client;
using BMW.Rheingold.Psdz.Model.Comparer;
using PsdzClient.Programming;

namespace BMW.Rheingold.Psdz.Model.Ecu
{
    [DataContract]
    [KnownType(typeof(PsdzEcuDetailInfo))]
    [KnownType(typeof(PsdzEcuStatusInfo))]
    [KnownType(typeof(PsdzDiagAddress))]
    [KnownType(typeof(PsdzEcuIdentifier))]
    [KnownType(typeof(PsdzStandardSvk))]
    [KnownType(typeof(PsdzEcuPdxInfo))]
    public class PsdzEcu : IPsdzEcu
    {
        private static readonly IEqualityComparer<PsdzEcu> PsdzEcuComparerInstance = new PsdzEcuComparer();

        [DataMember]
        public string BaseVariant { get; set; }

        [DataMember]
        public string BnTnName { get; set; }

        [DataMember]
        public IEnumerable<PsdzBus> BusConnections { get; set; }

        [DataMember]
        public PsdzBus DiagnosticBus { get; set; }

        [DataMember]
        public IPsdzEcuDetailInfo EcuDetailInfo { get; set; }

        [DataMember]
        public IPsdzEcuStatusInfo EcuStatusInfo { get; set; }

        [DataMember]
        public string EcuVariant { get; set; }

        [DataMember]
        public IPsdzDiagAddress GatewayDiagAddr { get; set; }

        [DataMember]
        public IPsdzEcuIdentifier PrimaryKey { get; set; }

        [DataMember]
        public string SerialNumber { get; set; }

        [DataMember]
        public IPsdzStandardSvk StandardSvk { get; set; }

        [DataMember]
        public IPsdzEcuPdxInfo PsdzEcuPdxInfo { get; set; }

        [DataMember]
        public bool IsSmartActuator { get; set; }

        public PsdzEcu()
        {
        }

        public PsdzEcu(IPsdzEcu ecu)
        {
            BaseVariant = ecu.BaseVariant;
            BnTnName = ecu.BnTnName;
            BusConnections = ecu.BusConnections;
            DiagnosticBus = ecu.DiagnosticBus;
            EcuDetailInfo = ecu.EcuDetailInfo;
            EcuStatusInfo = ecu.EcuStatusInfo;
            EcuVariant = ecu.EcuVariant;
            GatewayDiagAddr = ecu.GatewayDiagAddr;
            PrimaryKey = ecu.PrimaryKey;
            SerialNumber = ecu.SerialNumber;
            StandardSvk = ecu.StandardSvk;
            PsdzEcuPdxInfo = ecu.PsdzEcuPdxInfo;
            IsSmartActuator = ecu.IsSmartActuator;
        }

        public override bool Equals(object obj)
        {
            return PsdzEcuComparerInstance.Equals(this, obj as PsdzEcu);
        }

        public override int GetHashCode()
        {
            return PsdzEcuComparerInstance.GetHashCode(this);
        }
    }
}
