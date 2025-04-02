namespace Insurance_Project
{
    public class NotificationService
    {
        private readonly List<Insurance> _insurances;

        public NotificationService(List<Insurance> insurances)
        {
            _insurances = insurances;
        }

        public List<string> CheckNotifications()
        {
            var today = DateTime.Today;
            var notifications = new List<string>();

            foreach (var insurance in _insurances)
            {
                if (insurance.PolicyExpiryDate <= today.AddDays(30))
                {
                    notifications.Add($"Policy {insurance.InsuranceCode} for {insurance.ClientName} is expiring soon on {insurance.PolicyExpiryDate.ToShortDateString()}.");
                }
                if (insurance.Notif && insurance.LastContactDate <= today)
                {
                    notifications.Add($"Follow up with {insurance.ClientName} is due today.");
                }
            }

            return notifications;
        }
    }
}