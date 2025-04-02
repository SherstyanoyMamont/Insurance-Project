using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_Project
{
    public partial class frmAddModifyProduct : Form
    {
        public Insurance Insurance { get; set; }
        public bool AddInsurance { get; set; }

        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (AddInsurance)
            {
                this.Text = "Add New Insurance";

            }
            else
            {
                this.Text = "Modify Insurance";
                txtInsuranceCode.Text = Insurance.InsuranceCode;
                txtClientName.Text = Insurance.ClientName;
                txtClientPhone.Text = Insurance.ClientPhone;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInsuranceCode.Text) ||
                string.IsNullOrEmpty(txtClientName.Text) ||
                string.IsNullOrEmpty(txtClientPhone.Text))
            {
                MessageBox.Show("Please fill in all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            Insurance.InsuranceCode = txtInsuranceCode.Text.Trim();
            Insurance.ClientName = txtClientName.Text.Trim();
            Insurance.ClientPhone = txtClientPhone.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
