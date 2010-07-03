﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenDental;
using OpenDentBusiness;
using OpenDental.Eclaims;

namespace TestCanada {
	public class ClaimTC {
		///<summary>Remember that this is 0-based.  So subtract 1 from the script number to get the index in this list.</summary>
		public static List<long> ClaimNums;

		public static string CreateAllClaims() {
			ClaimNums=new List<long>();
			CreateOne();
			CreateTwo();
			CreateThree();
			CreateFour();
			CreateFive();
			CreateSix();
			CreateSeven();
			CreateEight();
			CreateNine();
			CreateTen();
			CreateEleven();
			CreateTwelve();
			return "Procedure objects set.\r\nClaim objects set.\r\n";
		}

		private static void CreateOne() {
			long provNum=ProviderC.List[0].ProvNum;//dentist#1
			Patient pat=Patients.GetPat(PatientTC.PatNum1);//patient#1, Lisa Fête"
			List<Procedure> procList=new List<Procedure>();
			procList.Add(ProcTC.AddProc("01201",pat.PatNum,new DateTime(1999,1,1),"","",27.5,"X",provNum));
			procList.Add(ProcTC.AddProc("02102",pat.PatNum,new DateTime(1999,1,1),"","",87.25,"X",provNum));
			procList.Add(ProcTC.AddProc("21223",pat.PatNum,new DateTime(1999,1,1),"26","MOD",107.6,"X",provNum));
			Claim claim=CreateClaim(pat,procList,provNum);
			claim.CanadianMaterialsForwarded="X";
			//billing prov already handled
			claim.CanadianReferralProviderNum="";
			claim.CanadianReferralReason=0;
			//pat.SchoolName
			//assignBen can't be set here because it changes per claim in the scripts
			claim.AccidentDate=DateTime.MinValue;
			claim.PreAuthString="";
			claim.CanadianIsInitialUpper="X";
			claim.CanadianDateInitialUpper=DateTime.MinValue;
			claim.CanadianIsInitialLower="X";
			claim.CanadianDateInitialLower=DateTime.MinValue;
			claim.IsOrtho=false;
			Claims.Update(claim);
			ClaimNums.Add(claim.ClaimNum);
		}

		private static void CreateTwo() {
			long provNum=ProviderC.List[0].ProvNum;//dentist#1
			Patient pat=Patients.GetPat(PatientTC.PatNum1);//patient#1, Lisa Fête"
			Procedure proc;
			Procedure procLab;
			List<Procedure> procList=new List<Procedure>();
			procList.Add(ProcTC.AddProc("01201",pat.PatNum,new DateTime(1999,1,1),"","",27.5,"X",provNum));
			procList.Add(ProcTC.AddProc("02102",pat.PatNum,new DateTime(1999,1,1),"","",87.25,"X",provNum));
			procList.Add(ProcTC.AddProc("21223",pat.PatNum,new DateTime(1999,1,1),"25","MIV",107.6,"X",provNum));//impossible surfaces
			proc=ProcTC.AddProc("27211",pat.PatNum,new DateTime(1999,1,1),"24","",450,"X",provNum);
			procList.Add(proc);
			procLab=ProcTC.AddProc("99111",pat.PatNum,new DateTime(1999,1,1),"24","",238,"",provNum);
			ProcTC.AttachLabProc(proc.ProcNum,procLab);
			proc=ProcTC.AddProc("27213",pat.PatNum,new DateTime(1999,1,1),"26","",450,"E",provNum);
			procList.Add(proc);
			procLab=ProcTC.AddProc("99111",pat.PatNum,new DateTime(1999,1,1),"26","",210,"",provNum);
			ProcTC.AttachLabProc(proc.ProcNum,procLab);
			procLab=ProcTC.AddProc("99222",pat.PatNum,new DateTime(1999,1,1),"26","",35,"",provNum);
			ProcTC.AttachLabProc(proc.ProcNum,procLab);
			procList.Add(ProcTC.AddProc("32222",pat.PatNum,new DateTime(1999,1,1),"36","",65,"X",provNum));
			procList.Add(ProcTC.AddProc("39202",pat.PatNum,new DateTime(1999,1,1),"36","",67.5,"X",provNum));
			Claim claim=CreateClaim(pat,procList,provNum);
			claim.CanadianMaterialsForwarded="";
			//billing prov already handled
			claim.CanadianReferralProviderNum="";
			claim.CanadianReferralReason=0;
			//pat.SchoolName
			//assignBen can't be set here because it changes per claim in the scripts
			claim.AccidentDate=DateTime.MinValue;
			claim.PreAuthString="";
			claim.CanadianIsInitialUpper="X";
			claim.CanadianDateInitialUpper=DateTime.MinValue;
			claim.CanadianIsInitialLower="X";
			claim.CanadianDateInitialLower=DateTime.MinValue;
			claim.IsOrtho=false;
			Claims.Update(claim);
			ClaimNums.Add(claim.ClaimNum);
		}

