using System;
using System.Collections;
using System.Data;
using System.Reflection;

namespace OpenDentBusiness{
  ///<summary></summary>
	public class ToolButItems{
		///<summary></summary>
		private static ToolButItem[] list;
		///<summary></summary>
		public static ArrayList ForProgram;

		public static ToolButItem[] List {
			get {
				if(list==null) {
					RefreshCache();
				}
				return list;
			}
			set {
				list=value;
			}
		}

		///<summary></summary>
		public static DataTable RefreshCache() {
			string command="SELECT * from toolbutitem";
			DataTable table=Cache.GetTableRemotelyIfNeeded(MethodBase.GetCurrentMethod(),command);
			table.TableName="ToolButItem";
			FillCache(table);
			return table;
		}

		///<summary></summary>
		public static void FillCache(DataTable table) {
			List=new ToolButItem[table.Rows.Count];
			for(int i=0;i<List.Length;i++){
				List[i]=new ToolButItem();
				List[i].ToolButItemNum  =PIn.PInt   (table.Rows[i][0].ToString());
				List[i].ProgramNum      =PIn.PInt   (table.Rows[i][1].ToString());
				List[i].ToolBar         =(ToolBarsAvail)PIn.PInt(table.Rows[i][2].ToString());
				List[i].ButtonText      =PIn.PString(table.Rows[i][3].ToString());
			}
		}

		///<summary></summary>
		public static void Insert(ToolButItem Cur){
			string command = "INSERT INTO toolbutitem (ProgramNum,ToolBar,ButtonText) "
				+"VALUES ("
				+"'"+POut.PInt   (Cur.ProgramNum)+"', "
				+"'"+POut.PInt   ((int)Cur.ToolBar)+"', "
				+"'"+POut.PString(Cur.ButtonText)+"')";
			Db.NonQ(command);
		}

		///<summary>This in not currently being used.</summary>
		public static void Update(ToolButItem Cur){
			string command = "UPDATE toolbutitem SET "
				+"ProgramNum ='" +POut.PInt   (Cur.ProgramNum)+"'"
				+",ToolBar ='"   +POut.PInt   ((int)Cur.ToolBar)+"'"
				+",ButtonText ='"+POut.PString(Cur.ButtonText)+"'"
				+" WHERE ToolButItemNum = '"+POut.PInt(Cur.ToolButItemNum)+"'";
			Db.NonQ(command);
		}

		///<summary>This is not currently being used.</summary>
		public static void Delete(ToolButItem Cur){
			string command = "DELETE from toolbutitem WHERE ToolButItemNum = '"
				+POut.PInt(Cur.ToolButItemNum)+"'";
			Db.NonQ(command);
		}

		///<summary>Deletes all ToolButItems for the Programs.Cur.  This is used regularly when saving a Program link because of the way the user interface works.</summary>
		public static void DeleteAllForProgram(int programNum){
			string command = "DELETE from toolbutitem WHERE ProgramNum = '"
				+POut.PInt(programNum)+"'";
			Db.NonQ(command);
		}

		///<summary>Fills ForProgram with toolbutitems attached to the Programs.Cur</summary>
		public static void GetForProgram(int programNum){
			if(List==null) {
				RefreshCache();
			}
			ForProgram=new ArrayList();
			for(int i=0;i<List.Length;i++){
				if(List[i].ProgramNum==programNum){
					ForProgram.Add(List[i]);
				}
			}
		}

		///<summary>Returns a list of toolbutitems for the specified toolbar. Used when laying out toolbars.</summary>
		public static ArrayList GetForToolBar(ToolBarsAvail toolbar) {
			if(List==null) {
				RefreshCache();
			}
			ArrayList retVal=new ArrayList();
			for(int i=0;i<List.Length;i++){
				if(List[i].ToolBar==toolbar && Programs.IsEnabled(List[i].ProgramNum)){
					retVal.Add(List[i]);
				}
			}
			return retVal;
		}


	}

	

}













