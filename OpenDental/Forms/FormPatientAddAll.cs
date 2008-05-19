using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;

namespace OpenDental {
	public partial class FormPatientAddAll:Form {
		public string LName;
		public string FName;
		private string mostRecentLName;
		/// <summary>displayed from within code, not designer</summary>
		private System.Windows.Forms.ListBox listEmps1;
		private bool mouseIsInListEmps1;
		private string empOriginal1;

		public FormPatientAddAll() {
			InitializeComponent();
			Lan.F(this);
			listEmps1=new ListBox();
			listEmps1.Location=new Point(groupIns1.Left+textEmployer1.Left,
				groupIns1.Top+textEmployer1.Bottom);
			listEmps1.Size=new Size(231,100);
			listEmps1.Visible=false;
			listEmps1.Click += new System.EventHandler(listEmps1_Click);
			listEmps1.DoubleClick += new System.EventHandler(listEmps1_DoubleClick);
			listEmps1.MouseEnter += new System.EventHandler(listEmps1_MouseEnter);
			listEmps1.MouseLeave += new System.EventHandler(listEmps1_MouseLeave);
			Controls.Add(listEmps1);
			listEmps1.BringToFront();
		}

		private void FormPatientAddAll_Load(object sender,EventArgs e) {
			textLName1.Text=LName;
			textFName1.Text=FName;
			listGender1.SelectedIndex=0;
			listGender2.SelectedIndex=0;
			listGender3.SelectedIndex=0;
			listGender4.SelectedIndex=0;
			listGender5.SelectedIndex=0;
			listPosition1.SelectedIndex=1;
			listPosition2.SelectedIndex=1;
			comboSecProv1.Items.Add(Lan.g(this,"none"));
			comboSecProv1.SelectedIndex=0;
			comboSecProv2.Items.Add(Lan.g(this,"none"));
			comboSecProv2.SelectedIndex=0;
			comboSecProv3.Items.Add(Lan.g(this,"none"));
			comboSecProv3.SelectedIndex=0;
			comboSecProv4.Items.Add(Lan.g(this,"none"));
			comboSecProv4.SelectedIndex=0;
			comboSecProv5.Items.Add(Lan.g(this,"none"));
			comboSecProv5.SelectedIndex=0;
			for(int i=0;i<ProviderC.List.Length;i++){
				comboPriProv1.Items.Add(ProviderC.List[i].GetLongDesc());
				comboSecProv1.Items.Add(ProviderC.List[i].GetLongDesc());
				comboPriProv2.Items.Add(ProviderC.List[i].GetLongDesc());
				comboSecProv2.Items.Add(ProviderC.List[i].GetLongDesc());
				comboPriProv3.Items.Add(ProviderC.List[i].GetLongDesc());
				comboSecProv3.Items.Add(ProviderC.List[i].GetLongDesc());
				comboPriProv4.Items.Add(ProviderC.List[i].GetLongDesc());
				comboSecProv4.Items.Add(ProviderC.List[i].GetLongDesc());
				comboPriProv5.Items.Add(ProviderC.List[i].GetLongDesc());
				comboSecProv5.Items.Add(ProviderC.List[i].GetLongDesc());
			}
			int defaultindex=Providers.GetIndex(PrefC.GetInt("PracticeDefaultProv"));
			if(defaultindex==-1) {//default provider hidden
				defaultindex=0;
			}
			comboPriProv1.SelectedIndex=defaultindex;
			comboPriProv2.SelectedIndex=defaultindex;
			comboPriProv3.SelectedIndex=defaultindex;
			comboPriProv4.SelectedIndex=defaultindex;
			comboPriProv5.SelectedIndex=defaultindex;
			FillComboZip();
		}

		#region AutoCapitalize
		private void textLName1_TextChanged(object sender,EventArgs e) {
			if(textLName1.Text.Length==1){
				textLName1.Text=textLName1.Text.ToUpper();
				textLName1.SelectionStart=1;
			}
			SetLNames();
		}

		private void textLName2_TextChanged(object sender,EventArgs e) {
			if(textLName2.Text.Length==1){
				textLName2.Text=textLName2.Text.ToUpper();
				textLName2.SelectionStart=1;
			}
		}