		private static void CreateThree() {
			long provNum=ProviderC.List[0].ProvNum;//dentist#1
			Patient pat=Patients.GetPat(PatientTC.PatNum2);//patient#2, John Smith
			Procedure proc;
			Procedure procLab;
			List<Procedure> procList=new List<Procedure>();
			procList.Add(ProcTC.AddProc("01201",pat.PatNum,new DateTime(1999,1,1),"","",27.5,"X",provNum));
			procList.Add(ProcTC.AddProc("02102",pat.PatNum,new DateTime(1999,1,1),"","",87.25,"X",provNum));
			procList.Add(ProcTC.AddProc("21223",pat.PatNum,new DateTime(1999,1,1),"46","DOV",107.6,"X",provNum));
			proc=ProcTC.AddProc("56112",pat.PatNum,new DateTime(1999,1,1),"","L",217.2,"S",provNum);//lower
			procList.Add(proc);
			procLab=ProcTC.AddProc("99111",pat.PatNum,new DateTime(1999,1,1),"","",315,"",provNum);
			ProcTC.AttachLabProc(proc.ProcNum,procLab);
			Claim claim=CreateClaim(pat,procList,provNum);
			claim.CanadianMaterialsForwarded="";
			//billing prov already handled
			claim.CanadianReferralProviderNum="";
			claim.CanadianReferralReason=0;
			//pat.SchoolName
			//assignBen can't be set here because it changes per claim in the scripts
			claim.AccidentDate=DateTime.MinValue;
			claim.PreAuthString="";
			claim.CanadianIsInitialUpper="X";
			claim.CanadianDateInitialUpper=DateTime.MinValue;
			claim.CanadianIsInitialLower="N";
			claim.CanadianDateInitialLower=new DateTime(1984,4,7);
			claim.CanadianMandProsthMaterial=4;
			claim.IsOrtho=false;
			Claims.Update(claim);
			ClaimNums.Add(claim.ClaimNum);
		}

		private static void CreateFour() {
			long provNum=ProviderC.List[0].ProvNum;//dentist#1
			Patient pat=Patients.GetPat(PatientTC.PatNum4);//patient#4, John Smith, Jr.
			//Procedure proc;
			List<Procedure> procList=new List<Procedure>();
			procList.Add(ProcTC.AddProc("01201",pat.PatNum,new DateTime(1999,1,1),"","",27.5,"X",provNum));
			procList.Add(ProcTC.AddProc("02102",pat.PatNum,new DateTime(1999,1,1),"","",87.25,"X",provNum));
			procList.Add(ProcTC.AddProc("21113",pat.PatNum,new DateTime(1999,1,1),"52","MIV",107.6,"A",provNum));//the date in the script is a typo.
			Claim claim=CreateClaim(pat,procList,provNum);
			claim.CanadianMaterialsForwarded="";
			//billing prov already handled
			claim.CanadianReferralProviderNum="";
			claim.CanadianReferralReason=0;
			pat.SchoolName="Wilson Elementary School";
			//assignBen can't be set here because it changes per claim in the scripts
			claim.AccidentDate=new DateTime(1998,11,2);
			claim.PreAuthString="";
			claim.CanadianIsInitialUpper="X";
			claim.CanadianDateInitialUpper=DateTime.MinValue;
			claim.CanadianIsInitialLower="X";
			claim.CanadianDateInitialLower=DateTime.MinValue;
			//claim.CanadianMandProsthMaterial=4;
			claim.IsOrtho=false;
			Claims.Update(claim);
			ClaimNums.Add(claim.ClaimNum);
		}

		private static void CreateFive() {

		}

		private static void CreateSix() {

		}

		private static void CreateSeven() {

		}

		private static void CreateEight() {

		}

		private static void CreateNine() {

		}

		private static void CreateTen() {

		}

		private static void CreateEleven() {

		}

		private static void CreateTwelve() {

		}

