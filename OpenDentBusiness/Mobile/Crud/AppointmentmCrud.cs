//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace OpenDentBusiness.Mobile.Crud{
	internal class AppointmentmCrud {
		///<summary>Gets one Appointmentm object from the database using primaryKey1(CustomerNum) and primaryKey2.  Returns null if not found.</summary>
		internal static Appointmentm SelectOne(long customerNum,long aptNum){
			string command="SELECT * FROM appointmentm "
				+"WHERE CustomerNum = "+POut.Long(customerNum)+" AND AptNum = "+POut.Long(aptNum)+" LIMIT 1";
			List<Appointmentm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}


	}
}