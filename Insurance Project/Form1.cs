namespace Insurance_Project
{
    public partial class Form1 : Form
    {
        public int totalCost;
        public int normalCost = 1000;
        public int under24ageCoeficient = 30; // 30%
        public int under20ageCoeficient = 30; // 30%


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void CalculateTotalCost()
        {
            totalCost = normalCost * under24ageCoeficient;
        }
    }

    public abstract class BaseEntity
    {
        public int id;
    }

    public class Insurance : BaseEntity
    {
        public int totalCost { get; private set; }
        public int normalCost { get; private set; }
        public int under24ageCoeficient { get; private set; }
        public Client client { get; private set; }

    }

    public class Client : BaseEntity
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }
        public int driverLicese { get; private set; }
        public int penaltyPoints { get; private set; }
        public List<Car> cars { get; private set; }

    }

    public class Car : BaseEntity
    {
        public string brand { get; private set; }
        public string model { get; private set; }
        public int year { get; private set; }
        public double engineSize { get; private set; }
        public string colour { get; private set; }
    }

}