		private void textLName3_TextChanged(object sender,EventArgs e) {
			if(textLName3.Text.Length==1){
				textLName3.Text=textLName3.Text.ToUpper();
				textLName3.SelectionStart=1;
			}
		}

		private void textLName4_TextChanged(object sender,EventArgs e) {
			if(textLName4.Text.Length==1){
				textLName4.Text=textLName4.Text.ToUpper();
				textLName4.SelectionStart=1;
			}
		}

		private void textLName5_TextChanged(object sender,EventArgs e) {
			if(textLName5.Text.Length==1){
				textLName5.Text=textLName5.Text.ToUpper();
				textLName5.SelectionStart=1;
			}
		}

		private void textFName1_TextChanged(object sender,EventArgs e) {
			if(textFName1.Text.Length==1){
				textFName1.Text=textFName1.Text.ToUpper();
				textFName1.SelectionStart=1;
			}
			SetLNames();
		}

		private void textFName2_TextChanged(object sender,EventArgs e) {
			if(textFName2.Text.Length==1){
				textFName2.Text=textFName2.Text.ToUpper();
				textFName2.SelectionStart=1;
			}
			SetLNames();
		}

		private void textFName3_TextChanged(object sender,EventArgs e) {
			if(textFName3.Text.Length==1){
				textFName3.Text=textFName3.Text.ToUpper();
				textFName3.SelectionStart=1;
			}
			SetLNames();
		}

		private void textFName4_TextChanged(object sender,EventArgs e) {
			if(textFName4.Text.Length==1){
				textFName4.Text=textFName4.Text.ToUpper();
				textFName4.SelectionStart=1;
			}
			SetLNames();
		}

		private void textFName5_TextChanged(object sender,EventArgs e) {
			if(textFName5.Text.Length==1){
				textFName5.Text=textFName5.Text.ToUpper();
				textFName5.SelectionStart=1;
			}
			SetLNames();
		}

		private void SetLNames(){
			if(textLName2.Text=="" || textLName2.Text==mostRecentLName){
				if(textFName2.Text==""){
					textLName2.Text="";
				}
				else{
					textLName2.Text=textLName1.Text;
				}
			}
			if(textLName3.Text=="" || textLName3.Text==mostRecentLName){
				if(textFName3.Text==""){
					textLName3.Text="";
				}
				else{
					textLName3.Text=textLName1.Text;
				}
			}
			if(textLName4.Text=="" || textLName4.Text==mostRecentLName){
				if(textFName4.Text==""){
					textLName4.Text="";
				}
				else{
					textLName4.Text=textLName1.Text;
				}
			}
			if(textLName5.Text=="" || textLName5.Text==mostRecentLName){
				if(textFName5.Text==""){
					textLName5.Text="";
				}
				else{
					textLName5.Text=textLName1.Text;
				}
			}
			mostRecentLName=textLName1.Text;
		}
		#endregion AutoCapitalize

		#region BirthdateAndAge
		private void textBirthdate1_Validated(object sender,EventArgs e) {
			if(textBirthdate1.errorProvider1.GetError(textBirthdate1)!=""){
				textAge1.Text="";
				return;
			}
			DateTime birthdate=PIn.PDate(textBirthdate1.Text);
			if(birthdate>DateTime.Today){
				birthdate=birthdate.AddYears(-100);
			}
			textAge1.Text=PatientLogic.DateToAgeString(birthdate);
		}

		private void textBirthdate2_Validated(object sender,EventArgs e) {
			if(textBirthdate2.errorProvider1.GetError(textBirthdate2)!=""){
				textAge2.Text="";
				return;
			}
			DateTime birthdate=PIn.PDate(textBirthdate2.Text);
			if(birthdate>DateTime.Today){
				birthdate=birthdate.AddYears(-100);
			}
			textAge2.Text=PatientLogic.DateToAgeString(birthdate);
		}

		private void textBirthdate3_Validated(object sender,EventArgs e) {
			if(textBirthdate3.errorProvider1.GetError(textBirthdate3)!=""){
				textAge3.Text="";
				return;
			}
			DateTime birthdate=PIn.PDate(textBirthdate3.Text);
			if(birthdate>DateTime.Today){
				birthdate=birthdate.AddYears(-100);
			}
			textAge3.Text=PatientLogic.DateToAgeString(birthdate);
		}

