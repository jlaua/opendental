using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenDentBusiness;

namespace OpenDental {
	public partial class FormAllergySetup:Form {
		public FormAllergySetup() {
			InitializeComponent();
			Lan.F(this);
		}

		private void FormAllergySetup_Load(object sender,EventArgs e) {

		}

		private void butAdd_Click(object sender,EventArgs e) {

		}

		private void butClose_Click(object sender,EventArgs e) {
			DialogResult=DialogResult.Cancel;
		}
	}
}