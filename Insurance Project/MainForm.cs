using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Insurance_Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Insurance_Project
{
    public partial class MainForm : Form
    {
        public InsuranceCatalog catalog = new InsuranceCatalog();
        private System.Windows.Forms.Timer notificationTimer;
        private NotificationService notificationService;

        private Dictionary<string, Dictionary<string, double>> carModelData;

        public MainForm(User user)
        {
            InitializeComponent();

            // Loading insurances when launching the form
            JSONSaveLoad jsonHandler = new JSONSaveLoad();
            catalog.ListInsurance = jsonHandler.LoadListFromFile();

            
            notificationService = new NotificationService(catalog.ListInsurance);
            notificationTimer = new System.Windows.Forms.Timer();  
            notificationTimer.Interval = 86400000; 
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();
            
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {

            var notifications = notificationService.CheckNotifications();
            foreach (var notification in notifications)
            {
                MessageBox.Show(notification);  // MessageBox is a thread-safe component for displaying alerts
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {

            List<Car> Cars = new();
            Car car = new Car(comboBoxCarBrand.Text, comboBoxCarModel.Text, textBoxColour.Text, (int)numericUpDownCarYear.Value, (int)numericUpDownEngineSize.Value, comboBoxEmission.Text, comboBoxCoverage.Text);
            Cars.Add(car);

            Client client = new(textBoxFirstName.Text, textBoxSurname.Text, dateTimePickerDoB.Value, comboBoxGender.Text, comboBoxLocation.Text, textBoxEmail.Text, maskedTextBoxPhoneNumber.Text, (int)numericUpDownDriverLicense.Value, (int)numericUpDownPenaltyPoints.Value, Cars);

            Insurance insurance = new(client, comboBoxCoverage.Text, (int)numericUpDownPenaltyPoints.Value);

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            // When loading the form, we load brands/models
            LoadCarBrandsAndModels();
        }

        /// <summary>
        /// Load Data from JSON and filling the comboBoxCarBrand.
        /// </summary>
        private void LoadCarBrandsAndModels()
        {
            try
            {
                // Load the list of brands
                string brandJson = File.ReadAllText("CarBrandFactors.json");
                var brandFactors = JsonConvert.DeserializeObject<Dictionary<string, double>>(brandJson);

                // Loading list of models
                string modelJson = File.ReadAllText("CarModelFactors.json");
                carModelData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, double>>>(modelJson);

                comboBoxCarBrand.Items.Clear();
                if (brandFactors != null)
                {
                    foreach (var brand in brandFactors.Keys)
                    {
                        comboBoxCarBrand.Items.Add(brand);
                    }
                }

                // Handler to choose the brand, so that the models change
                comboBoxCarBrand.SelectedIndexChanged += comboBoxCarBrand_SelectedIndexChanged;

                // Сhoose the first brand when starting out
                if (comboBoxCarBrand.Items.Count > 0)
                    comboBoxCarBrand.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных авто: " + ex.Message);
            }
        }

        /// <summary>
        /// When the user changes the brand, we load the corresponding models into comboBoxCarModel
        /// </summary>
        private void comboBoxCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCarModel.Items.Clear();

            if (comboBoxCarBrand.SelectedItem == null)
                return;

            string selectedBrand = comboBoxCarBrand.SelectedItem.ToString();

            // If there is such a brand name in carModelData, we take the list of models
            if (carModelData != null && carModelData.ContainsKey(selectedBrand))
            {
                var models = carModelData[selectedBrand];
                foreach (var modelName in models.Keys)
                {
                    comboBoxCarModel.Items.Add(modelName);
                }
            }
        }
    }
}
