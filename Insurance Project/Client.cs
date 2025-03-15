namespace Insurance_Project
{
    public class Client : BaseEntity
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateTimeNow { get; private set; }
        public int Age { get; private set; } 
        public string? Gender { get; private set; }
        public string? Location { get; private set; }
        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; }
        public int DriverLicese { get; private set; }
        public int PenaltyPoints { get; private set; }
        public List<Car> Cars { get; private set; }

        public Client(string firstName, string lastName, DateTime dateOfBirth, string? gender, string? location, string? email, string? phoneNumber, int driverLicese, int penaltyPoints, List<Car> cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Location = location;
            Gender = gender;
            Email = email;
            PhoneNumber = phoneNumber;
            DateTimeNow = DateTime.Now;
            DateOfBirth = dateOfBirth;
            DriverLicese = driverLicese;
            PenaltyPoints = penaltyPoints;
            Cars = cars; 
            Age = (int)((DateTimeNow - DateOfBirth).TotalDays / 365.242199); // Calculate Age

        }
    }
}
