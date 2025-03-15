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
    public partial class SearchForm : Form
    {

        private InsuranceCatalog Сatalog;

        public SearchForm(InsuranceCatalog catalog)
        {
            InitializeComponent();
            Сatalog = catalog;

            PopulateListBox();
        }

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

        private void button1_Click(object sender, EventArgs e) // Search for a record by name
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
            foreach (var o in Сatalog.ListInsurance)
            {
                if (o.Client.FirstName == Convert.ToString(textBox1.Text))
                {
                    MessageBox.Show("Full name: " + o.Client.Gender + " " + o.Client.FirstName +
                        "\nMake auto: " + o.Client.Cars[0].Brand+
                        "\nPrise: " + o.FinalPrice + " €" +
                        "\nDate: " + o.Client.DateTimeNow);
                    break;
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
        }
    }
}
