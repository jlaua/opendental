using System;
using System.Collections;
using System.Data;

namespace OpenDentBusiness{
	///<summary></summary>
	public class Transactions {
		///<summary>Since transactions are always viewed individually, this function returns one transaction</summary>
		public static Transaction GetTrans(int transactionNum) {
			string command=
				"SELECT * FROM transaction "
				+"WHERE TransactionNum="+POut.PInt(transactionNum);
			return RefreshAndFill(command);
		}

		///<summary>For now, all transactions are retrieved singly.  Returns null if no match found.</summary>
		private static Transaction RefreshAndFill(string command) {
			DataTable table=Db.GetTable(command);
			if(table.Rows.Count==0) {
				return null;
			}
			Transaction trans=new Transaction();
			trans=new Transaction();
			trans.TransactionNum= PIn.PInt(table.Rows[0][0].ToString());
			trans.DateTimeEntry = PIn.PDateT(table.Rows[0][1].ToString());
			trans.UserNum       = PIn.PInt(table.Rows[0][2].ToString());
			trans.DepositNum    = PIn.PInt(table.Rows[0][3].ToString());
			trans.PayNum        = PIn.PInt(table.Rows[0][4].ToString());
			return trans;
		}

		///<summary>Gets one transaction directly from the database which has this deposit attached to it.  If none exist, then returns null.</summary>
		public static Transaction GetAttachedToDeposit(int depositNum) {
			string command=
				"SELECT * FROM transaction "
				+"WHERE DepositNum="+POut.PInt(depositNum);
			return RefreshAndFill(command);
		}

		///<summary>Gets one transaction directly from the database which has this payment attached to it.  If none exist, then returns null.  There should never be more than one, so that's why it doesn't return more than one.</summary>
		public static Transaction GetAttachedToPayment(int payNum) {
			string command=
				"SELECT * FROM transaction "
				+"WHERE PayNum="+POut.PInt(payNum);
			return RefreshAndFill(command);
		}

		///<summary></summary>
		public static void Insert(Transaction trans) {
			if(PrefC.RandomKeys) {
				trans.TransactionNum=MiscData.GetKey("transaction","TransactionNum");
			}
			string command="INSERT INTO transaction (";
			if(PrefC.RandomKeys) {
				command+="TransactionNum,";
			}
			command+="DateTimeEntry,UserNum,DepositNum,PayNum) VALUES(";
			if(PrefC.RandomKeys) {
				command+="'"+POut.PInt(trans.TransactionNum)+"', ";
			}
			if(DataConnection.DBtype==DatabaseType.Oracle) {
				command+=POut.PDateT(MiscData.GetNowDateTime());
			}
			else {//Assume MySQL
				command+="NOW()";
			}
			command+=
				 ", "//DateTimeEntry set to current server time
				+"'"+POut.PInt   (trans.UserNum)+"', "
				+"'"+POut.PInt   (trans.DepositNum)+"', "
				+"'"+POut.PInt   (trans.PayNum)+"')";
			if(PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				trans.TransactionNum=Db.NonQ(command,true);
			}
		}

		///<summary></summary>
		public static void Update(Transaction trans) {
			string command= "UPDATE transaction SET "
				+"DateTimeEntry = " +POut.PDateT (trans.DateTimeEntry)+" "
				+",UserNum = '"      +POut.PInt   (trans.UserNum)+"' "
				+",DepositNum = '"   +POut.PInt   (trans.DepositNum)+"' "
				+",PayNum = '"       +POut.PInt   (trans.PayNum)+"' "
				+"WHERE TransactionNum = '"+POut.PInt(trans.TransactionNum)+"'";
			Db.NonQ(command);
		}

		///<summary>Also deletes all journal entries for the transaction.  Will later throw an error if journal entries attached to any reconciles.  Be sure to surround with try-catch.</summary>
		public static void Delete(Transaction trans) {
			string command="DELETE FROM journalentry WHERE TransactionNum="+POut.PInt(trans.TransactionNum);
			Db.NonQ(command);
			command= "DELETE FROM transaction WHERE TransactionNum = "+POut.PInt(trans.TransactionNum);
			Db.NonQ(command);
		}

	
	
		///<summary></summary>
		public static bool IsReconciled(Transaction trans){
			string command="SELECT COUNT(*) FROM journalentry WHERE ReconcileNum !=0"
				+" AND TransactionNum="+POut.PInt(trans.TransactionNum);
			if(Db.GetCount(command)=="0") {
				return false;
			}
			return true;
		}



	}

	
}




