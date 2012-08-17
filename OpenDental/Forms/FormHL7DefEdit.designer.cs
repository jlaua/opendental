namespace OpenDental{
	partial class FormHL7DefEdit {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHL7DefEdit));
			this.gridMain = new OpenDental.UI.ODGrid();
			this.label15 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textNote = new System.Windows.Forms.TextBox();
			this.labelOutPortEx = new System.Windows.Forms.Label();
			this.labelInPortEx = new System.Windows.Forms.Label();
			this.textInternalTypeVersion = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textInternalType = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.checkEnabled = new System.Windows.Forms.CheckBox();
			this.textEscChar = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.checkInternal = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textSubcompSep = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textRepSep = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textCompSep = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textFieldSep = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboModeTx = new System.Windows.Forms.ComboBox();
			this.textOutPort = new System.Windows.Forms.TextBox();
			this.labelOutPort = new System.Windows.Forms.Label();
			this.textInPort = new System.Windows.Forms.TextBox();
			this.labelInPort = new System.Windows.Forms.Label();
			this.textOutPath = new System.Windows.Forms.TextBox();
			this.labelOutPath = new System.Windows.Forms.Label();
			this.textInPath = new System.Windows.Forms.TextBox();
			this.labelInPath = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textDescription = new System.Windows.Forms.TextBox();
			this.labelDelete = new System.Windows.Forms.Label();
			this.butOK = new OpenDental.UI.Button();
			this.butCancel = new OpenDental.UI.Button();
			this.butDelete = new OpenDental.UI.Button();
			this.butBrowseOut = new OpenDental.UI.Button();
			this.butBrowseIn = new OpenDental.UI.Button();
			this.butAdd = new OpenDental.UI.Button();
			this.SuspendLayout();
			// 
			// gridMain
			// 
			this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridMain.HScrollVisible = false;
			this.gridMain.Location = new System.Drawing.Point(17,288);
			this.gridMain.Name = "gridMain";
			this.gridMain.ScrollValue = 0;
			this.gridMain.Size = new System.Drawing.Size(898,318);
			this.gridMain.TabIndex = 18;
			this.gridMain.Title = "Messages / Segments";
			this.gridMain.TranslationName = null;
			this.gridMain.CellDoubleClick += new OpenDental.UI.ODGridClickEventHandler(this.gridMain_CellDoubleClick);
			this.gridMain.CellClick += new OpenDental.UI.ODGridClickEventHandler(this.gridMain_CellClick);
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label15.Location = new System.Drawing.Point(221,253);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(105,18);
			this.label15.TabIndex = 63;
			this.label15.Text = "Default: \\";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.Location = new System.Drawing.Point(221,233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105,18);
			this.label6.TabIndex = 62;
			this.label6.Text = "Default: &";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.UseMnemonic = false;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.Location = new System.Drawing.Point(221,213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105,18);
			this.label5.TabIndex = 61;
			this.label5.Text = "Default: ^";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.Location = new System.Drawing.Point(221,193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105,18);
			this.label4.TabIndex = 60;
			this.label4.Text = "Default: ~";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.Location = new System.Drawing.Point(221,173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105,18);
			this.label3.TabIndex = 59;
			this.label3.Text = "Default: |";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textNote
			// 
			this.textNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textNote.Location = new System.Drawing.Point(473,77);
			this.textNote.Multiline = true;
			this.textNote.Name = "textNote";
			this.textNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textNote.Size = new System.Drawing.Size(356,196);
			this.textNote.TabIndex = 56;
			// 
			// labelOutPortEx
			// 
			this.labelOutPortEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelOutPortEx.Location = new System.Drawing.Point(332,155);
			this.labelOutPortEx.Name = "labelOutPortEx";
			this.labelOutPortEx.Size = new System.Drawing.Size(145,18);
			this.labelOutPortEx.TabIndex = 58;
			this.labelOutPortEx.Text = "Ex: 192.168.0.23:5846";
			this.labelOutPortEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelInPortEx
			// 
			this.labelInPortEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelInPortEx.Location = new System.Drawing.Point(332,134);
			this.labelInPortEx.Name = "labelInPortEx";
			this.labelInPortEx.Size = new System.Drawing.Size(145,18);
			this.labelInPortEx.TabIndex = 57;
			this.labelInPortEx.Text = "Ex: 5845";
			this.labelInPortEx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textInternalTypeVersion
			// 
			this.textInternalTypeVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textInternalTypeVersion.Location = new System.Drawing.Point(190,113);
			this.textInternalTypeVersion.Name = "textInternalTypeVersion";
			this.textInternalTypeVersion.ReadOnly = true;
			this.textInternalTypeVersion.Size = new System.Drawing.Size(100,20);
			this.textInternalTypeVersion.TabIndex = 44;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label13.Location = new System.Drawing.Point(44,113);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(145,18);
			this.label13.TabIndex = 39;
			this.label13.Text = "Internal Type Version";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textInternalType
			// 
			this.textInternalType.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textInternalType.Location = new System.Drawing.Point(190,93);
			this.textInternalType.Name = "textInternalType";
			this.textInternalType.ReadOnly = true;
			this.textInternalType.Size = new System.Drawing.Size(138,20);
			this.textInternalType.TabIndex = 43;
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label14.Location = new System.Drawing.Point(44,93);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(145,18);
			this.label14.TabIndex = 28;
			this.label14.Text = "Internal Type";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkEnabled
			// 
			this.checkEnabled.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkEnabled.Checked = true;
			this.checkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkEnabled.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEnabled.Location = new System.Drawing.Point(58,31);
			this.checkEnabled.Name = "checkEnabled";
			this.checkEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkEnabled.Size = new System.Drawing.Size(145,18);
			this.checkEnabled.TabIndex = 40;
			this.checkEnabled.Text = "Enabled";
			this.checkEnabled.CheckedChanged += new System.EventHandler(this.checkEnabled_CheckedChanged);
			// 
			// textEscChar
			// 
			this.textEscChar.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textEscChar.Location = new System.Drawing.Point(190,253);
			this.textEscChar.Name = "textEscChar";
			this.textEscChar.Size = new System.Drawing.Size(27,20);
			this.textEscChar.TabIndex = 55;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label12.Location = new System.Drawing.Point(44,253);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(145,18);
			this.label12.TabIndex = 26;
			this.label12.Text = "Escape Character";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkInternal
			// 
			this.checkInternal.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkInternal.Enabled = false;
			this.checkInternal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkInternal.Location = new System.Drawing.Point(58,13);
			this.checkInternal.Name = "checkInternal";
			this.checkInternal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkInternal.Size = new System.Drawing.Size(145,18);
			this.checkInternal.TabIndex = 31;
			this.checkInternal.TabStop = false;
			this.checkInternal.Text = "Internal";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label11.Location = new System.Drawing.Point(345,77);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(127,18);
			this.label11.TabIndex = 32;
			this.label11.Text = "Note";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textSubcompSep
			// 
			this.textSubcompSep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textSubcompSep.Location = new System.Drawing.Point(190,233);
			this.textSubcompSep.Name = "textSubcompSep";
			this.textSubcompSep.Size = new System.Drawing.Size(27,20);
			this.textSubcompSep.TabIndex = 54;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label9.Location = new System.Drawing.Point(44,233);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(145,18);
			this.label9.TabIndex = 30;
			this.label9.Text = "Subcomponent Separator";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textRepSep
			// 
			this.textRepSep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textRepSep.Location = new System.Drawing.Point(190,193);
			this.textRepSep.Name = "textRepSep";
			this.textRepSep.Size = new System.Drawing.Size(27,20);
			this.textRepSep.TabIndex = 52;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label10.Location = new System.Drawing.Point(44,193);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(145,18);
			this.label10.TabIndex = 27;
			this.label10.Text = "Repetition Separator";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textCompSep
			// 
			this.textCompSep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textCompSep.Location = new System.Drawing.Point(190,213);
			this.textCompSep.Name = "textCompSep";
			this.textCompSep.Size = new System.Drawing.Size(27,20);
			this.textCompSep.TabIndex = 53;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.Location = new System.Drawing.Point(44,213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(145,18);
			this.label8.TabIndex = 25;
			this.label8.Text = "Component Separator";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textFieldSep
			// 
			this.textFieldSep.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textFieldSep.Location = new System.Drawing.Point(190,173);
			this.textFieldSep.Name = "textFieldSep";
			this.textFieldSep.Size = new System.Drawing.Size(27,20);
			this.textFieldSep.TabIndex = 51;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.Location = new System.Drawing.Point(44,173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145,18);
			this.label7.TabIndex = 36;
			this.label7.Text = "Field Separator";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboModeTx
			// 
			this.comboModeTx.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboModeTx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModeTx.Location = new System.Drawing.Point(190,72);
			this.comboModeTx.MaxDropDownItems = 100;
			this.comboModeTx.Name = "comboModeTx";
			this.comboModeTx.Size = new System.Drawing.Size(138,21);
			this.comboModeTx.TabIndex = 42;
			this.comboModeTx.SelectedIndexChanged += new System.EventHandler(this.comboModeTx_SelectedIndexChanged);
			// 
			// textOutPort
			// 
			this.textOutPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textOutPort.Location = new System.Drawing.Point(190,153);
			this.textOutPort.Name = "textOutPort";
			this.textOutPort.Size = new System.Drawing.Size(138,20);
			this.textOutPort.TabIndex = 46;
			// 
			// labelOutPort
			// 
			this.labelOutPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelOutPort.Location = new System.Drawing.Point(44,153);
			this.labelOutPort.Name = "labelOutPort";
			this.labelOutPort.Size = new System.Drawing.Size(145,18);
			this.labelOutPort.TabIndex = 29;
			this.labelOutPort.Text = "Outgoing IP:Port";
			this.labelOutPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textInPort
			// 
			this.textInPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textInPort.Location = new System.Drawing.Point(190,133);
			this.textInPort.Name = "textInPort";
			this.textInPort.Size = new System.Drawing.Size(70,20);
			this.textInPort.TabIndex = 45;
			// 
			// labelInPort
			// 
			this.labelInPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelInPort.Location = new System.Drawing.Point(44,133);
			this.labelInPort.Name = "labelInPort";
			this.labelInPort.Size = new System.Drawing.Size(145,18);
			this.labelInPort.TabIndex = 37;
			this.labelInPort.Text = "Incoming Port";
			this.labelInPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textOutPath
			// 
			this.textOutPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textOutPath.Location = new System.Drawing.Point(473,51);
			this.textOutPath.Name = "textOutPath";
			this.textOutPath.Size = new System.Drawing.Size(356,20);
			this.textOutPath.TabIndex = 49;
			// 
			// labelOutPath
			// 
			this.labelOutPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelOutPath.Location = new System.Drawing.Point(345,51);
			this.labelOutPath.Name = "labelOutPath";
			this.labelOutPath.Size = new System.Drawing.Size(127,18);
			this.labelOutPath.TabIndex = 38;
			this.labelOutPath.Text = "Outgoing Folder";
			this.labelOutPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textInPath
			// 
			this.textInPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textInPath.Location = new System.Drawing.Point(473,18);
			this.textInPath.Name = "textInPath";
			this.textInPath.Size = new System.Drawing.Size(356,20);
			this.textInPath.TabIndex = 47;
			// 
			// labelInPath
			// 
			this.labelInPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelInPath.Location = new System.Drawing.Point(345,18);
			this.labelInPath.Name = "labelInPath";
			this.labelInPath.Size = new System.Drawing.Size(127,18);
			this.labelInPath.TabIndex = 35;
			this.labelInPath.Text = "Incoming Folder";
			this.labelInPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.Location = new System.Drawing.Point(44,72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145,18);
			this.label2.TabIndex = 34;
			this.label2.Text = "ModeTx";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Location = new System.Drawing.Point(44,51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145,18);
			this.label1.TabIndex = 33;
			this.label1.Text = "Description";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textDescription
			// 
			this.textDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textDescription.Location = new System.Drawing.Point(190,51);
			this.textDescription.Name = "textDescription";
			this.textDescription.Size = new System.Drawing.Size(138,20);
			this.textDescription.TabIndex = 41;
			// 
			// labelDelete
			// 
			this.labelDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDelete.Font = new System.Drawing.Font("Microsoft Sans Serif",8.25F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(0)));
			this.labelDelete.Location = new System.Drawing.Point(108,610);
			this.labelDelete.Name = "labelDelete";
			this.labelDelete.Size = new System.Drawing.Size(266,28);
			this.labelDelete.TabIndex = 65;
			this.labelDelete.Text = "This HL7Def is internal. To edit this HL7Def you must first copy it to the Custom" +
    " list.";
			this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDelete.Visible = false;
			// 
			// butOK
			// 
			this.butOK.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butOK.Autosize = true;
			this.butOK.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butOK.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butOK.CornerRadius = 4F;
			this.butOK.Location = new System.Drawing.Point(754,612);
			this.butOK.Name = "butOK";
			this.butOK.Size = new System.Drawing.Size(75,24);
			this.butOK.TabIndex = 19;
			this.butOK.Text = "&OK";
			this.butOK.Click += new System.EventHandler(this.butOK_Click);
			// 
			// butCancel
			// 
			this.butCancel.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butCancel.Autosize = true;
			this.butCancel.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butCancel.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butCancel.CornerRadius = 4F;
			this.butCancel.Location = new System.Drawing.Point(840,612);
			this.butCancel.Name = "butCancel";
			this.butCancel.Size = new System.Drawing.Size(75,24);
			this.butCancel.TabIndex = 20;
			this.butCancel.Text = "&Cancel";
			this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
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
			this.butDelete.Location = new System.Drawing.Point(17,612);
			this.butDelete.Name = "butDelete";
			this.butDelete.Size = new System.Drawing.Size(85,24);
			this.butDelete.TabIndex = 0;
			this.butDelete.Text = "&Delete";
			this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
			// 
			// butBrowseOut
			// 
			this.butBrowseOut.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butBrowseOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.butBrowseOut.Autosize = true;
			this.butBrowseOut.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butBrowseOut.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butBrowseOut.CornerRadius = 4F;
			this.butBrowseOut.Location = new System.Drawing.Point(835,48);
			this.butBrowseOut.Name = "butBrowseOut";
			this.butBrowseOut.Size = new System.Drawing.Size(76,25);
			this.butBrowseOut.TabIndex = 50;
			this.butBrowseOut.Text = "&Browse";
			this.butBrowseOut.Click += new System.EventHandler(this.butBrowseOut_Click);
			// 
			// butBrowseIn
			// 
			this.butBrowseIn.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butBrowseIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.butBrowseIn.Autosize = true;
			this.butBrowseIn.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butBrowseIn.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butBrowseIn.CornerRadius = 4F;
			this.butBrowseIn.Location = new System.Drawing.Point(835,15);
			this.butBrowseIn.Name = "butBrowseIn";
			this.butBrowseIn.Size = new System.Drawing.Size(76,25);
			this.butBrowseIn.TabIndex = 48;
			this.butBrowseIn.Text = "&Browse";
			this.butBrowseIn.Click += new System.EventHandler(this.butBrowseIn_Click);
			// 
			// butAdd
			// 
			this.butAdd.AdjustImageLocation = new System.Drawing.Point(0,0);
			this.butAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.butAdd.Autosize = true;
			this.butAdd.BtnShape = OpenDental.UI.enumType.BtnShape.Rectangle;
			this.butAdd.BtnStyle = OpenDental.UI.enumType.XPStyle.Silver;
			this.butAdd.CornerRadius = 4F;
			this.butAdd.Image = global::OpenDental.Properties.Resources.Add;
			this.butAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butAdd.Location = new System.Drawing.Point(615,612);
			this.butAdd.Name = "butAdd";
			this.butAdd.Size = new System.Drawing.Size(80,24);
			this.butAdd.TabIndex = 0;
			this.butAdd.Text = "Add";
			this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
			// 
			// FormHL7DefEdit
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.ClientSize = new System.Drawing.Size(931,652);
			this.Controls.Add(this.butAdd);
			this.Controls.Add(this.labelDelete);
			this.Controls.Add(this.butOK);
			this.Controls.Add(this.butCancel);
			this.Controls.Add(this.butDelete);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textNote);
			this.Controls.Add(this.labelOutPortEx);
			this.Controls.Add(this.labelInPortEx);
			this.Controls.Add(this.textInternalTypeVersion);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textInternalType);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.checkEnabled);
			this.Controls.Add(this.textEscChar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.checkInternal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textSubcompSep);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textRepSep);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textCompSep);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textFieldSep);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboModeTx);
			this.Controls.Add(this.butBrowseOut);
			this.Controls.Add(this.butBrowseIn);
			this.Controls.Add(this.textOutPort);
			this.Controls.Add(this.labelOutPort);
			this.Controls.Add(this.textInPort);
			this.Controls.Add(this.labelInPort);
			this.Controls.Add(this.textOutPath);
			this.Controls.Add(this.labelOutPath);
			this.Controls.Add(this.textInPath);
			this.Controls.Add(this.labelInPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textDescription);
			this.Controls.Add(this.gridMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormHL7DefEdit";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HL7 Def Edit";
			this.Load += new System.EventHandler(this.FormHL7DefEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private OpenDental.UI.Button butOK;
		private OpenDental.UI.Button butCancel;
		private UI.ODGrid gridMain;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textNote;
		private System.Windows.Forms.Label labelOutPortEx;
		private System.Windows.Forms.Label labelInPortEx;
		private System.Windows.Forms.TextBox textInternalTypeVersion;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textInternalType;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox checkEnabled;
		private System.Windows.Forms.TextBox textEscChar;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckBox checkInternal;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textSubcompSep;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textRepSep;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textCompSep;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textFieldSep;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboModeTx;
		private UI.Button butBrowseOut;
		private UI.Button butBrowseIn;
		private System.Windows.Forms.TextBox textOutPort;
		private System.Windows.Forms.Label labelOutPort;
		private System.Windows.Forms.TextBox textInPort;
		private System.Windows.Forms.Label labelInPort;
		private System.Windows.Forms.TextBox textOutPath;
		private System.Windows.Forms.Label labelOutPath;
		private System.Windows.Forms.TextBox textInPath;
		private System.Windows.Forms.Label labelInPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textDescription;
		private UI.Button butDelete;
		private System.Windows.Forms.Label labelDelete;
		private UI.Button butAdd;
	}
}