		private void textBirthdate4_Validated(object sender,EventArgs e) {
			if(textBirthdate4.errorProvider1.GetError(textBirthdate4)!=""){
				textAge4.Text="";
				return;
			}
			DateTime birthdate=PIn.PDate(textBirthdate4.Text);
			if(birthdate>DateTime.Today){
				birthdate=birthdate.AddYears(-100);
			}
			textAge4.Text=PatientLogic.DateToAgeString(birthdate);
		}

		private void textBirthdate5_Validated(object sender,EventArgs e) {
			if(textBirthdate5.errorProvider1.GetError(textBirthdate5)!=""){
				textAge5.Text="";
				return;
			}
			DateTime birthdate=PIn.PDate(textBirthdate5.Text);
			if(birthdate>DateTime.Today){
				birthdate=birthdate.AddYears(-100);
			}
			textAge5.Text=PatientLogic.DateToAgeString(birthdate);
		}
		#endregion BirthdateAndAge

		#region InsCheckProvAutomation
		private void checkInsOne1_Click(object sender,EventArgs e) {
			if(textFName2.Text!="" && checkInsOne1.Checked){
				checkInsOne2.Checked=true;
			}
			else{
				checkInsOne2.Checked=false;
			}
			if(textFName3.Text!="" && checkInsOne1.Checked){
				checkInsOne3.Checked=true;
			}
			else{
				checkInsOne3.Checked=false;
			}
			if(textFName4.Text!="" && checkInsOne1.Checked){
				checkInsOne4.Checked=true;
			}
			else{
				checkInsOne4.Checked=false;
			}
			if(textFName5.Text!="" && checkInsOne1.Checked){
				checkInsOne5.Checked=true;
			}
			else{
				checkInsOne5.Checked=false;
			}
		}

		private void checkInsTwo1_Click(object sender,EventArgs e) {
			if(textFName2.Text!="" && checkInsTwo1.Checked){
				checkInsTwo2.Checked=true;
			}
			else{
				checkInsTwo2.Checked=false;
			}
			if(textFName3.Text!="" && checkInsTwo1.Checked){
				checkInsTwo3.Checked=true;
			}
			else{
				checkInsTwo3.Checked=false;
			}
			if(textFName4.Text!="" && checkInsTwo1.Checked){
				checkInsTwo4.Checked=true;
			}
			else{
				checkInsTwo4.Checked=false;
			}
			if(textFName5.Text!="" && checkInsTwo1.Checked){
				checkInsTwo5.Checked=true;
			}
			else{
				checkInsTwo5.Checked=false;
			}
		}

		private void comboPriProv1_SelectionChangeCommitted(object sender,EventArgs e) {
			comboPriProv2.SelectedIndex=comboPriProv1.SelectedIndex;
			comboPriProv3.SelectedIndex=comboPriProv1.SelectedIndex;
			comboPriProv4.SelectedIndex=comboPriProv1.SelectedIndex;
			comboPriProv5.SelectedIndex=comboPriProv1.SelectedIndex;
		}

		private void comboSecProv1_SelectionChangeCommitted(object sender,EventArgs e) {
			comboSecProv2.SelectedIndex=comboSecProv1.SelectedIndex;
			comboSecProv3.SelectedIndex=comboSecProv1.SelectedIndex;
			comboSecProv4.SelectedIndex=comboSecProv1.SelectedIndex;
			comboSecProv5.SelectedIndex=comboSecProv1.SelectedIndex;
		}
		#endregion InsCheckProvAutomation

		#region AddressPhone
		private void textHmPhone_TextChanged(object sender, System.EventArgs e) {
		 	int cursor=textHmPhone.SelectionStart;
			int length=textHmPhone.Text.Length;
			textHmPhone.Text=TelephoneNumbers.AutoFormat(textHmPhone.Text);
			if(textHmPhone.Text.Length>length){
				cursor++;
			}
			textHmPhone.SelectionStart=cursor;		
		}

		private void textCity_TextChanged(object sender, System.EventArgs e) {
			if(textCity.Text.Length==1){
				textCity.Text=textCity.Text.ToUpper();
				textCity.SelectionStart=1;
			}
		}