		private static Claim CreateClaim(Patient pat,List<Procedure> procList,long provTreat) {
			Family fam=Patients.GetFamily(pat.PatNum);
			List<InsPlan> planList=InsPlans.RefreshForFam(fam);
			List<PatPlan> patPlanList=PatPlans.Refresh(pat.PatNum);
			List<Benefit> benefitList=Benefits.Refresh(patPlanList);
			List<ClaimProc> claimProcList=ClaimProcs.Refresh(pat.PatNum);
			List<Procedure> procsForPat=Procedures.Refresh(pat.PatNum);
			InsPlan insPlan=InsPlans.GetPlan(PatPlans.GetPlanNum(patPlanList,1),planList);
			InsPlan insPlan2=InsPlans.GetPlan(PatPlans.GetPlanNum(patPlanList,2),planList);
			Claim claim=new Claim();
			Claims.Insert(claim);//to retreive a key for new Claim.ClaimNum
			claim.PatNum=pat.PatNum;
			claim.DateService=procList[0].ProcDate;
			claim.DateSent=DateTime.Today;
			claim.ClaimStatus="W";
			claim.PlanNum=PatPlans.GetPlanNum(patPlanList,1);
			claim.PlanNum2=PatPlans.GetPlanNum(patPlanList,2);
			claim.PatRelat=PatPlans.GetRelat(patPlanList,1);
			claim.PatRelat2=PatPlans.GetRelat(patPlanList,2);
			//if(ordinal==1) {
			claim.ClaimType="P";
			//}
			//else {
			//	claim.ClaimType="S";
			//}
			claim.ProvTreat=provTreat;
			claim.IsProsthesis="N";
			claim.ProvBill=Providers.GetBillingProvNum(claim.ProvTreat,0);
			claim.EmployRelated=YN.No;
			ClaimProc cp;
			List<Procedure> procListClaim=new List<Procedure>();//this list will exclude lab fees
			for(int i=0;i<procList.Count;i++) {
				if(procList[i].ProcNumLab==0) {
					procListClaim.Add(procList[i]);
				}
			}
			for(int i=0;i<procListClaim.Count;i++) {
				cp=new ClaimProc();
				ClaimProcs.CreateEst(cp,procListClaim[i],insPlan);
				cp.ClaimNum=claim.ClaimNum;
				cp.Status=ClaimProcStatus.NotReceived;
				cp.CodeSent=ProcedureCodes.GetProcCode(procListClaim[i].CodeNum).ProcCode;
				cp.LineNumber=(byte)(i+1);
				ClaimProcs.Update(cp);
			}
			claimProcList=ClaimProcs.Refresh(pat.PatNum);
			ClaimL.CalculateAndUpdate(procsForPat,planList,claim,patPlanList,benefitList,pat.Age);
			return claim;
		}

		public static string Run(int scriptNum,string responseExpected,string responseTypeExpected,Claim claim,bool showForms) {
			string retVal="";
			ClaimSendQueueItem queueItem=Claims.GetQueueList(claim.ClaimNum,claim.ClinicNum)[0];
			string warnings;
			string missingData=Eclaims.GetMissingData(queueItem,out warnings);
			if(missingData!="") {
				throw new ApplicationException("Cannot send claim until missing data is fixed:\r\n"+missingData);
			}
			long etransNum=Canadian.SendClaim(queueItem,showForms);
			Etrans etrans=Etranss.GetEtrans(etransNum);
			string message=EtransMessageTexts.GetMessageText(etrans.EtransMessageTextNum);
			CCDFieldInputter formData=new CCDFieldInputter(message);
			string responseStatus=formData.GetValue("G05");
			if(responseStatus!=responseExpected) {
				throw new Exception("Should be "+responseExpected);
			}
			string responseType=formData.GetValue("A04");
			if(responseType!=responseTypeExpected) {
				throw new Exception("Should be "+responseTypeExpected);
			}
			retVal+="Claim #"+scriptNum.ToString()+" successful.\r\n";
			return retVal;
		}

		public static string RunOne(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimNums[0]);
			InsPlanTC.SetAssignBen(claim.PlanNum,false);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,2);
			return Run(1,"C","11",claim,showForms);
		}

		public static string RunTwo(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimNums[1]);
			InsPlanTC.SetAssignBen(claim.PlanNum,true);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,1);
			return Run(2,"","21",claim,showForms);
		}

		public static string RunThree(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimNums[2]);
			InsPlanTC.SetAssignBen(claim.PlanNum,true);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,2);//Even though the test says 1, the example message uses 2
			return Run(3,"","21",claim,showForms);//expecting EOB
		}

		public static string RunFour(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimNums[3]);
			InsPlanTC.SetAssignBen(claim.PlanNum,false);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,2);
			return Run(4,"","21",claim,showForms);//expecting EOB
		}

		public static string RunFive(bool showForms) {
			string retVal="";

			retVal+="Claim #5 not implemented.\r\n";
			return retVal;
		}

		public static string RunSix(bool showForms) {
			string retVal="";

			retVal+="Claim #6 not implemented.\r\n";
			return retVal;
		}

		public static string RunSeven(bool showForms) {
			string retVal="";

			retVal+="Claim #7 not implemented.\r\n";
			return retVal;
		}

		public static string RunEight(bool showForms) {
			string retVal="";

			retVal+="Claim #8 not implemented.\r\n";
			return retVal;
		}

		public static string RunNine(bool showForms) {
			string retVal="";

			retVal+="Claim #9 not implemented.\r\n";
			return retVal;
		}

		public static string RunTen(bool showForms) {
			string retVal="";

			retVal+="Claim #10 not implemented.\r\n";
			return retVal;
		}

		public static string RunEleven(bool showForms) {
			string retVal="";

			retVal+="Claim #11 not implemented.\r\n";
			return retVal;
		}

		public static string RunTwelve(bool showForms) {
			string retVal="";

			retVal+="Claim #12 not implemented.\r\n";
			return retVal;
		}


	}
}
