﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Insurance_Project
{
    public partial class MainForm : Form
    {
        public InsuranceCatalog catalog = new InsuranceCatalog();
        public MainForm(User user)
        {
            InitializeComponent();

            // Loading insurances when launching the form
            JSONSaveLoad jsonHandler = new JSONSaveLoad();
            catalog.ListInsurance = jsonHandler.LoadListFromFile();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {

            List<Car> Cars = new();
            Car car = new Car(comboBoxCarBrand.Text, comboBoxCarModel.Text, textBoxColour.Text, (int)numericUpDownCarYear.Value, (int)numericUpDownEngineSize.Value, comboBoxEmission.Text, comboBoxCoverage.Text);
            Cars.Add(car);

            Client client = new(textBoxFirstName.Text, textBoxSurname.Text, dateTimePickerDoB.Value, comboBoxGender.Text, comboBoxLocation.Text, textBoxEmail.Text, maskedTextBoxPhoneNumber.Text, (int)numericUpDownDriverLicense.Value, (int)numericUpDownPenaltyPoints.Value, Cars);

            Insurance insurance = new(client, comboBoxCoverage.Text);

            insurance.CalculateInsuranceCost(client);

            catalog.AddInsurance(insurance);

            // Adds ID for clients and insurances
            for (int i = 0; i < catalog.ListInsurance.Count; i++)
            {
                catalog.ListInsurance[i].Client.id = i + 1;
                catalog.ListInsurance[i].id = i + 1;
            }


            // Save the updated list
            JSONSaveLoad instance = new JSONSaveLoad();
            instance.SaveListToFile(catalog.ListInsurance);


            // Create the report
            Report report = new Report(catalog);
            report.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm(catalog);
            search.Show();
        }
    }
}
