using System.Collections.Generic;
using System.Windows.Forms;

namespace Insurance_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePickerDoB.Value;
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            List<Car> Cars = new();

            Car car = new Car(comboBoxCarBrand.Text, comboBoxCarModel.Text, textBoxColour.Text, (int)numericUpDownCarYear.Value, (int)numericUpDownEngineSize.Value);

            Cars.Add(car);

            Client client = new(textBoxFirstName.Text, textBoxSurname.Text, age, (int)numericUpDownDriverLicense.Value, (int)numericUpDownPenaltyPoints.Value, Cars);
            
            Insurance insurance = new(client);
            
            
        }

    }

    public abstract class BaseEntity
    {
        public int id;
    }

    public class Insurance : BaseEntity
    {
        

        public int TotalCost { get; private set; }
        public int NormalCost { get; private set; }
        public int Under24ageCoeficient { get; private set; }
        public Client Client { get; private set; }
        public Insurance(Client client)
        {
            this.NormalCost = 1000;
            this.Under24ageCoeficient = 30; //30%
            this.Client = client;
        }

        private void CalculateTotalCost()
        {
            TotalCost = NormalCost * Under24ageCoeficient;
        }

    }

    public class Client : BaseEntity
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public int Age { get; private set; }
        public int DriverLicese { get; private set; }
        public int PenaltyPoints { get; private set; }
        public List<Car> Cars { get; private set; }

        public Client(string firstName, string lastName, int age, int driverLicese, int penaltyPoints, List<Car> cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DriverLicese = driverLicese;
            PenaltyPoints = penaltyPoints;
            Cars = cars;

        }
    }

    public class Car : BaseEntity
    {
        

        public string? Brand { get; private set; }
        public string? Model { get; private set; }
        public string? Colour { get; private set; }
        public int Year { get; private set; }
        public double EngineSize { get; private set; }

        public Car(string brand, string model, string colour, int year, double engineSize)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            Year = year;
            EngineSize = engineSize;
        }

    }
}
