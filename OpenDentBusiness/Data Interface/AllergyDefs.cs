using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace OpenDentBusiness{
	///<summary></summary>
	public class AllergyDefs{
		///<summary></summary>
		public static List<AllergyDef> Refresh(long patNum){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				return Meth.GetObject<List<AllergyDef>>(MethodBase.GetCurrentMethod(),patNum);
			}
			string command="SELECT * FROM allergydef WHERE PatNum = "+POut.Long(patNum);
			return Crud.AllergyDefCrud.SelectMany(command);
		}

		///<summary>Gets one AllergyDef from the db.</summary>
		public static AllergyDef GetOne(long allergyDefNum){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb){
				return Meth.GetObject<AllergyDef>(MethodBase.GetCurrentMethod(),allergyDefNum);
			}
			return Crud.AllergyDefCrud.SelectOne(allergyDefNum);
		}

		///<summary></summary>
		public static long Insert(AllergyDef allergyDef){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb){
				allergyDef.AllergyDefNum=Meth.GetLong(MethodBase.GetCurrentMethod(),allergyDef);
				return allergyDef.AllergyDefNum;
			}
			return Crud.AllergyDefCrud.Insert(allergyDef);
		}

		///<summary></summary>
		public static void Update(AllergyDef allergyDef){
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb){
				Meth.GetVoid(MethodBase.GetCurrentMethod(),allergyDef);
				return;
			}
			Crud.AllergyDefCrud.Update(allergyDef);
		}

		///<summary></summary>
		public static void Delete(long allergyDefNum) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				Meth.GetVoid(MethodBase.GetCurrentMethod(),allergyDefNum);
				return;
			}
			string command= "DELETE FROM allergydef WHERE AllergyDefNum = "+POut.Long(allergyDefNum);
			Db.NonQ(command);
		}



	}
}