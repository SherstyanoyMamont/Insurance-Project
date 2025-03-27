using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
                this.Text = "Add Product";
                txtCode.ReadOnly = false;  // allow entry of new product code
            }
            else
            {
                this.Text = "Modify Product";
                txtCode.ReadOnly = true;   // can't change existing product code
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtCode.Text = Insurance.InsuranceCode;
            txtPhoneNumber.Text = Insurance.ClientPhone;
            txtPrice.Text = Insurance.FinalPrice.ToString("N2");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddInsurance)
                {
                    // initialize the Product property with new Products object
                    this.Insurance = new Insurance();
                }
                this.LoadProductData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtPhoneNumber.Text, txtPhoneNumber.Tag.ToString());
            errorMessage += Validator.IsPresent(txtPrice.Text, txtPrice.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadProductData()
        {
            Insurance.InsuranceCode = txtCode.Text;
            Insurance.ClientPhone = txtPhoneNumber.Text;
            Insurance.FinalPrice = Convert.ToDouble(txtPrice.Text);

        }
    }

    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        // The IsInt32 and IsWithinRange methods were omitted from figure 12-15.
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min,
            decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + "." + LineEnd;
                }
            }
            return msg;
        }
    }
}
