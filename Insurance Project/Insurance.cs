using Newtonsoft.Json;

namespace Insurance_Project
{
    public class Insurance : BaseEntity
    {
        public string InsuranceCode { get; set; }
        public string ClientName { get; set; }
        public string? ClientPhone { get; set; }
        public string? Coverage { get; private set; }
        public double FinalPrice { get; private set; }
        public string? CarBrand { get; private set; }

        public double BasePrice { get; private set; }
        public int Under24ageCoeficient { get; private set; }
        public Client Client { get; private set; }

        public Insurance(Client client, string? coverage)
        {
            this.InsuranceCode = "1";
            this.BasePrice = 1000;
            this.Under24ageCoeficient = 30; //30%
            this.Client = client;
            this.Coverage = coverage;
            this.FinalPrice = CalculateInsuranceCost(client);
            this.ClientName = client.FirstName + " " + client.LastName;
            this.ClientPhone = client.PhoneNumber;
            this.CarBrand = client.Cars[0].Brand + " " + client.Cars[0].Model;
        }




        //public Insurance() { }

        public double CalculateInsuranceCost(Client client)
        {
            double genderFactor = client.Gender == "M" || client.Gender == "Male" || client.Gender == "m" ? 2 : 0.8;                    // Higher for male drivers
            double ageFactor = client.Age switch
            {
                < 20 => genderFactor * BasePrice * 0.2,
                >= 20 and <= 35 => genderFactor * BasePrice * -0.4,
                _ => genderFactor * BasePrice * -0.65
            };


            // We pull up files with lists of cars and locations
            var locationFactorsJson = File.ReadAllText("LocationFactors.json");
            var locationFactors = JsonConvert.DeserializeObject<Dictionary<string, double>>(locationFactorsJson);

            if (locationFactors.TryGetValue(client.Location, out var locationFactor))
            {
                Console.WriteLine($"Location Factor: {locationFactor}");
            }
            else
            {
                locationFactor = 0; // default
            }


            var brandFactorsJson = File.ReadAllText("CarBrandFactors.json");
            var brandFactors = JsonConvert.DeserializeObject<Dictionary<string, double>>(brandFactorsJson);
            if (brandFactors.TryGetValue(client.Cars[0].Brand, out var brandFactor))
            {
                Console.WriteLine($"Brand Factor: {brandFactor}");
            }
            else
            {
                brandFactor = 80; // default
            }

            var modelFactorsJson = File.ReadAllText("CarModelFactors.json");
            var modelFactors = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, double>>>(modelFactorsJson);

            double carModelFactor;
            if (modelFactors.TryGetValue(client.Cars[0].Brand, out var models) &&
                models.TryGetValue(client.Cars[0].Model, out var specificModelFactor))
            {
                carModelFactor = specificModelFactor;
            }
            else if (brandFactors.TryGetValue(client.Cars[0].Brand, out var fallbackBrandFactor))
            {
                carModelFactor = fallbackBrandFactor; // fallback
            }
            else
            {
                carModelFactor = 80; // fallback if not found anywhere
            }


            double emissionsFactor = 150;                                              // Higher for full coverage
            if (client.Cars[0].Emission == "High") { emissionsFactor = 300; }
            else if (client.Cars[0].Emission == "Low") { emissionsFactor = -55; }
            double coverageFactor = Coverage == "Fully" ? 200 : -120; ;                // Meaning for middle emission

            return FinalPrice = BasePrice * genderFactor + ageFactor + locationFactor + carModelFactor + emissionsFactor + coverageFactor; // Return the final price.
        }
    }
}


//double locationFactor = client.Location switch
//{
//    "Carlow" or "CW" => -50,
//    "Cavan" or "CN" => -30,
//    "Clare" or "CE" => 225,
//    "Cork" or "CO" => 50,
//    "Donegal" or "DL" => 150,
//    "Dublin" or "D" => 300,
//    "Galway" or "G" => 200,
//    "Kerry" or "KY" => 50,
//    "Kildare" or "KE" => 100,
//    "Kilkenny" or "KK" => -20,
//    "Laois" or "LS" => -40,
//    "Leitrim" or "LM" => -25,
//    "Limerick" or "LK" => -75,
//    "Longford" or "LD" => -10,
//    "Louth" or "LH" => 80,
//    "Mayo" or "MO" => 120,
//    "Meath" or "MH" => 90,
//    "Monaghan" or "MN" => -5,
//    "Offaly" or "OY" => -35,
//    "Roscommon" or "RN" => -15,
//    "Sligo" or "SO" => -45,
//    "Tipperary" or "TA" => -80,
//    "Waterford" or "WD" => -100,
//    "Westmeath" or "WH" => -30,
//    "Wexford" or "WX" => -60,
//    "Wicklow" or "WW" => -55,

