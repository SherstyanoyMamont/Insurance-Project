using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Insurance_Project
{
    public partial class SearchForm : Form
    {

        private InsuranceCatalog Сatalog;
        

        public List<Insurance> Insurances = new List<Insurance>();
        private Insurance selectedInsurance;

        public SearchForm(InsuranceCatalog catalog)
        {


            InitializeComponent();
            //dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            Сatalog = catalog;
            Insurances = Сatalog.ListInsurance;
            //PopulateListBox();
            
            //PopulatedataGridViewSearch();
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {

            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = new BindingList<Insurance>(this.Insurances.ToList());

            

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteColumn);

            // format the column header
            dgvProducts.EnableHeadersVisualStyles = false;
            //dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvProducts.Columns[0].HeaderText = "Code";
            dgvProducts.Columns[0].Width = 60;

            // format the second column
            dgvProducts.Columns[1].HeaderText = "Name";
            dgvProducts.Columns[1].Width = 170;

            // format the third column
            dgvProducts.Columns[2].HeaderText = "Phone Number";
            dgvProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[2].Width = 160;
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvProducts.Columns[2].Visible = false;

            // format the forth column
            dgvProducts.Columns[3].HeaderText = "Coverage";
            dgvProducts.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[3].Width = 100;
            dgvProducts.Columns[3].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            dgvProducts.Columns[4].HeaderText = "Final Price";
            dgvProducts.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[4].Width = 130;
            dgvProducts.Columns[4].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvProducts.Columns[4].Visible = false;

            // format the forth column
            dgvProducts.Columns[5].HeaderText = "Car";
            dgvProducts.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[5].Width = 280;
            dgvProducts.Columns[5].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvProducts.Columns[5].Visible = false;

            dgvProducts.Columns[6].Visible = false;

            dgvProducts.Columns[7].Visible = false;

            dgvProducts.Columns[8].Visible = false;




        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button columns
            const int ModifyIndex = 9;
            const int DeleteIndex = 10;

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedInsurance = GetProduct(productCode);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyProduct(e.RowIndex);
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteProduct();
            }
        }

        private Insurance GetProduct(string productCode)
        {
            foreach (Insurance p in Insurances)
            {
                if (p.InsuranceCode.Equals(productCode)) return p;
            }
            return null;

        }

        private void ModifyProduct(int indexOfOld)
        {
            var oldInsurance = new Insurance(selectedInsurance.Client, selectedInsurance.Coverage)
            {
                InsuranceCode = selectedInsurance.InsuranceCode,
                ClientName = selectedInsurance.ClientName,
                ClientPhone = selectedInsurance.ClientPhone

            };

            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddInsurance = false,
                Insurance = selectedInsurance
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {

                    this.Insurances[indexOfOld] = selectedInsurance;
                    DisplayProducts();


                }

                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        // delete the selected product
        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedInsurance.InsuranceCode.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    if (Insurances.Remove(selectedInsurance))
                    {
                        DisplayProducts();
                    }

                }

                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        // Search for a record by name
        private void button1_Click(object sender, EventArgs e) 
        {
            string searchName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Enter a first name to search.");
                return;
            }

            bool found = false;

            foreach (var insurance in Сatalog.ListInsurance)
            {
                if (insurance.Client.FirstName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    // If the client has several cars, we show the first one or the entire list
                    string carsInfo = "";
                    foreach (var car in insurance.Client.Cars)
                    {
                        carsInfo += $"\n - {car.Brand} {car.Model} ({car.Colour})";
                    }

                    MessageBox.Show(
                        $"Full name: {insurance.Client.Gender} {insurance.Client.FirstName} {insurance.Client.LastName}" +
                        $"\nCars:{carsInfo}" +
                        $"\nPrice: {insurance.FinalPrice} €" +
                        $"\nDate: {insurance.Client.DateTimeNow}"
                    );

                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Record not found.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Enter a first name to search.");
                return;
            }

            bool found = false;

            foreach (var insurance in Сatalog.ListInsurance)
            {
                if (insurance.Client.FirstName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;

                    // If the client has several cars, we show the first one or the entire list
                    string carsInfo = "";
                    foreach (var car in insurance.Client.Cars)
                    {
                        carsInfo += $"\n - {car.Brand} {car.Model} ({car.Colour})";
                    }

                    MessageBox.Show(
                        $"Full name: {insurance.Client.Gender} {insurance.Client.FirstName} {insurance.Client.LastName}" +
                        $"\nCars:{carsInfo}" +
                        $"\nPrice: {insurance.FinalPrice} €" +
                        $"\nDate: {insurance.Client.DateTimeNow}"
                    );

                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Record not found.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyProductForm = new frmAddModifyProduct()
            {
                AddInsurance = true
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedInsurance = addModifyProductForm.Insurance;
                    this.Insurances.Add(selectedInsurance);
                    DisplayProducts();
                }

                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }


        /// </New Table>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </Old table>
        private void PopulateListBox() // Display all records in the ListBox
        {
            listBox1.Items.Clear(); // Clear to prevent duplicates on repeated calls

            if (Сatalog.ListInsurance.Count == 0)
            {
                listBox1.Items.Add("No insurance records found.");
                return;
            }

            foreach (var insurance in Сatalog.ListInsurance)
            {
                var client = insurance.Client;

                string item =
                    $"👤 Name: {client.FirstName} {client.LastName} | " +
                    $"📞 Phone: {client.PhoneNumber} | " +
                    $"🚗 Car: {client.Cars[0].Brand} {client.Cars[0].Model} | " +
                    $"💰 Price: {insurance.FinalPrice} € | " +
                    $"📅 Date: {insurance.Client.DateTimeNow:dd.MM.yyyy}";

                listBox1.Items.Add(item);
            }
        }


    }
}
