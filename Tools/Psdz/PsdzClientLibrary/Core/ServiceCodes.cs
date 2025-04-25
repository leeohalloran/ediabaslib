﻿namespace PsdzClient.Core
{
    public static class ServiceCodes
    {
        public static string ESL01_FaultPatternDetectedId_nu_ST = "ESL01_FaultPatternDetectedId_nu_ST";

        public static string ESL02_FaultPatternDisplayedId_nu_ST = "ESL02_FaultPatternDisplayedId_nu_ST";

        public const string SUC01_NoInternetConnection_nu_LF = "SUC01_NoInternetConnection_nu_LF";

        public const string SUC02_ProblemWithBackendCommunication_nu_LF = "SUC02_ProblemWithBackendCommunication_nu_LF";

        public const string SUC02_IstaEdgeBackendError_nu_LF = "SUC02_IstaEdgeBackendError_nu_LF";

        public const string SUC03_BackendNAError_nu_LF = "SUC03_BackendNAError_nu_LF";

        public const string LOG00_AuthenticationProcessStatus_nu_LF = "LOG00_AuthenticationProcessStatus_nu_LF";

        public const string LOG01_AuthenticationProcessStarted_nu_LF = "LOG01_AuthenticationProcessStarted_nu_LF";

        public const string LOG02_AuthenticationProcessSuccessful_nu_LF = "LOG02_AuthenticationProcessSuccessful_nu_LF";

        public const string LOG03_AuthenticationProcessUnsuccessful_nu_LF = "LOG03_AuthenticationProcessUnsuccessful_nu_LF";

        public const string LOG04_WEN_Session_Started_nu_LF = "LOG04_WEN_Session_Started_nu_LF";

        public const string LOG05_WEN_Session_Opened_nu_LF = "LOG05_WEN_Session_Opened_nu_LF";

        public const string LOG06_WEN_Session_Error_nu_LF = "LOG06_WEN_Session_Error_nu_LF";

        public const string LOG08_NetworkDiscrepancyDetected_nu_LF = "LOG08_NetworkDiscrepancyDetected_nu_LF";

        public const string LOG07_PIN_creation_change_nu_LF = "LOG07_PIN_creation_change_nu_LF";

        public const string SDP10_BLPDownloadSuccess_nu_LF = "SDP10_BLPDownloadSuccess_nu_LF";

        public const string SDP11_BLPDownloadFailed_nu_LF = "SDP11_BLPDownloadFailed_nu_LF";

        public const string SDP12_SWEDownloadSuccess_nu_LF = "SDP12_SWEDownloadSuccess_nu_LF";

        public const string SDP13_SWEDownloadFailed_nu_LF = "SDP13_SWEDownloadFailed_nu_LF";

        public const string NVT07_AblGesDuration_nu_LF = "NVT07_AblGesDuration_nu_LF";

        public const string NVT08_CalculateAblGesPreperationTime_nu_LF = "NVT08_CalculateAblGesPreperationTime_nu_LF";

        public const string ENV01_RunningBitWindows = "ENV01_RunningBitWindows";

        public static string VCM01_Success_After_Retry_nu_LF = "VCM01_{0}_Success_After_Retry_nu_LF";

        public static string VCM02_Unsuccess_After_Retry_nu_LF = "VCM02_{0}_UnSuccess_After_Retry_nu_LF";

        public static string VCM03_Discrepancy_found_nu_LF = "VCM03_{0}_Discrepancy_Found_nu_LF";

        public const string GFS01_State_PsdzWebservice_nu_LF = "GFS01_State_PsdzWebservice_nu_LF";

        public static string ANA01_TimespanVehicleIdent_t_LF => "ANA01_TimespanVehicleIdent_t_LF";

        public static string ANA02_TimespanVehicleTest_t_LF => "ANA02_TimespanVehicleTest_t_LF";

        public static string ANA03_TimespanFastaReadout_t_LF => "ANA03_TimespanFastaReadout_t_LF";

        public static string ANA04_TimespanAblGes_t_LF => "ANA04_TimespanAblGes_t_LF";

        public static string ANA05_ISTAspezDOC_nu_LF => "ANA05_ISTAspezDOC_nu_LF";

        public static string ANA06_TestmodulCalledDBFunctionInNotAllowedWay_nu_LF => "ANA06_TestmodulCalledDBFunctionInNotAllowedWay_nu_LF";

        public static string BNT01_BnTopologieNotFound_nu_LF => "BNT01_BnTopologieNotFound_nu_LF";

        public static string EDI00_SGBDW2VinUse_nu_LF => "EDI00_SGBDW2VinUse_nu_LF";

        public static string ECU01_EdiabasError_nu_LF => "ECU01_EdiabasError_nu_LF";

        public static string ECU02_MPADnoResponseAfterWaitingTime_nu_LF => "ECU02_MPADnoResponseAfterWaitingTime_nu_LF";

        public static string FCM_80_TransmissionStatus_nu_CV => "FCM_80_TransmissionStatus_nu_CV";

        public static string SKIPPEDECUKOM_UNKNOWNGROUP => "SKIPPEDECUKOM_UNKNOWNGROUP";

        public static string SYS00_UICOMRED_mV_MV => "SYS00_UICOMRED_mV_MV";

        public static string SYS00_UICOMKL15_mV_MV => "SYS00_UICOMKL15_mV_MV";

        public static string SYS01_VehTestDuration_nu_LF => "SYS01_VehTestDuration_nu_LF";

        public static string IDE01_VehicleOrderCorrupt_nu_LF => "IDE01_VehicleOrderCorrupt_nu_LF";

        public static string IDE05_ISTAsetPAD_nu_LF => "IDE05_ISTAsetPAD_nu_LF";

        public static string IDE06_differentVINRangeType_nu_LF => "IDE06_differentVINRangeType_nu_LF";

        public static string IDE07_differentGMType_nu_LF => "IDE07_differentGMType_nu_LF";

        public static string IDE08_allTypekeys_nu_LF => "IDE08_allTypekeys_nu_LF";

        public static string IDE10_LocalDbReturnedMoreThenOneEcuGroup_nu_LF => "IDE10_LocalDbReturnedMoreThenOneEcuGroup_nu_LF";

        public static string IDE11_noVINfromICOM_nu_LF => "IDE11_noVINfromICOM_nu_LF";

        public static string NVI09_VCMEMPTY_nu_LF => "NVI09_VCMEMPTY_nu_LF";

        public static string VehicleValueOverrideConflict => "VehicleValueOverrideConflict";

        public static string APP02_PrintoutTriggered_nu_LF => "APP02_PrintoutTriggered_nu_LF";

        public static string APP05_BN2000MotorbikeGwszType_nu_LF => "APP05_BN2000MotorbikeGwszType_nu_LF";

        public static string App09_CloseOperationInActiveTab_nu_LF => "App09_CloseOperationInActiveTab_nu_LF";

        public static string App10_RepairInstructionOpened_nu_LF => "App10_RepairInstructionOpened_nu_LF";

        public static string APP13_IstaLauncherCommunicationFailed_nu_LF => "APP13_IstaLauncherCommunicationFailed_nu_LF";

        public static string MPB00_MeasuresPlanNotCalculated_nu_LF => "MPB00_MeasuresPlanNotCalculated_nu_LF";

        public static string MPB01_NotCalculatedPowerSafeModeActive_nu_LF => "MPB01_NotCalculatedPowerSafeModeActive_nu_LF";

        public static string MPB02_NotCalculatedInvalidILevel_nu_LF => "MPB02_NotCalculatedInvalidILevel_nu_LF";

        public static string MPB03_NotCalculatedInvalidMissingIlevelShipmentBuild_nu_LF => "MPB03_NotCalculatedInvalidMissingIlevelShipmentBuild_nu_LF";

        public static string MPB04_NotCalculatedFailedRetrievingFlashData_nu_LF => "MPB04_NotCalculatedFailedRetrievingFlashData_nu_LF";

        public static string MPB05_NotCalculatedConnectingToVehicleFailed_nu_LF => "MPB05_NotCalculatedConnectingToVehicleFailed_nu_LF";

        public static string MPB06_NotCalculatedFailedCalculationOtherReasons_nu_LF => "MPB06_NotCalculatedFailedCalculationOtherReasons_nu_LF";

        public static string MPB07_NotCalculatedVciIsConnectedWirelessly_nu_LF => "MPB07_NotCalculatedVciIsConnectedWirelessly_nu_LF";

        public static string SUC_ServiceRideExecuted_nu_LF => "SUC_ServiceRideExecuted_nu_LF";

        public static string SCB00_PSdZDidNotGenerateRequest_nu_LF => "SCB00_PSdZDidNotGenerateRequest_nu_LF";

        public static string SCB01_FailedToCalculateNetCodingData_nu_LF => "SCB01_FailedToCalculateNetCodingData_nu_LF";

        public static string SCB02_NetCodingDataCouldNotBeSaved_nu_LF => "SCB02_NetCodingDataCouldNotBeSaved_nu_LF";

        public static string SCB03_CalculatedNetCodingDataContainsErrors_nu_LF => "SCB03_CalculatedNetCodingDataContainsErrors_nu_LF";

        public static string SCB04_FailedToObtainResultOfCalculation_nu_LF => "SCB04_FailedToObtainResultOfCalculation_nu_LF";

        public static string SCB05_FACalcCodDataDoesNotMatchFATargetFromCalcMP_nu_LF => "SCB05_FACalcCodDataDoesNotMatchFATargetFromCalcMP_nu_LF";

        public static string SCB06_UnhandledException_nu_LF => "SCB06_UnhandledException_nu_LF";

        public static string SCB07_Vin17NullOrEmpty_nu_LF => "SCB07_Vin17NullOrEmpty_nu_LF";

        public static string SCB08_UnhandledExceptionExecutingServiceProgram_nu_LF => "SCB08_UnhandledExceptionExecutingServiceProgram_nu_LF";

        public static string SCB09_UnhandledExceptionMissingParams_nu_LF => "SCB09_UnhandledExceptionMissingParams_nu_LF";

        public static string SCB10_ActionCancelledByUser_nu_LF => "SCB10_ActionCancelledByUser_nu_LF";

        public static string SCB11_BackendUrlNotDefinedOrCouldNotBeDetermined_nu_LF => "SCB11_BackendUrlNotDefinedOrCouldNotBeDetermined_nu_LF";

        public static string SCB12_UnhandledServerError_nu_LF => "SCB12_UnhandledServerError_nu_LF";

        public static string SCB13_JavaKeyStoreCouldNotBeCreated_nu_LF => "SCB13_JavaKeyStoreCouldNotBeCreated_nu_LF";

        public static string SCB14_CertificateNotFoundInStore_nu_LF => "SCB14_CertificateNotFoundInStore_nu_LF";

        public static string SCB15_ServerRefusesToFulfillRequest_nu_LF => "SCB15_ServerRefusesToFulfillRequest_nu_LF";

        public static string SCB16_AuthenticationNeeded_nu_LF => "SCB16_AuthenticationNeeded_nu_LF";

        public static string SCB17_ServerNotReachable_nu_LF => "SCB17_ServerNotReachable_nu_LF";

        public static string SCB18_NameResolverServiceCouldNotResolveHostName_nu_LF => "SCB18_NameResolverServiceCouldNotResolveHostName_nu_LF";

        public static string SCB19_PsdzDidNotReturnDataForEcu_nu_LF => "SCB19_PsdzDidNotReturnDataForEcu_nu_LF";

        public static string SCB20_PsdzResponseContainsFailures_nu_LF => "SCB20_PsdzResponseContainsFailures_nu_LF";

        public static string SCB21_TalIsInvalidOrEmpty_nu_LF => "SCB21_TalIsInvalidOrEmpty_nu_LF";

        public static string MAP01_PsdzValuesAreNotMapped_nu_LF => "MAP01_PsdzValuesAreNotMapped_nu_LF";

        public static string SCB22_TargetPathDoesNotExist_nu_LF => "SCB22_TargetPathDoesNotExist_nu_LF";

        public static string SCB23_SourcePathDoesNotExist_nu_LF => "SCB23_SourcePathDoesNotExist_nu_LF";

        public static string SCB24_IncorrectFileExtension_nu_LF => "SCB24_IncorrectFileExtension_nu_LF";

        public static string SCB25_FileNameDoesNotCorrespondToRightFormat_nu_LF => "SCB25_FileNameDoesNotCorrespondToRightFormat_nu_LF";

        public static string SCB26_ZipFileMustContainOnlyOneFile_nu_LF => "SCB26_ZipFileMustContainOnlyOneFile_nu_LF";

        public static string SCB27_JsonCouldNotBeParsed_nu_LF => "SCB27_JsonCouldNotBeParsed_nu_LF";

        public static string SCB28_ContentOfJsonFileNullOrEmpty_nu_LF => "SCB28_ContentOfJsonFileNullOrEmpty_nu_LF";

        public static string SCB29_Vin17InJsonMissingOrDoesNotMatchCurrent_nu_LF => "SCB29_Vin17InJsonMissingOrDoesNotMatchCurrent_nu_LF";

        public static string SCB30_SpecifiedFileWasNotCreated_nu_LF => "SCB30_SpecifiedFileWasNotCreated_nu_LF";

        public static string SCB31_FilesWereNotExtractedSuccessfully_nu_LF => "SCB31_FilesWereNotExtractedSuccessfully_nu_LF";

        public static string SCB32_ZipFileMustNotBeEmpty_nu_LF => "SCB32_ZipFileMustNotBeEmpty_nu_LF";

        public static string SFA00_FeatureNotInResultStatusList_nu_LF => "SFA00_FeatureNotInResultStatusList_nu_LF";

        public static string SFA01_FeatureFailed_nu_LF => "SFA01_FeatureFailed_nu_LF";

        public static string SFA02_EcuCouldNotBeFound_nu_LF => "SFA02_EcuCouldNotBeFound_nu_LF";

        public static string SFA03_PSdZErrorWhileRetrievingFeatures_nu_LF => "SFA03_PSdZErrorWhileRetrievingFeatures_nu_LF";

        public static string SFA04_PSdZDidNotReturnMatchingFeatureId_nu_LF => "SFA04_PSdZDidNotReturnMatchingFeatureId_nu_LF";

        public static string SFA05_PSdZDidNotReturnAnySecureToken_nu_LF => "SFA05_PSdZDidNotReturnAnySecureToken_nu_LF";

        public static string SFA06_FailedToRetrieveSecureToken_nu_LF => "SFA06_FailedToRetrieveSecureToken_nu_LF";

        public static string SFA07_ExceptionWhileExecutingAPIMethod_nu_LF => "SFA07_ExceptionWhileExecutingAPIMethod_nu_LF";

        public static string SFA08_KDSClientNotAllowedToRetrieveResponseToken_nu_LF => "SFA08_KDSClientNotAllowedToRetrieveResponseToken_nu_LF";

        public static string SFA09_KDSMasterNotAllowedToRetrieveResponseToken_nu_LF => "SFA09_KDSMasterNotAllowedToRetrieveResponseToken_nu_LF";

        public static string SFA10_PSdZIndicatedFailureInBackendResponse_nu_LF => "SFA10_PSdZIndicatedFailureInBackendResponse_nu_LF";

        public static string SFA11_TokensCouldNotBeRetrievedFromBackend_nu_LF => "SFA11_TokensCouldNotBeRetrievedFromBackend_nu_LF";

        public static string SFA12_FailedToWriteTokens_nu_LF => "SFA12_FailedToWriteTokens_nu_LF";

        public static string SFA13_UnhandledException_nu_LF => "SFA13_UnhandledException_nu_LF";

        public static string SFA14_Vin17NullOrEmpty_nu_LF => "SFA14_Vin17NullOrEmpty_nu_LF";

        public static string SFA15_UnhandledExceptionExecutingServiceProgram_nu_LF => "SFA15_UnhandledExceptionExecutingServiceProgram_nu_LF";

        public static string SFA16_UnhandledExceptionMissingParams_nu_LF => "SFA16_UnhandledExceptionMissingParams_nu_LF";

        public static string SFA17_ActionCancelledByUser_nu_LF => "SFA17_ActionCancelledByUser_nu_LF";

        public static string SFA18_BackendUrlNotDefinedOrCouldNotBeDetermined_nu_LF => "SFA18_BackendUrlNotDefinedOrCouldNotBeDetermined_nu_LF";

        public static string SFA19_UnhandledServerError_nu_LF => "SFA19_UnhandledServerError_nu_LF";

        public static string SFA20_JavaKeyStoreCouldNotBeCreated_nu_LF => "SFA20_JavaKeyStoreCouldNotBeCreated_nu_LF";

        public static string SFA21_CertificateNotFoundInStore_nu_LF => "SFA21_CertificateNotFoundInStore_nu_LF";

        public static string SFA22_ServerRefusesToFulfillRequest_nu_LF => "SFA22_ServerRefusesToFulfillRequest_nu_LF";

        public static string SFA23_AuthenticationNeeded_nu_LF => "SFA23_AuthenticationNeeded_nu_LF";

        public static string SFA24_ServerNotReachable_nu_LF => "SFA24_ServerNotReachable_nu_LF";

        public static string SFA25_NameResolverServiceCouldNotResolveHostName_nu_LF => "SFA25_NameResolverServiceCouldNotResolveHostName_nu_LF";

        public static string SFA26_PsdzDidNotReturnDataForEcu_nu_LF => "SFA26_PsdzDidNotReturnDataForEcu_nu_LF";

        public static string SFA27_PsdzResponseContainsFailures_nu_LF => "SFA27_PsdzResponseContainsFailures_nu_LF";

        public static string SFA28_TalIsInvalidOrEmpty_nu_LF => "SFA28_TalIsInvalidOrEmpty_nu_LF";

        public static string SFA29_TargetPathDoesNotExist_nu_LF => "SFA29_TargetPathDoesNotExist_nu_LF";

        public static string SFA30_SourcePathDoesNotExist_nu_LF => "SFA30_SourcePathDoesNotExist_nu_LF";

        public static string SFA31_IncorrectFileExtension_nu_LF => "SFA31_IncorrectFileExtension_nu_LF";

        public static string SFA32_FileNameDoesNotCorrespondToRightFormat_nu_LF => "SFA32_FileNameDoesNotCorrespondToRightFormat_nu_LF";

        public static string SFA33_ZipFileMustContainOnlyOneFile_nu_LF => "SFA33_ZipFileMustContainOnlyOneFile_nu_LF";

        public static string SFA34_JsonCouldNotBeParsed_nu_LF => "SFA34_JsonCouldNotBeParsed_nu_LF";

        public static string SFA35_ContentOfJsonFileNullOrEmpty_nu_LF => "SFA35_ContentOfJsonFileNullOrEmpty_nu_LF";

        public static string SFA36_Vin17InJsonMissingOrDoesNotMatchCurrent_nu_LF => "SFA36_Vin17InJsonMissingOrDoesNotMatchCurrent_nu_LF";

        public static string SFA37_SpecifiedFileWasNotCreated_nu_LF => "SFA37_SpecifiedFileWasNotCreated_nu_LF";

        public static string SFA38_FilesWereNotExtractedSuccessfully_nu_LF => "SFA38_FilesWereNotExtractedSuccessfully_nu_LF";

        public static string SFA39_ZipFileMustNotBeEmpty_nu_LF => "SFA39_ZipFileMustNotBeEmpty_nu_LF";

        public static string SFA40_SFADeleteFailedTriedDeactivateCustFeature_nu_LF => "SFA40_SFADeleteFailedTriedDeactivateCustFeature_nu_LF";

        public static string CON00_PsdzVehicleConnectionFailedWithErrCode_nu_LF => "CON00_PsdzVehicleConnectionFailedWithErrCode{0}_nu_LF";

        public static string CON01_IcomRebootStarted_nu_LF => "CON01_IcomRebootStarted_nu_LF";

        public static string CON02_IcomRebootSuccessful_nu_LF => "CON02_IcomRebootSuccessful_nu_LF";

        public static string CON03_IcomRebootFailure_nu_LF => "CON03_IcomRebootFailure_{0}_nu_LF";

        public static string CON04_PsdzConnectionSuccessfulWithoutHsfzRestart_nu_LF => "CON04_PsdzConnectionSuccessfulWithoutHsfzRestart_nu_LF";

        public static string CON05_HsfzRestartTriggered_nu_LF => "CON05_HsfzRestartTriggered_nu_LF";

        public static string CON06_HsfzRestartFailed_nu_LF => "CON06_HsfzRestartFailed_nu_LF";

        public static string CON07_HsfzIsNoLongerReadyAfterRestart_nu_LF => "CON07_HsfzIsNoLongerReadyAfterRestart_nu_LF";

        public static string CON08_PsdzConnectionSuccessfulAfterHsfzRestart_nu_LF => "CON08_PsdzConnectionSuccessfulAfterHsfzRestart_nu_LF";

        public static string CON09_NoPsdzConnectionAfterHsfzRestart_nu_LF => "CON09_NoPsdzConnectionAfterHsfzRestart_nu_LF";

        public static string CON10_PsdzConnectionSuccessfulAfterIcomReboot_nu_LF => "CON10_PsdzConnectionSuccessfulAfterIcomReboot_nu_LF";

        public static string ISL01_ElapsedTimePackageDownload_nu_LF => "ISL01_ElapsedTimePackageDownload_nu_LF";

        public static string ISL02_ElapsedTimePackageUnpack_nu_LF => "ISL02_ElapsedTimePackageUnpack_nu_LF";

        public static string ISL03_ElapsedTimePackageInstallation_nu_LF => "ISL03_ElapsedTimePackageInstallation_nu_LF";

        public static string ISL04_InstallationError_nu_LF => "ISL04_InstallationError_nu_LF";

        public static string HDD01_LanConnectionError_nu_LF => "HDD01_LanConnectionError_nu_LF";

        public static string HDD02_HddServerNotVailable_nu_LF => "HDD02_HddServerNotVailable_nu_LF";

        public static string HDD03_TherapyPlanResetNotOk_nu_LF => "HDD03_TherapyPlanResetNotOk_nu_LF";

        public static string HDD04_HddUpdateServerNotRunning_nu_LF => "HDD04_HddUpdateServerNotRunning_nu_LF";

        public static string HDD05_EcuBaseVairantMissing_nu_LF => "HDD05_EcuBaseVairantMissing_nu_LF";

        public static string HDD06_HddUpdateAborted_nu_LF => "HDD06_HddUpdateAborted_nu_LF";

        public static string HDD07_HddUpdateFinished_nu_LF => "HDD07_HddUpdateFinished_nu_LF";

        public static string HDD08_HddActivationFinished_nu_LF => "HDD08_HddActivationFinished_nu_LF";

        public static string S4D01_CallSec4DiagInBackground_nu_LF => "S4D01_CallSec4DiagInBackground_nu_LF";
    }
}
