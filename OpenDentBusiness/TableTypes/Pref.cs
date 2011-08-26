using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OpenDentBusiness {
	///<summary>Stores small bits of data for a wide variety of purposes.  Any data that's too small to warrant its own table will usually end up here.</summary>
	[Serializable]
	[CrudTable(TableName="preference")]
	public class Pref:TableBase {
		///<summary>Primary key.</summary>
		[CrudColumn(IsPriKey=true)]
		public long PrefNum;
		///<summary>The text 'key' in the key/value pairing.</summary>
		public string PrefName;
		///<summary>The stored value.</summary>
		public string ValueString;
		///<summary>Documentation on usage and values of each pref.  Mostly deprecated now in favor of using XML comments in the code.</summary>
		public string Comments;
	}

	///<summary>Because this enum is stored in the database as strings rather than as numbers, we can do the order alphabetically and we can change it whenever we want.</summary>
	public enum PrefName {
		///<summary></summary>
		AccountingCashIncomeAccount,
		///<summary></summary>
		AccountingDepositAccounts,
		///<summary></summary>
		AccountingIncomeAccount,
		///<summary></summary>
		AccountingLockDate,
		///<summary></summary>
		ADAComplianceDateTime,
		///<summary></summary>
		ADAdescriptionsReset,
		AgingCalculatedMonthlyInsteadOfDaily,
		///<summary>FK to allergydef.AllergyDefNum</summary>
		AllergiesIndicateNone,
		AllowedFeeSchedsAutomate,
		AllowSettingProcsComplete,
		AppointmentBubblesDisabled,
		///<summary>Enum:SearchBehaviorCriteria 0=ProviderTime, 1=ProviderTimeOperatory</summary>
		AppointmentSearchBehavior,
		AppointmentTimeArrivedTrigger,
		AppointmentTimeDismissedTrigger,
		AppointmentTimeIncrement,
		AppointmentTimeSeatedTrigger,
		ApptBubbleDelay,
		ApptExclamationShowForUnsentIns,
		ApptModuleRefreshesEveryMinute,
		///<summary>Integer</summary>
		ApptPrintColumnsPerPage,
		///<summary>Float</summary>
		ApptPrintFontSize,
		ApptPrintTimeStart,
		ApptPrintTimeStop,
		AtoZfolderNotRequired,
		AutoResetTPEntryStatus,
		BackupExcludeImageFolder,
		BackupFromPath,
		BackupReminderLastDateRun,
		BackupRestoreAtoZToPath,
		BackupRestoreFromPath,
		BackupRestoreToPath,
		BackupToPath,
		BalancesDontSubtractIns,
		BankAddress,
		BankRouting,
		BillingAgeOfAccount,
		BillingChargeAdjustmentType,
		BillingChargeAmount,
		BillingChargeLastRun,
		///<summary>Value is a string, either Billing or Finance.</summary>
		BillingChargeOrFinanceIsDefault,
		BillingDefaultsIntermingle,
		BillingDefaultsLastDays,
		BillingDefaultsNote,
		BillingElectClientAcctNumber,
		BillingElectCreditCardChoices,
		BillingElectPassword,
		BillingElectUserName,
		BillingElectVendorId,
		BillingElectVendorPMSCode,
		BillingExcludeBadAddresses,
		BillingExcludeIfUnsentProcs,
		BillingExcludeInactive,
		BillingExcludeInsPending,
		BillingExcludeLessThan,
		BillingExcludeNegative,
		BillingIgnoreInPerson,
		BillingIncludeChanged,
		BillingSelectBillingTypes,
		BillingUseElectronic,
		BirthdayPostcardMsg,
		BrokenAppointmentAdjustmentType,
		BrokenApptCommLogNotAdjustment,
		ChartQuickAddHideAmalgam,
		ClaimAttachExportPath,
		ClaimFormTreatDentSaysSigOnFile,
		ClaimsValidateACN,
		ConfirmEmailMessage,
		ConfirmEmailSubject,
		ConfirmPostcardMessage,
		///<summary>FK to definition.DefNum.  Initially 0.</summary>
		ConfirmStatusEmailed,
		CoPay_FeeSchedule_BlankLikeZero,
		CorruptedDatabase,
		CropDelta,
		CustomizedForPracticeWeb,
		DatabaseConvertedForMySql41,
		DataBaseVersion,
		DateDepositsStarted,
		DateLastAging,
		DefaultClaimForm,
		DefaultProcedurePlaceService,
		///<summary>Boolean.  Set to 1 to indicate that this database holds customers instead of patients.</summary>
		DistributorKey,
		DockPhonePanelShow,
		DocPath,
		EasyBasicModules,
		EasyHideAdvancedIns,
		EasyHideCapitation,
		EasyHideClinical,
		EasyHideDentalSchools,
		EasyHideHospitals,
		EasyHideInsurance,
		EasyHideMedicaid,
		EasyHidePrinters,
		EasyHidePublicHealth,
		EasyHideRepeatCharges,
		EasyNoClinics,
		EclaimsSeparateTreatProv,
		EHREmailFromAddress,
		EHREmailPassword,
		EHREmailPOPserver,
		EHREmailPort,
		///<summary>This pref is hidden, so no practical way for user to turn this on.  Only used for ehr testing.</summary>
		EHREmailToAddress,
		EmailPassword,
		EmailPort,
		EmailSenderAddress,
		EmailSMTPserver,
		EmailUsername,
		EmailUseSSL,
		/// <summary>Boolean. 0 means false and means it is not an EHR Emergency, and emergency access to the family module is not granted.</summary>
		EhrEmergencyNow,
		///<summary>There is no UI for this.  It's only used by OD HQ.</summary>
		EhrProvKeyGeneratorPath,
		EnableAnesthMod,
		ExportPath,
		FinanceChargeAdjustmentType,
		FinanceChargeAPR,
		FinanceChargeLastRun,
		FuchsListSelectionColor,
		FuchsOptionsOn,
		GenericEClaimsForm,
		HL7FolderOut,
		HL7FolderIn,
		ImagesModuleTreeIsCollapsed,
		ImageStoreIsDatabase,
		ImageWindowingMax,
		ImageWindowingMin,
		///<summary>0=Default practice provider, -1=Treating Provider. Otherwise, FK to provider.ProvNum.</summary>
		InsBillingProv,
		InsDefaultPPOpercent,
		InsDefaultShowUCRonClaims,
		///<summary>0=unknown, user did not make a selection.  1=Yes, 2=No.</summary>
		InsPlanConverstion_7_5_17_AutoMergeYN,
		InsurancePlansShared,
		IntermingleFamilyDefault,
		LabelPatientDefaultSheetDefNum,
		///<summary>Comma-delimited list of two-letter language names.</summary>
		LanguagesUsedByPatients,
		LetterMergePath,
		MainWindowTitle,
		MedicalEclaimsEnabled,
		///<summary>FK to medication.MedicationNum</summary>
		MedicationsIndicateNone,
		MobileSyncDateTimeLastRun,
		///<summary>Used one time after the conversion to 7.9 for initial synch of the provider table.</summary>
		MobileSynchNewTables79Done,
		MobileSyncIntervalMinutes,
		MobileSyncServerURL,
		MobileSyncWorkstationName,
		MobileExcludeApptsBeforeDate,
		MobileUserName,
		//MobileSyncLastFileNumber,
		//MobileSyncPath,
		MySqlVersion,
		OpenDentalVendor,
		OracleInsertId,
		PasswordsMustBeStrong,
		PatientSelectUsesSearchButton,
		PayPlansBillInAdvanceDays,
		PerioColorCAL,
		PerioColorFurcations,
		PerioColorFurcationsRed,
		PerioColorGM,
		PerioColorMGJ,
		PerioColorProbing,
		PerioColorProbingRed,
		PerioRedCAL,
		PerioRedFurc,
		PerioRedGing,
		PerioRedMGJ,
		PerioRedMob,
		PerioRedProb,
		PlannedApptTreatedAsRegularAppt,
		PracticeAddress,
		PracticeAddress2,
		PracticeBankNumber,
		PracticeBillingAddress,
		PracticeBillingAddress2,
		PracticeBillingCity,
		PracticeBillingST,
		PracticeBillingZip,
		PracticeCity,
		PracticeDefaultBillType,
		PracticeDefaultProv,
		PracticePhone,
		PracticeST,
		PracticeTitle,
		PracticeZip,
		///<summary>FK to diseasedef.DiseaseDefNum</summary>
		ProblemsIndicateNone,
		///<summary>In FormProcCodes, this is the default for the ShowHidden checkbox.</summary>
		ProcCodeListShowHidden,
		ProcessSigsIntervalInSecs,
		ProgramVersion,
		ProviderIncomeTransferShows,
		RandomPrimaryKeys,
		RecallAdjustDown,
		RecallAdjustRight,
		RecallCardsShowReturnAdd,
		///<summary>-1 indicates min for all dates</summary>
		RecallDaysFuture,
		///<summary>-1 indicates min for all dates</summary>
		RecallDaysPast,
		RecallEmailFamMsg,
		RecallEmailFamMsg2,
		RecallEmailFamMsg3,
		RecallEmailMessage,
		RecallEmailMessage2,
		RecallEmailMessage3,
		RecallEmailSubject,
		RecallEmailSubject2,
		RecallEmailSubject3,
		RecallGroupByFamily,
		RecallMaxNumberReminders,
		RecallPostcardFamMsg,
		RecallPostcardFamMsg2,
		RecallPostcardFamMsg3,
		RecallPostcardMessage,
		RecallPostcardMessage2,
		RecallPostcardMessage3,
		RecallPostcardsPerSheet,
		RecallShowIfDaysFirstReminder,
		RecallShowIfDaysSecondReminder,
		RecallStatusEmailed,
		RecallStatusMailed,
		RecallTypeSpecialChildProphy,
		RecallTypeSpecialPerio,
		RecallTypeSpecialProphy,
		///<summary>Comma-delimited list. FK to recalltype.RecallTypeNum.</summary>
		RecallTypesShowingInList,
		///<summary>If false, then it will only use email in the recall list if email is the preferred recall method.</summary>
		RecallUseEmailIfHasEmailAddress,
		RegistrationKey,
		RegistrationKeyIsDisabled,
		RegistrationNumberClaim,
		RenaissanceLastBatchNumber,
		ReportFolderName,
		ReportsPPOwriteoffDefaultToProcDate,
		ReportsShowPatNum,
		ReportPandIschedProdSubtractsWO,
		RxSendNewToQueue,
		SalesTaxPercentage,
		ScannerCompression,
		ScannerResolution,
		ScannerSuppressDialog,
		ScheduleProvUnassigned,
		SecurityLockDate,
		///<summary>Set to 0 to always grant permission. 1 means only today.</summary>
		SecurityLockDays,
		SecurityLockIncludesAdmin,
		///<summary>Set to 0 to disable auto logoff.</summary>
		SecurityLogOffAfterMinutes,
		SecurityLogOffWithWindows,
		ShowAccountFamilyCommEntries,
		ShowFeatureEhr,
		ShowFeatureMedicalInsurance,
		ShowIDinTitleBar,
		ShowProgressNotesInsteadofCommLog,
		ShowUrgFinNoteInProgressNotes,
		SolidBlockouts,
		StatementAccountsUseChartNumber,
		StatementsCalcDueDate,
		StatementShowCreditCard,
		StatementShowNotes,
		StatementShowProcBreakdown,
		StatementShowReturnAddress,
		StatementSummaryShowInsInfo,
		StoreCCnumbers,
		StoreCCtokens,
		SubscriberAllowChangeAlways,
		TaskAncestorsAllSetInVersion55,
		TaskListAlwaysShowsAtBottom,
		TasksCheckOnStartup,
		TasksNewTrackedByUser,
		TasksShowOpenTickets,
		TerminalClosePassword,
		TimecardSecurityEnabled,
		TimeCardsMakesAdjustmentsForOverBreaks,
		TimeCardsUseDecimalInsteadOfColon,
		TimecardUsersDontEditOwnCard,
		TitleBarShowSite,
		ToothChartMoveMenuToRight,
		TreatmentPlanNote,
		TreatPlanPriorityForDeclined,
		TreatPlanShowCompleted,
		TreatPlanShowGraphics,
		TreatPlanShowIns,
		TrojanExpressCollectBillingType,
		TrojanExpressCollectPassword,
		TrojanExpressCollectPath,
		TrojanExpressCollectPreviousFileNumber,
		UpdateCode,
		UpdateInProgressOnComputerName,
		UpdateMultipleDatabases,
		UpdateServerAddress,
		UpdateShowMsiButtons,
		UpdateWebProxyAddress,
		UpdateWebProxyPassword,
		UpdateWebProxyUserName,
		UpdateWebsitePath,
		UpdateWindowShowsClassicView,
		UseBillingAddressOnClaims,
		///<summary>Enum:ToothNumberingNomenclature 0=Universal(American), 1=FDI, 2=Haderup, 3=Palmer</summary>
		UseInternationalToothNumbers,
		///<summary>Only used for sheet synch.  See Mobile... for URL for mobile synch.</summary>
		WebHostSynchServerURL,
		WebServiceServerName,
		WordProcessorPath,
		XRayExposureLevel
	}

	///<summary>Used by pref "SearchBehavior". </summary>
	public enum SearchBehaviorCriteria {
		ProviderTime,
		ProviderTimeOperatory
	}
	



}