		private void textState_TextChanged(object sender, System.EventArgs e) {
			if(CultureInfo.CurrentCulture.Name=="en-US" //if USA or Canada, capitalize first 2 letters
				|| (CultureInfo.CurrentCulture.Name.Length>=4 && CultureInfo.CurrentCulture.Name.Substring(3)=="CA")){
				if(textState.Text.Length==1 || textState.Text.Length==2){
					textState.Text=textState.Text.ToUpper();
					textState.SelectionStart=2;
				}
			}
			else{
				if(textState.Text.Length==1){
					textState.Text=textState.Text.ToUpper();
					textState.SelectionStart=1;
				}
			}
		}

		private void textZip_TextChanged(object sender, System.EventArgs e) {
			comboZip.SelectedIndex=-1;
		}

		private void comboZip_SelectionChangeCommitted(object sender, System.EventArgs e) {
			//this happens when a zipcode is selected from the combobox of frequent zips.
			//The combo box is tucked under textZip because Microsoft makes stupid controls.
			textCity.Text=((ZipCode)ZipCodes.ALFrequent[comboZip.SelectedIndex]).City;
			textState.Text=((ZipCode)ZipCodes.ALFrequent[comboZip.SelectedIndex]).State;
			textZip.Text=((ZipCode)ZipCodes.ALFrequent[comboZip.SelectedIndex]).ZipCodeDigits;
		}

		private void textZip_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
			//fired as soon as control loses focus.
			//it's here to validate if zip is typed in to text box instead of picked from list.
			//if(textZip.Text=="" && (textCity.Text!="" || textState.Text!="")){
			//	if(MessageBox.Show(Lan.g(this,"Delete the City and State?"),"",MessageBoxButtons.OKCancel)
			//		==DialogResult.OK){
			//		textCity.Text="";
			//		textState.Text="";
			//	}	
			//	return;
			//}
			if(textZip.Text.Length<5){
				return;
			}
			if(comboZip.SelectedIndex!=-1){
				return;
			}
			//the autofill only works if both city and state are left blank
			if(textCity.Text!="" || textState.Text!=""){
				return;
			}
			ZipCodes.GetALMatches(textZip.Text);
			if(ZipCodes.ALMatches.Count==0){
				//No match found. Must enter info for new zipcode
				ZipCode ZipCodeCur=new ZipCode();
				ZipCodeCur.ZipCodeDigits=textZip.Text;
				FormZipCodeEdit FormZE=new FormZipCodeEdit();
				FormZE.ZipCodeCur=ZipCodeCur;
				FormZE.IsNew=true;
				FormZE.ShowDialog();
				if(FormZE.DialogResult!=DialogResult.OK){
					return;
				}
				DataValid.SetInvalid(InvalidTypes.ZipCodes);//FormZipCodeEdit does not contain internal refresh
				FillComboZip();
				textCity.Text=ZipCodeCur.City;
				textState.Text=ZipCodeCur.State;
				textZip.Text=ZipCodeCur.ZipCodeDigits;
			}
			else if(ZipCodes.ALMatches.Count==1){
				//only one match found.  Use it.
				textCity.Text=((ZipCode)ZipCodes.ALMatches[0]).City;
				textState.Text=((ZipCode)ZipCodes.ALMatches[0]).State;
			}
			else{
				//multiple matches found.  Pick one
				FormZipSelect FormZS=new FormZipSelect();
				FormZS.ShowDialog();
				FillComboZip();
				if(FormZS.DialogResult!=DialogResult.OK){
					return;
				}
				DataValid.SetInvalid(InvalidTypes.ZipCodes);
				textCity.Text=FormZS.ZipSelected.City;
				textState.Text=FormZS.ZipSelected.State;
				textZip.Text=FormZS.ZipSelected.ZipCodeDigits;
			}
		}

		private void FillComboZip(){
			comboZip.Items.Clear();
			for(int i=0;i<ZipCodes.ALFrequent.Count;i++){
				comboZip.Items.Add(((ZipCode)ZipCodes.ALFrequent[i]).ZipCodeDigits
					+"("+((ZipCode)ZipCodes.ALFrequent[i]).City+")");
			}
		}
		#endregion AddressPhone

