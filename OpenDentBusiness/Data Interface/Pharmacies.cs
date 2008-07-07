﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using OpenDental.DataAccess;

namespace OpenDentBusiness{
	///<summary></summary>
	public class Pharmacies{
		///<summary></summary>
		public static DataTable RefreshCache(){
			string c="SELECT * FROM pharmacy ORDER BY StoreName";
			DataTable table=General.GetTable(c);
			table.TableName="Pharmacy";
			FillCache(table);
			return table;
		}

		public static void FillCache(DataTable table){
			PharmacyC.Listt=new List<Pharmacy>();
			Pharmacy pharm;
			for(int i=0;i<table.Rows.Count;i++){
				pharm=new Pharmacy();
				pharm.IsNew=false;
				pharm.PharmacyNum= PIn.PInt   (table.Rows[i][0].ToString());
				pharm.PharmID    = PIn.PString(table.Rows[i][1].ToString());
				pharm.StoreName  = PIn.PString(table.Rows[i][2].ToString());
				pharm.Phone      = PIn.PString(table.Rows[i][3].ToString());
				pharm.Fax        = PIn.PString(table.Rows[i][4].ToString());
				pharm.Address    = PIn.PString(table.Rows[i][5].ToString());
				pharm.Address2   = PIn.PString(table.Rows[i][6].ToString());
				pharm.City       = PIn.PString(table.Rows[i][7].ToString());
				pharm.State      = PIn.PString(table.Rows[i][8].ToString());
				pharm.Zip        = PIn.PString(table.Rows[i][9].ToString());
				pharm.Note       = PIn.PString(table.Rows[i][10].ToString());
				PharmacyC.Listt.Add(pharm);
			}
		}

		///<Summary>Gets one Pharmacy from the database.</Summary>
		public static Pharmacy CreateObject(int PharmacyNum){
			return DataObjectFactory<Pharmacy>.CreateObject(PharmacyNum);
		}

		public static List<Pharmacy> GetPharmacies(int[] PharmacyNums){
			Collection<Pharmacy> collectState=DataObjectFactory<Pharmacy>.CreateObjects(PharmacyNums);
			return new List<Pharmacy>(collectState);		
		}

		///<summary></summary>
		public static void WriteObject(Pharmacy Pharmacy){
			DataObjectFactory<Pharmacy>.WriteObject(Pharmacy);
		}

		///<summary></summary>
		public static void DeleteObject(int PharmacyNum){
			//validate that not already in use.
			/*string command="SELECT LName,FName FROM patient WHERE PharmacyNum="+POut.PInt(PharmacyNum);
			DataTable table=General.GetTable(command);
			string pats="";
			for(int i=0;i<table.Rows.Count;i++){
				if(i>0){
					pats+=", ";
				}
				pats+=table.Rows[i]["FName"].ToString()+" "+table.Rows[i]["LName"].ToString();
			}
			if(table.Rows.Count>0){
				throw new ApplicationException(Lan.g("Pharmacys","Pharmacy is already in use by patient(s). Not allowed to delete. "+pats));
			}*/
			DataObjectFactory<Pharmacy>.DeleteObject(PharmacyNum);
		}

		//public static void DeleteObject(int PharmacyNum){
		//	DataObjectFactory<Pharmacy>.DeleteObject(PharmacyNum);
		//}

		public static string GetDescription(int PharmacyNum){
			if(PharmacyNum==0){
				return "";
			}
			for(int i=0;i<PharmacyC.Listt.Count;i++){
				if(PharmacyC.Listt[i].PharmacyNum==PharmacyNum){
					return PharmacyC.Listt[i].StoreName;
				}
			}
			return "";
		}

	}
}