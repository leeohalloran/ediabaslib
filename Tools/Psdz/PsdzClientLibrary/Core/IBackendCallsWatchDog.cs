﻿using System.Collections.Generic;
using System.Net;
using System;

namespace PsdzClient.Core
{
    public enum BackendServiceType
    {
        ExecutionBreak,
        ValidityPatches,
        SdpOnlinePatch,
        PatchServicePrograms,
        EcuValidation,
        SfaTokenDirect,
        SfaNewestPackageForVehicle,
        SfaTokenRequest,
        SecureCoding,
        BrokerMonitor,
        ServiceHistory,
        NOP,
        SWT,
        SWTV3,
        CeSIM,
        FBMImport,
        CVS,
        VPS,
        OTDLSC,
        SVMDVin7Resolver,
        TechnicalCampaignsv030400,
        VehicleTagsService,
        SfaNewFeatureForVehicle,
        EDGEObfcm,
        EDGESpeedlink,
        EDGEBattery,
        SmartMaintenance,
        SmartMaintenanceNew,
        AIR,
        CalibrationValue,
        VehicleEmissionService,
        ServiceRide,
        EDGEPDI,
        AosDocumentXmlData,
        AosDocumentStreamData,
        AosSec4Diag,
        ServiceStateLayer2,
        VehicleBasic,
        ProtocolUploadState,
        VPSProvisioning,
        Sec4Diag,
        SCCGetFileByName,
        SCCPostFile,
        SCCDeleteFileByName,
        SCCPostVehicleSession,
        SCCGetVehicleSession,
        OrderData,
        AIRTeileClearingRelevant,
        KAISendMaintenanceEntry,
        KAIGetServiceHistory,
        AIRForkService,
        BatteryService
    }

    public interface IBackendCallsWatchDog
    {
        Dictionary<BackendServiceType, HttpStatusCode> LatestBackendResponse { get; }

        int GetTotalCallCounter(BackendServiceType serviceType);

        int GetSpecificStatusCallCounter(BackendServiceType serviceType, HttpStatusCode statusCode);

        void AddBackendCall(BackendServiceType serviceType, HttpStatusCode? status, string refVersion = "", Exception ex = null);

        void AddBackendCall(BackendServiceType serviceType, HttpStatusCode? status, IFasta2Service fasta2Service, List<OnlinePatchDownloadStatus> patchFiles, List<string> nameFiles = null, string refVersion = "");
    }
}