		#region Employer
		private void textEmployer1_KeyUp(object sender,System.Windows.Forms.KeyEventArgs e) {
			//key up is used because that way it will trigger AFTER the textBox has been changed.
			if(e.KeyCode==Keys.Return) {
				listEmps1.Visible=false;
				textCarrier1.Focus();//textGroupName.Focus();
				return;
			}
			if(textEmployer1.Text=="") {
				listEmps1.Visible=false;
				return;
			}
			if(e.KeyCode==Keys.Down) {
				if(listEmps1.Items.Count==0) {
					return;
				}
				if(listEmps1.SelectedIndex==-1) {
					listEmps1.SelectedIndex=0;
					textEmployer1.Text=listEmps1.SelectedItem.ToString();
				}
				else if(listEmps1.SelectedIndex==listEmps1.Items.Count-1) {
					listEmps1.SelectedIndex=-1;
					textEmployer1.Text=empOriginal1;
				}
				else {
					listEmps1.SelectedIndex++;
					textEmployer1.Text=listEmps1.SelectedItem.ToString();
				}
				textEmployer1.SelectionStart=textEmployer1.Text.Length;
				return;
			}
			if(e.KeyCode==Keys.Up) {
				if(listEmps1.Items.Count==0) {
					return;
				}
				if(listEmps1.SelectedIndex==-1) {
					listEmps1.SelectedIndex=listEmps1.Items.Count-1;
					textEmployer1.Text=listEmps1.SelectedItem.ToString();
				}
				else if(listEmps1.SelectedIndex==0) {
					listEmps1.SelectedIndex=-1;
					textEmployer1.Text=empOriginal1;
				}
				else {
					listEmps1.SelectedIndex--;
					textEmployer1.Text=listEmps1.SelectedItem.ToString();
				}
				textEmployer1.SelectionStart=textEmployer1.Text.Length;
				return;
			}
			if(textEmployer1.Text.Length==1) {
				textEmployer1.Text=textEmployer1.Text.ToUpper();
				textEmployer1.SelectionStart=1;
			}
			empOriginal1=textEmployer1.Text;//the original text is preserved when using up and down arrows
			listEmps1.Items.Clear();
			List<Employer> similarEmps=Employers.GetSimilarNames(textEmployer1.Text);
			for(int i=0;i<similarEmps.Count;i++) {
				listEmps1.Items.Add(similarEmps[i].EmpName);
			}
			int h=13*similarEmps.Count+5;
			if(h > ClientSize.Height-listEmps1.Top){
				h=ClientSize.Height-listEmps1.Top;
			}
			listEmps1.Size=new Size(231,h);
			listEmps1.Visible=true;
		}

		private void textEmployer1_Leave(object sender,System.EventArgs e) {
			if(mouseIsInListEmps1) {
				return;
			}
			listEmps1.Visible=false;
		}

		private void listEmps1_Click(object sender,System.EventArgs e) {
			textEmployer1.Text=listEmps1.SelectedItem.ToString();
			textEmployer1.Focus();
			textEmployer1.SelectionStart=textEmployer1.Text.Length;
			listEmps1.Visible=false;
		}

		private void listEmps1_DoubleClick(object sender,System.EventArgs e) {
			//no longer used
			textEmployer1.Text=listEmps1.SelectedItem.ToString();
			textEmployer1.Focus();
			textEmployer1.SelectionStart=textEmployer1.Text.Length;
			listEmps1.Visible=false;
		}

		private void listEmps1_MouseEnter(object sender,System.EventArgs e) {
			mouseIsInListEmps1=true;
		}

		private void listEmps1_MouseLeave(object sender,System.EventArgs e) {
			mouseIsInListEmps1=false;
		}
		#endregion Employer

		private void butOK_Click(object sender,EventArgs e) {
			if(  textBirthdate1.errorProvider1.GetError(textBirthdate1)!=""
				|| textBirthdate2.errorProvider1.GetError(textBirthdate2)!=""
				|| textBirthdate3.errorProvider1.GetError(textBirthdate3)!=""
				|| textBirthdate4.errorProvider1.GetError(textBirthdate4)!=""
				|| textBirthdate5.errorProvider1.GetError(textBirthdate5)!=""
				){
				MsgBox.Show(this,"Please fix data entry errors first.");
				return;
			}
			if(textLName1.Text=="" || textFName1.Text==""){
				MsgBox.Show(this,"Guarantor name must be entered.");
				return;
			}







			DialogResult=DialogResult.OK;
		}

		private void butCancel_Click(object sender,EventArgs e) {
			DialogResult=DialogResult.Cancel;
		}

		





		

		

		

		

		




	

		
	}
}