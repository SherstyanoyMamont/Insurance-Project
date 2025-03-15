namespace Insurance_Project
{
    public class InsuranceCatalog : BaseEntity
    {
        public List<Insurance> ListInsurance { get; set; } = new();

        public void AddInsurance(Insurance insurance)
        {
            ListInsurance.Add(insurance);
        }

        public void ShowAllInsurances()
        {
            foreach (var insurance in ListInsurance)
            {
                Console.WriteLine(insurance);
            }
        }
    }
}
