/*=============================================================================================================
Open Dental GPL license Copyright (C) 2003  Jordan Sparks, DMD.  http://www.open-dent.com,  www.docsparks.com
See header in FormOpenDental.cs for complete text.  Redistributions must retain this text.
===============================================================================================================*/
using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using Microsoft.Win32;
using OpenDentBusiness;
using CodeBase;
using SparksToothChart;
using OpenDental.UI;


namespace OpenDental{
///<summary></summary>
	public class FormProcGroup:System.Windows.Forms.Form {
		private System.Windows.Forms.Label label7;
		private OpenDental.UI.Button butOK;
		private OpenDental.UI.Button butCancel;
		private OpenDental.UI.Button butDelete;
		private ODErrorProvider errorProvider2=new ODErrorProvider();
		private OpenDental.ODtextBox textNotes;
		private Label label15;
		private Label label16;
		private TextBox textUser;
		private OpenDental.UI.Button buttonUseAutoNote;
		public List<ClaimProcHist> HistList;
		private ODGrid gridProc;
		private SignatureBoxWrapper signatureBoxWrapper;
		private Label label12;
		private ValidDate textDateEntry;
		private Label label26;
		private ValidDate textProcDate;
		private Label label2;
		public Procedure GroupCur;
		public Procedure GroupOld;
		public List<ProcGroupItem> GroupItemList;
		public List<Procedure> ProcList;
		///<summary>This keeps the noteChanged event from erasing the signature when first loading.</summary>
		private bool IsStartingUp;
		private OpenDental.UI.Button butExamSheets;
		private ODGrid gridPat;
		private bool SigChanged;
		private PatField[] PatFieldList;
		private Patient PatCur;
		private Family FamCur;
		private ComboBox comboDPC;
		private Label labelDPC;
		private Label label1;
		private Label label3;
		private Label label4;
		private System.Windows.Forms.Button butRepairN;
		private System.Windows.Forms.Button butRepairY;
		private System.Windows.Forms.Button butEffectiveCommY;
		private System.Windows.Forms.Button butEffectiveCommN;
		private System.Windows.Forms.Button butOnCallN;
		private System.Windows.Forms.Button butOnCallY;
		private OpenDental.UI.Button butRx;

		public FormProcGroup() {
			InitializeComponent();
			Lan.F(this);
		}

		///<summary>Inserts are no longer done within this dialog, but must be done ahead of time from outside.You must specify a procedure to edit, and only the changes that are made in this dialog get saved.  Only used when double click in Account, Chart, TP, and in ContrChart.AddProcedure().  The procedure may be deleted if new, and user hits Cancel.</summary>

		//Constructor from ProcEdit. Lots of this will need to be copied into the new Load function.
		/*public FormProcGroup(long groupNum) {
			GroupCur=Procedures.GetOneProc(groupNum,true);
			ProcGroupItem=ProcGroupItems.Refresh(groupNum);
			//Proc
			InitializeComponent();
			Lan.F(this);
		}*/

		#region Windows Form Designer generated code

