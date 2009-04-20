using System;
using System.Collections;
using System.Data;

namespace OpenDentBusiness{
	///<summary></summary>
	public class SecurityLogs {

		///<summary>Used when viewing securityLog from the security admin window.  PermTypes can be length 0 to get all types.</summary>
		public static SecurityLog[] Refresh(DateTime dateFrom,DateTime dateTo,Permissions permType,int patNum,
			int userNum) {
			string command="SELECT * FROM securitylog "
				+"WHERE LogDateTime >= "+POut.PDate(dateFrom)+" "
				+"AND LogDateTime <= "+POut.PDate(dateTo.AddDays(1));
			if(patNum !=0) {
				command+=" AND PatNum= '"+POut.PInt(patNum)+"'";
			}
			if(permType!=Permissions.None) {
				command+=" AND PermType="+POut.PInt((int)permType);
			}
			if(userNum!=0) {
				command+=" AND UserNum="+POut.PInt(userNum);
			}
			DataTable table=Db.GetTable(command);
			SecurityLog[] List=new SecurityLog[table.Rows.Count];
			for(int i=0;i<List.Length;i++) {
				List[i]=new SecurityLog();
				List[i].SecurityLogNum= PIn.PInt(table.Rows[i][0].ToString());
				List[i].PermType      = (Permissions)PIn.PInt(table.Rows[i][1].ToString());
				List[i].UserNum       = PIn.PInt(table.Rows[i][2].ToString());
				List[i].LogDateTime   = PIn.PDateT(table.Rows[i][3].ToString());
				List[i].LogText       = PIn.PString(table.Rows[i][4].ToString());
				List[i].PatNum        = PIn.PInt(table.Rows[i][5].ToString());
			}
			return List;
		}

		///<summary></summary>
		public static void Insert(SecurityLog log){
			if(PrefC.RandomKeys){
				log.SecurityLogNum=MiscData.GetKey("securitylog","SecurityLogNum");
			}
			string command= "INSERT INTO securitylog (";
			if(PrefC.RandomKeys){
				command+="SecurityLogNum,";
			}
			command+="PermType,UserNum,LogDateTime,LogText,PatNum) VALUES(";
			if(PrefC.RandomKeys){
				command+="'"+POut.PInt(log.SecurityLogNum)+"', ";
			}
			command+=
				 "'"+POut.PInt   ((int)log.PermType)+"', "
				+"'"+POut.PInt   (log.UserNum)+"', ";
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				command+=POut.PDateT(MiscData.GetNowDateTime());
			}else{//Assume MySQL
				command+="NOW()";
			}
			command+=", "//LogDateTime set to current server time
				+"'"+POut.PString(log.LogText)+"', "
				+"'"+POut.PInt   (log.PatNum)+"')";
 			if(PrefC.RandomKeys){
				Db.NonQ(command);
			}
			else{
 				log.SecurityLogNum=Db.NonQ(command,true);
			}
		}

		//there are no methods for deleting or changing log entries because that will never be allowed.

		

	
  

		///<summary>Used when viewing various audit trails of specific types.</summary>
		public static SecurityLog[] Refresh(int patNum,Permissions[] permTypes){
			string types="";
			for(int i=0;i<permTypes.Length;i++){
				if(i>0){
					types+=" OR";
				}
				types+=" PermType="+POut.PInt((int)permTypes[i]);
			}
			string command="SELECT * FROM securitylog "
				+"WHERE PatNum= '"+POut.PInt(patNum)+"' "
				+"AND ("+types+")";
			DataTable table=Db.GetTable(command);
			SecurityLog[] List=new SecurityLog[table.Rows.Count];
			for(int i=0;i<List.Length;i++){
				List[i]=new SecurityLog();
				List[i].SecurityLogNum= PIn.PInt   (table.Rows[i][0].ToString());
				List[i].PermType      = (Permissions)PIn.PInt(table.Rows[i][1].ToString());
				List[i].UserNum       = PIn.PInt   (table.Rows[i][2].ToString());
				List[i].LogDateTime   = PIn.PDateT (table.Rows[i][3].ToString());	
				List[i].LogText       = PIn.PString(table.Rows[i][4].ToString());
				List[i].PatNum        = PIn.PInt   (table.Rows[i][5].ToString());
			}
			return List;
		}

		///<summary>PatNum can be 0.</summary>
		public static void MakeLogEntry(Permissions permType,int patNum, string logText){
			SecurityLog securityLog=new SecurityLog();
			securityLog.PermType=permType;
			securityLog.UserNum=Security.CurUser.UserNum;
			securityLog.LogText="From: "+Environment.MachineName+" - "+logText;
			securityLog.PatNum=patNum;
			SecurityLogs.Insert(securityLog);
		}	

	}
}