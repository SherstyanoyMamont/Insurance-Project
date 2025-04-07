using System;
using System.Collections.Generic;



namespace Notification
{
    public class NotificationHandler
    {
        private List<Insurance> insurances;

        public NotificationHandler(List<Insurance> insurances)
        {
            this.insurances = insurances;
        }

        public List<string> CheckNotifications()
        {
            DateTime today = DateTime.Today;
            List<string> notifications = new List<string>();

            foreach (var insurance in this.insurances)
            {
                if (insurance.PolicyExpiryDate <= today.AddDays(30)) // 30 days before expiry
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