		private void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcGroup));
			this.label7 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gridPat = new OpenDental.UI.ODGrid();
			this.textProcDate = new OpenDental.ValidDate();
			this.signatureBoxWrapper = new OpenDental.UI.SignatureBoxWrapper();
			this.gridProc = new OpenDental.UI.ODGrid();
			this.textDateEntry = new OpenDental.ValidDate();
			this.butExamSheets = new OpenDental.UI.Button();
			this.buttonUseAutoNote = new OpenDental.UI.Button();
			this.textNotes = new OpenDental.ODtextBox();
			this.butDelete = new OpenDental.UI.Button();
			this.butCancel = new OpenDental.UI.Button();
			this.butOK = new OpenDental.UI.Button();
			this.comboDPC = new System.Windows.Forms.ComboBox();
			this.labelDPC = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.butRepairN = new System.Windows.Forms.Button();
			this.butRepairY = new System.Windows.Forms.Button();
			this.butEffectiveCommY = new System.Windows.Forms.Button();
			this.butEffectiveCommN = new System.Windows.Forms.Button();
			this.butOnCallN = new System.Windows.Forms.Button();
			this.butOnCallY = new System.Windows.Forms.Button();
			this.butRx = new OpenDental.UI.Button();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(23,78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73,16);
			this.label7.TabIndex = 0;
			this.label7.Text = "&Notes";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(-17,278);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110,41);
			this.label15.TabIndex = 79;
			this.label15.Text = "Signature /\r\nInitials";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(23,55);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73,16);
			this.label16.TabIndex = 80;
			this.label16.Text = "User";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textUser
			// 
			this.textUser.Location = new System.Drawing.Point(98,52);
			this.textUser.Name = "textUser";
			this.textUser.ReadOnly = true;
			this.textUser.Size = new System.Drawing.Size(119,20);
			this.textUser.TabIndex = 101;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(-25,34);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(125,14);
			this.label12.TabIndex = 96;
			this.label12.Text = "Date Entry";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(178,34);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(83,18);
			this.label26.TabIndex = 97;
			this.label26.Text = "(for security)";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(2,14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96,14);
			this.label2.TabIndex = 101;
			this.label2.Text = "Procedure Date";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gridPat
			// 
			this.gridPat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gridPat.HScrollVisible = false;
			this.gridPat.Location = new System.Drawing.Point(468,276);
			this.gridPat.Name = "gridPat";
			this.gridPat.ScrollValue = 0;
			this.gridPat.SelectionMode = OpenDental.UI.GridSelectionMode.None;
			this.gridPat.Size = new System.Drawing.Size(252,81);
			this.gridPat.TabIndex = 195;
			this.gridPat.Title = "Patient Information";
			this.gridPat.TranslationName = "TablePatient";
			this.gridPat.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridPat_CellDoubleClick);
			// 
			// textProcDate
			// 
			this.textProcDate.Location = new System.Drawing.Point(98,12);
			this.textProcDate.Name = "textProcDate";
			this.textProcDate.Size = new System.Drawing.Size(76,20);
			this.textProcDate.TabIndex = 100;
			// 
			// signatureBoxWrapper
			// 
			this.signatureBoxWrapper.BackColor = System.Drawing.SystemColors.ControlDark;
			this.signatureBoxWrapper.LabelText = "Invalid Signature";
			this.signatureBoxWrapper.Location = new System.Drawing.Point(98,276);
			this.signatureBoxWrapper.Name = "signatureBoxWrapper";
			this.signatureBoxWrapper.Size = new System.Drawing.Size(364,81);
			this.signatureBoxWrapper.TabIndex = 194;
			this.signatureBoxWrapper.SignatureChanged += new System.EventHandler(this.signatureBoxWrapper_SignatureChanged);
			// 
			// gridProc
			// 
			this.gridProc.HScrollVisible = true;
			this.gridProc.Location = new System.Drawing.Point(10,367);
			this.gridProc.Name = "gridProc";
			this.gridProc.ScrollValue = 0;
			this.gridProc.SelectionMode = OpenDental.UI.GridSelectionMode.MultiExtended;
			this.gridProc.Size = new System.Drawing.Size(710,222);
			this.gridProc.TabIndex = 193;
			this.gridProc.Title = "Procedures";
			this.gridProc.TranslationName = "TableProg";
			// 
			// textDateEntry
			// 
			this.textDateEntry.Location = new System.Drawing.Point(98,32);
			this.textDateEntry.Name = "textDateEntry";
			this.textDateEntry.ReadOnly = true;
			this.textDateEntry.Size = new System.Drawing.Size(76,20);
			this.textDateEntry.TabIndex = 95;
			// 
			// butExamSheets
			// 
			this.butExamSheets.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butExamSheets.Autosize = true;
			this.butExamSheets.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butExamSheets.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butExamSheets.CornerRadius = 4F;
			this.butExamSheets.Location = new System.Drawing.Point(296,42);
			this.butExamSheets.Name = "butExamSheets";
			this.butExamSheets.Size = new System.Drawing.Size(80,24);
			this.butExamSheets.TabIndex = 106;
			this.butExamSheets.Text = "Exam Sheets";
			this.butExamSheets.Click += new System.EventHandler(this.buttonUseAutoNote_Click);
			// 
			// buttonUseAutoNote
			// 
			this.buttonUseAutoNote.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.buttonUseAutoNote.Autosize = true;
			this.buttonUseAutoNote.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.buttonUseAutoNote.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.buttonUseAutoNote.CornerRadius = 4F;
			this.buttonUseAutoNote.Location = new System.Drawing.Point(382,42);
			this.buttonUseAutoNote.Name = "buttonUseAutoNote";
			this.buttonUseAutoNote.Size = new System.Drawing.Size(80,24);
			this.buttonUseAutoNote.TabIndex = 106;
			this.buttonUseAutoNote.Text = "Auto Note";
			this.buttonUseAutoNote.Click += new System.EventHandler(this.buttonUseAutoNote_Click);
			// 
			// textNotes
			// 
			this.textNotes.AcceptsReturn = true;
			this.textNotes.AcceptsTab = true;
			this.textNotes.Location = new System.Drawing.Point(98,72);
			this.textNotes.Multiline = true;
			this.textNotes.Name = "textNotes";
			this.textNotes.QuickPasteType = OpenDentBusiness.QuickPasteType.Procedure;
			this.textNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textNotes.Size = new System.Drawing.Size(364,200);
			this.textNotes.TabIndex = 1;
			this.textNotes.TextChanged += new System.EventHandler(this.textNotes_TextChanged);
			// 
			// butDelete
			// 
			this.butDelete.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butDelete.Autosize = true;
			this.butDelete.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butDelete.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butDelete.CornerRadius = 4F;
			this.butDelete.Image = global::OpenDental.Properties.Resources.deleteX;
			this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butDelete.Location = new System.Drawing.Point(19,606);
			this.butDelete.Name = "butDelete";
			this.butDelete.Size = new System.Drawing.Size(83,24);
			this.butDelete.TabIndex = 8;
			this.butDelete.Text = "&Delete";
			this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
			// 
			// butCancel
			// 
			this.butCancel.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butCancel.Autosize = true;
			this.butCancel.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butCancel.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butCancel.CornerRadius = 4F;
			this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.butCancel.Location = new System.Drawing.Point(635,606);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(76,24);
			this.butCancel.TabIndex = 13;
			this.butCancel.Text = "&Cancel";
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
			// 
			// butOK
			// 
			this.butOK.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.butOK.Autosize = true;
			this.butOK.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butOK.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butOK.CornerRadius = 4F;
			this.butOK.Location = new System.Drawing.Point(553,606);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(76,24);
			this.butOK.TabIndex = 12;
			this.butOK.Text = "&OK";
			this.butOK.Click += new System.EventHandler(this.butOK_Click);
			// 
			// comboDPC
			// 
			this.comboDPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDPC.DropDownWidth = 177;
			this.comboDPC.FormattingEnabled = true;
			this.comboDPC.Location = new System.Drawing.Point(543,174);
			this.comboDPC.MaxDropDownItems = 30;
			this.comboDPC.Name = "comboDPC";
			this.comboDPC.Size = new System.Drawing.Size(177,21);
			this.comboDPC.TabIndex = 197;
			this.comboDPC.SelectedIndexChanged += new System.EventHandler(this.comboDPC_SelectedIndexChanged);
			// 
			// labelDPC
			// 
			this.labelDPC.Location = new System.Drawing.Point(473,175);
			this.labelDPC.Name = "labelDPC";
			this.labelDPC.Size = new System.Drawing.Size(73,16);
			this.labelDPC.TabIndex = 196;
			this.labelDPC.Text = "DPC";
			this.labelDPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(463,203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83,16);
			this.label1.TabIndex = 196;
			this.label1.Text = "On Call";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(463,226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83,16);
			this.label3.TabIndex = 196;
			this.label3.Text = "Effective Comm";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(463,249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83,16);
			this.label4.TabIndex = 196;
			this.label4.Text = "Repair";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butRepairN
			// 
			this.butRepairN.Location = new System.Drawing.Point(566,247);
			this.butRepairN.Name = "butRepairN";
			this.butRepairN.Size = new System.Drawing.Size(23,20);
			this.butRepairN.TabIndex = 198;
			this.butRepairN.Text = "N";
			this.butRepairN.UseVisualStyleBackColor = true;
			// 
			// butRepairY
			// 
			this.butRepairY.Location = new System.Drawing.Point(543,247);
			this.butRepairY.Name = "butRepairY";
			this.butRepairY.Size = new System.Drawing.Size(23,20);
			this.butRepairY.TabIndex = 198;
			this.butRepairY.Text = "Y";
			this.butRepairY.UseVisualStyleBackColor = true;
			// 
			// butEffectiveCommY
			// 
			this.butEffectiveCommY.Location = new System.Drawing.Point(543,224);
			this.butEffectiveCommY.Name = "butEffectiveCommY";
			this.butEffectiveCommY.Size = new System.Drawing.Size(23,20);
			this.butEffectiveCommY.TabIndex = 198;
			this.butEffectiveCommY.Text = "Y";
			this.butEffectiveCommY.UseVisualStyleBackColor = true;
			// 
			// butEffectiveCommN
			// 
			this.butEffectiveCommN.Location = new System.Drawing.Point(566,224);
			this.butEffectiveCommN.Name = "butEffectiveCommN";
			this.butEffectiveCommN.Size = new System.Drawing.Size(23,20);
			this.butEffectiveCommN.TabIndex = 198;
			this.butEffectiveCommN.Text = "N";
			this.butEffectiveCommN.UseVisualStyleBackColor = true;
			// 
			// butOnCallN
			// 
			this.butOnCallN.Location = new System.Drawing.Point(566,201);
			this.butOnCallN.Name = "butOnCallN";
			this.butOnCallN.Size = new System.Drawing.Size(23,20);
			this.butOnCallN.TabIndex = 198;
			this.butOnCallN.Text = "N";
			this.butOnCallN.UseVisualStyleBackColor = true;
			// 
			// butOnCallY
			// 
			this.butOnCallY.Location = new System.Drawing.Point(543,201);
			this.butOnCallY.Name = "butOnCallY";
			this.butOnCallY.Size = new System.Drawing.Size(23,20);
			this.butOnCallY.TabIndex = 198;
			this.butOnCallY.Text = "Y";
			this.butOnCallY.UseVisualStyleBackColor = true;
			// 
			// butRx
			// 
			this.butRx.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butRx.Autosize = true;
			this.butRx.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butRx.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butRx.CornerRadius = 4F;
			this.butRx.Location = new System.Drawing.Point(267,42);
			this.butRx.Name = "butRx";
			this.butRx.Size = new System.Drawing.Size(23,24);
			this.butRx.TabIndex = 106;
			this.butRx.Text = "Rx";
			this.butRx.Click += new System.EventHandler(this.buttonUseAutoNote_Click);
			// 
			// FormProcGroup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5,13);
			this.ClientSize = new System.Drawing.Size(730,645);
			this.Controls.Add(this.butRepairN);
			this.Controls.Add(this.butEffectiveCommN);
			this.Controls.Add(this.butOnCallN);
			this.Controls.Add(this.butRepairY);
			this.Controls.Add(this.butEffectiveCommY);
			this.Controls.Add(this.butOnCallY);
			this.Controls.Add(this.comboDPC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelDPC);
			this.Controls.Add(this.gridPat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textProcDate);
			this.Controls.Add(this.signatureBoxWrapper);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.gridProc);
			this.Controls.Add(this.textDateEntry);
			this.Controls.Add(this.butRx);
			this.Controls.Add(this.butExamSheets);
			this.Controls.Add(this.buttonUseAutoNote);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textUser);
			this.Controls.Add(this.textNotes);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.butDelete);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.butOK);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormProcGroup";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Group Note";
			this.Load += new System.EventHandler(this.FormProcGroup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		//Load function from FormProcEdit (FormProcInfo_Load)... (Single procedure - but form looks like I want)
		private void FormProcGroup_Load(object sender, System.EventArgs e){
			PatCur=Patients.GetPat(GroupCur.PatNum);
			FamCur=Patients.GetFamily(GroupCur.PatNum);
			GroupOld=GroupCur.Copy();
			IsStartingUp=true;
			textProcDate.Text=GroupCur.ProcDate.ToShortDateString();
			textDateEntry.Text=GroupCur.DateEntryC.ToShortDateString();
			textUser.Text=Userods.GetName(GroupCur.UserNum);//might be blank. Will change automatically if user changes note or alters sig.
			textNotes.Text=GroupCur.Note;
			FillProcedures();
			textNotes.Select();
			string keyData=GetSignatureKey();
			signatureBoxWrapper.FillSignature(GroupCur.SigIsTopaz,keyData,GroupCur.Signature);
			signatureBoxWrapper.BringToFront();
			FillPatientData();
			IsStartingUp=false;
		}

		private void FillPatientData(){
			if(PatCur==null){
				gridPat.BeginUpdate();
				gridPat.Rows.Clear();
				gridPat.Columns.Clear();
				gridPat.EndUpdate();
				return;
			}
			gridPat.BeginUpdate();
			gridPat.Columns.Clear();
			ODGridColumn col=new ODGridColumn("",100);
			gridPat.Columns.Add(col);
			col=new ODGridColumn("",150);
			gridPat.Columns.Add(col);
			gridPat.Rows.Clear();
			ODGridRow row;
			PatFieldList=PatFields.Refresh(PatCur.PatNum);
			List<DisplayField> fields=DisplayFields.GetForCategory(DisplayFieldCategory.PatientInformation);
			for(int f=0;f<fields.Count;f++) {
				row=new ODGridRow();
				if(fields[f].Description==""){
					//...
				}
				else{
					if(fields[f].InternalName=="PatFields") {
						//don't add a cell
					}
					else {
						row.Cells.Add(fields[f].Description);
					}
				}
				switch(fields[f].InternalName){
					//...
					case "PatFields":
						PatField field;
						for(int i=0;i<PatFieldDefs.List.Length;i++){
							if(i>0){
								row=new ODGridRow();
							}
							row.Cells.Add(PatFieldDefs.List[i].FieldName);
							field=PatFields.GetByName(PatFieldDefs.List[i].FieldName,PatFieldList);
							if(field==null){
								row.Cells.Add("");
							}
							else{
								row.Cells.Add(field.FieldValue);
							}
							row.Tag="PatField"+i.ToString();
							gridPat.Rows.Add(row);
						}
						break;
				}
				if(fields[f].InternalName=="PatFields"){
					//don't add the row here
				}
				else{
					gridPat.Rows.Add(row);
				}
			}
			gridPat.EndUpdate();
		}

		private void FillProcedures(){
			gridProc.BeginUpdate();
			gridProc.Columns.Clear();
			ODGridColumn col;
			DisplayFields.RefreshCache();
			List<DisplayField> fields=DisplayFields.GetForCategory(DisplayFieldCategory.ProcedureGroupNote);
			for(int i=0;i<fields.Count;i++) {
				if(fields[i].Description=="") {
					col=new ODGridColumn(fields[i].InternalName,fields[i].ColumnWidth);
				}
				else {
					col=new ODGridColumn(fields[i].Description,fields[i].ColumnWidth);
				}
				if(fields[i].InternalName=="Amount") {
					col.TextAlign=HorizontalAlignment.Right;
				}
				if(fields[i].InternalName=="ADA Code") {
					col.TextAlign=HorizontalAlignment.Center;
				}
				gridProc.Columns.Add(col);
			}
			gridProc.Rows.Clear();
			for(int i=0;i<ProcList.Count;i++) {
				ODGridRow row=new ODGridRow();
				for(int f=0;f<fields.Count;f++) {
					switch(fields[f].InternalName) {
						case "Date":
							row.Cells.Add(ProcList[i].ProcDate.ToShortDateString());
							break;
						case "Th":
							row.Cells.Add(ProcList[i].ToothNum.ToString());
							break;
						case "Surf":
							row.Cells.Add(ProcList[i].Surf.ToString());
							break;
						case "Description":
							row.Cells.Add(ProcedureCodes.GetLaymanTerm(ProcList[i].CodeNum));
							break;
						case "Stat":
							row.Cells.Add(ProcList[i].ProcStatus.ToString());
							break;
						case "Prov":
							row.Cells.Add(Providers.GetAbbr(ProcList[i].ProvNum));
							break;
						case "Amount":
							row.Cells.Add(ProcList[i].ProcFee.ToString("F"));
							break;
						case "ADA Code":
							row.Cells.Add(ProcedureCodes.GetStringProcCode(ProcList[i].CodeNum));
							break;
					}
				}
				gridProc.Rows.Add(row);
			}
			gridProc.EndUpdate();
		}

		private void buttonUseAutoNote_Click(object sender,EventArgs e) {
			FormExamSheets fes=new FormExamSheets();
			fes.PatNum=GroupCur.PatNum;
			fes.ShowDialog();
		}

		private void textNotes_TextChanged(object sender,EventArgs e) {
			if(!IsStartingUp//so this happens only if user changes the note
				&& !SigChanged)//and the original signature is still showing.
			{
				//SigChanged=true;//happens automatically through the event.
				signatureBoxWrapper.ClearSignature();
			}
		}

		private string GetSignatureKey(){
			string keyData=GroupCur.ProcDate.ToShortDateString();
			keyData+=GroupCur.DateEntryC.ToShortDateString();
			keyData+=GroupCur.UserNum.ToString();//Security.CurUser.UserName;
			keyData+=GroupCur.Note;
			GroupItemList=ProcGroupItems.Refresh(GroupCur.ProcNum);//Orders the list to ensure same key in all cases.
			for(int i=0;i<GroupItemList.Count;i++){
				keyData+=GroupItemList[i].ProcGroupItemNum.ToString();
			}
			return keyData;
		}

		private void SaveSignature(){
			if(SigChanged){
				string keyData=GetSignatureKey();
				GroupCur.Signature=signatureBoxWrapper.GetSignature(keyData);
				GroupCur.SigIsTopaz=signatureBoxWrapper.GetSigIsTopaz();
			}
		}

		private void signatureBoxWrapper_SignatureChanged(object sender,EventArgs e) {
			GroupCur.UserNum=Security.CurUser.UserNum;
			textUser.Text=Userods.GetName(GroupCur.UserNum);
			SigChanged=true;
		}

		private void butDelete_Click(object sender, System.EventArgs e) {
			bool result=MsgBox.Show(this,MsgBoxButtons.YesNo,"Are you sure you want delete this group note?");
			if(result){
				Procedures.Delete(GroupCur.ProcNum);
				for(int i=0;i<GroupItemList.Count;i++){
					ProcGroupItems.Delete(GroupItemList[i].ProcGroupItemNum);
				}
				DialogResult=DialogResult.Cancel;
			}
			return;
		}		

		private void butOK_Click(object sender,System.EventArgs e) {
			GroupCur.Note=textNotes.Text;
			if(!signatureBoxWrapper.IsValid){
				MsgBox.Show(this,"Your signature is invalid. Please sign and click OK again.");
				return;
			}
			try {
				SaveSignature();
			}
			catch(Exception ex){
				MessageBox.Show(Lan.g(this,"Error saving signature.")+"\r\n"+ex.Message);
			}
			Procedures.Update(GroupCur,GroupOld);
      DialogResult=DialogResult.OK;
		}

		private void butCancel_Click(object sender,System.EventArgs e) {
			if(GroupCur.IsNew){
				Procedures.Delete(GroupCur.ProcNum);
				for(int i=0;i<GroupItemList.Count;i++){
					ProcGroupItems.Delete(GroupItemList[i].ProcGroupItemNum);
				}
			}
			DialogResult=DialogResult.Cancel;
		}

		private void gridPat_CellDoubleClick(object sender,ODGridClickEventArgs e) {
			string tag=gridPat.Rows[e.Row].Tag.ToString();
			tag=tag.Substring(8);//strips off all but the number: PatField1
			int index=PIn.Int(tag);
			PatField field=PatFields.GetByName(PatFieldDefs.List[index].FieldName,PatFieldList);
			if(field==null) {
				field=new PatField();
				field.PatNum=PatCur.PatNum;
				field.FieldName=PatFieldDefs.List[index].FieldName;
				if(PatFieldDefs.List[index].FieldType==PatFieldType.Text) {
					FormPatFieldEdit FormPF=new FormPatFieldEdit(field);
					FormPF.IsNew=true;
					FormPF.ShowDialog();
				}
				if(PatFieldDefs.List[index].FieldType==PatFieldType.PickList) {
					FormPatFieldPickEdit FormPF=new FormPatFieldPickEdit(field);
					FormPF.IsNew=true;
					FormPF.ShowDialog();
				}
				if(PatFieldDefs.List[index].FieldType==PatFieldType.Date) {
					FormPatFieldDateEdit FormPF=new FormPatFieldDateEdit(field);
					FormPF.IsNew=true;
					FormPF.ShowDialog();
				}
			}
			else{
				if(PatFieldDefs.List[index].FieldType==PatFieldType.Text) {
					FormPatFieldEdit FormPF=new FormPatFieldEdit(field);
					FormPF.ShowDialog();
				}
				if(PatFieldDefs.List[index].FieldType==PatFieldType.PickList) {
					FormPatFieldPickEdit FormPF=new FormPatFieldPickEdit(field);
					FormPF.ShowDialog();
				}
				if(PatFieldDefs.List[index].FieldType==PatFieldType.Date) {
					FormPatFieldDateEdit FormPF=new FormPatFieldDateEdit(field);
					FormPF.ShowDialog();
				}
			}
			FillPatientData();
		}

		private void comboDPC_SelectedIndexChanged(object sender,EventArgs e) {
			//Have fun Jason!
		}

		










	}
}
