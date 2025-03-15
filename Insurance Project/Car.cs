namespace Insurance_Project
{
    public class Car : BaseEntity
    {
        public string? Brand { get; private set; }
        public string? Model { get; private set; }
        public string? Colour { get; private set; }
        public int Year { get; private set; }
        public double EngineSize { get; private set; }
        public string Emission { get; private set; }
        public string Coverage { get; private set; }

        public Car(string brand, string model, string colour, int year, double engineSize, string emission, string coverage)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            Year = year;
            EngineSize = engineSize;
            Emission = emission;
            Coverage = coverage;
        }
    }
}
