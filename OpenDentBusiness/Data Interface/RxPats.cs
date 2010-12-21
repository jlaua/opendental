using System;
using System.Collections;
using System.Data;
using System.Reflection;

namespace OpenDentBusiness{
	///<summary></summary>
	public class RxPats {
		/*
		///<summary></summary>
		public static RxPat[] Refresh(int patNum) {
			string command="SELECT * FROM rxpat"
				+" WHERE PatNum = '"+POut.PInt(patNum)+"'"
				+" ORDER BY RxDate";
			DataTable table=Db.GetTable(command);
			RxPat[] List=new RxPat[table.Rows.Count];
			for(int i=0;i<table.Rows.Count;i++) {
				List[i]=new RxPat();
				List[i].RxNum      = PIn.PInt(table.Rows[i][0].ToString());
				List[i].PatNum     = PIn.PInt(table.Rows[i][1].ToString());
				List[i].RxDate     = PIn.PDate(table.Rows[i][2].ToString());
				List[i].Drug       = PIn.PString(table.Rows[i][3].ToString());
				List[i].Sig        = PIn.PString(table.Rows[i][4].ToString());
				List[i].Disp       = PIn.PString(table.Rows[i][5].ToString());
				List[i].Refills    = PIn.PString(table.Rows[i][6].ToString());
				List[i].ProvNum    = PIn.PInt(table.Rows[i][7].ToString());
				List[i].Notes      = PIn.PString(table.Rows[i][8].ToString());
			}
			return List;
		}*/

		///<summary></summary>
		public static RxPat GetRx(long rxNum) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				return Meth.GetObject<RxPat>(MethodBase.GetCurrentMethod(),rxNum);
			}
			string command="SELECT * FROM rxpat"
				+" WHERE RxNum = "+POut.Long(rxNum);
			DataTable table=Db.GetTable(command);
			RxPat rx=new RxPat();
			rx.RxNum       = PIn.Long(table.Rows[0][0].ToString());
			rx.PatNum      = PIn.Long(table.Rows[0][1].ToString());
			rx.RxDate      = PIn.Date(table.Rows[0][2].ToString());
			rx.Drug        = PIn.String(table.Rows[0][3].ToString());
			rx.Sig         = PIn.String(table.Rows[0][4].ToString());
			rx.Disp        = PIn.String(table.Rows[0][5].ToString());
			rx.Refills     = PIn.String(table.Rows[0][6].ToString());
			rx.ProvNum     = PIn.Long(table.Rows[0][7].ToString());
			rx.Notes       = PIn.String(table.Rows[0][8].ToString());
			rx.PharmacyNum = PIn.Long   (table.Rows[0][9].ToString());
			rx.IsControlled= PIn.Bool  (table.Rows[0][10].ToString());
			return rx;
		}

		///<summary></summary>
		public static void Update(RxPat rx) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				Meth.GetVoid(MethodBase.GetCurrentMethod(),rx);
				return;
			}
			Crud.RxPatCrud.Update(rx);
		}

		///<summary></summary>
		public static long Insert(RxPat rx) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				rx.RxNum=Meth.GetLong(MethodBase.GetCurrentMethod(),rx);
				return rx.RxNum;
			}
			return Crud.RxPatCrud.Insert(rx);
		}

		///<summary></summary>
		public static void Delete(long rxNum) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				Meth.GetVoid(MethodBase.GetCurrentMethod(),rxNum);
				return;
			}
			string command= "DELETE FROM rxpat WHERE RxNum = '"+POut.Long(rxNum)+"'";
			Db.NonQ(command);
		}



	
	

		
	}

	


}













