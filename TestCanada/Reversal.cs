﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenDentBusiness;
using OpenDental.Eclaims;

namespace TestCanada {
	public class Reversal {

		public static string Run(int scriptNum,string responseExpected,Claim claim,bool showForms) {
			string retVal="";
			InsPlan insPlan=InsPlans.GetPlan(claim.PlanNum,null);
			InsSub insSub=InsSubs.GetOne(claim.InsSubNum);
			long etransNum=CanadianOutput.SendClaimReversal(claim,insPlan,insSub);
			Etrans etrans=Etranss.GetEtrans(etransNum);
			string message=EtransMessageTexts.GetMessageText(etrans.EtransMessageTextNum);
			CCDFieldInputter formData=new CCDFieldInputter(message);
			string responseStatus=formData.GetValue("G05");
			if(responseStatus!=responseExpected) {
			  return "G05 should be "+responseExpected+"\r\n";
			}
			retVal+="Reversal #"+scriptNum.ToString()+" successful.\r\n";
			return retVal;
		}

		public static string RunOne(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimTC.ClaimNums[1]);
			claim.CanadaTransRefNum="BCD12345      ";
			InsSubTC.SetAssignBen(false,claim.InsSubNum);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,1);
			return Run(1,"A",claim,showForms);
		}

		public static string RunTwo(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimTC.ClaimNums[2]);
			claim.CanadaTransRefNum="BCD88345      ";
			InsSubTC.SetAssignBen(true,claim.InsSubNum);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,1);
			return Run(2,"A",claim,showForms);
			//TODO: We need to run the reversal for the secondary claim. Can't do this yet since we don't have COB claims implemented yet.
		}

		public static string RunThree(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimTC.ClaimNums[6]);
			claim.CanadaTransRefNum="CCC12345      ";
			InsSubTC.SetAssignBen(false,claim.InsSubNum);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,1);
			return Run(3,"R",claim,showForms);
		}

		public static string RunFour(bool showForms) {
			Claim claim=Claims.GetClaim(ClaimTC.ClaimNums[11]);
			claim.CanadaTransRefNum="AB123456V2    ";
			InsSubTC.SetAssignBen(false,claim.InsSubNum);
			CarrierTC.SetEncryptionMethod(claim.PlanNum,1);
			string oldVersion=CarrierTC.SetCDAnetVersion(claim.PlanNum,"02");
			string retval=Run(4,"A",claim,showForms);
			CarrierTC.SetCDAnetVersion(claim.PlanNum,oldVersion);
			return retval;
		}

	}
}