//    _ => 0 // Default case if location doesn't match
//};

//// Brand-level risk factor (generalized by brand)
//double carBrandFactor = client.Cars[0].Brand switch
//{
//    "BMW" => 250,
//    "Mercedes-Benz" => 240,
//    "Audi" => 230,
//    "Toyota" => 100,
//    "Opel" => 120,
//    "Volkswagen" => 150,
//    "Ford" => 140,
//    "Renault" => 110,
//    "Hyundai" => 100,
//    "Kia" => 90,
//    "Nissan" => 100,
//    "Peugeot" => 95,
//    "Mazda" => 110,
//    "Honda" => 120,
//    "Skoda" => 100,
//    _ => 80 // default for less common brands
//};

//// Model-level risk factor (specific models can adjust the brand factor)
//double carModelFactor = (client.Cars[0].Brand, client.Cars[0].Model) switch
//{
//    ("BMW", "X6") => 300,
//    ("BMW", "Z4") => 175,
//    ("BMW", "3 Series") => 260,
//    ("BMW", "5 Series") => 280,
//    ("BMW", "Convertible") => 200,

//    ("Mercedes-Benz", "E-Class") => 280,
//    ("Mercedes-Benz", "S-Class") => 300,
//    ("Mercedes-Benz", "C-Class") => 250,

//    ("Audi", "A3") => 200,
//    ("Audi", "A4") => 220,
//    ("Audi", "Q7") => 270,
//    ("Audi", "TT") => 250,

//    ("Toyota", "Yaris") => 50,
//    ("Toyota", "Auris") => 50,
//    ("Toyota", "Corolla") => 50,
//    ("Toyota", "Avensis") => 50,
//    ("Toyota", "Land Cruiser") => 180,

//    ("Opel", "Corsa") => 50,
//    ("Opel", "Astra") => 105,
//    ("Opel", "Vectra") => 150,
//    ("Opel", "Insignia") => 140,

//    ("Volkswagen", "Golf") => 120,
//    ("Volkswagen", "Passat") => 140,
//    ("Volkswagen", "Tiguan") => 160,
//    ("Volkswagen", "Polo") => 110,

//    ("Ford", "Focus") => 130,
//    ("Ford", "Fiesta") => 110,
//    ("Ford", "Mondeo") => 140,
//    ("Ford", "Kuga") => 150,

//    ("Renault", "Clio") => 50,
//    ("Renault", "Megane") => 75,
//    ("Renault", "Fluence") => 100,
//    ("Renault", "Kadjar") => 120,

//    ("Hyundai", "i30") => 100,
//    ("Hyundai", "Tucson") => 120,
//    ("Hyundai", "i20") => 90,

//    ("Kia", "Ceed") => 90,
//    ("Kia", "Sportage") => 110,
//    ("Kia", "Rio") => 80,

//    ("Nissan", "Qashqai") => 120,
//    ("Nissan", "Juke") => 100,
//    ("Nissan", "Micra") => 80,

//    ("Peugeot", "208") => 80,
//    ("Peugeot", "308") => 100,
//    ("Peugeot", "3008") => 120,

//    ("Mazda", "3") => 110,
//    ("Mazda", "6") => 130,
//    ("Mazda", "CX-5") => 150,

//    ("Honda", "Civic") => 120,
//    ("Honda", "Accord") => 130,
//    ("Honda", "CR-V") => 140,

//    ("Skoda", "Octavia") => 100,
//    ("Skoda", "Fabia") => 90,
//    ("Skoda", "Superb") => 120,

//    _ => carBrandFactor // fallback: use brand factor if model not specified
//};