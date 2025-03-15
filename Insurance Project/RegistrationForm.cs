using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_Project
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameReg.Text.Trim();
            string password = textBoxPasswordReg.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var users = LoadUsers();

            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This username already exists.");
                return;
            }

            users.Add(new User { Username = username, Password = password, Role = role });
            SaveUsers(users);

            MessageBox.Show($"User {username} added as {role}.");

            RefreshUserList();
        }

        private void RefreshUserList()
        {
            //listBoxUsers.Items.Clear();

            var users = LoadUsers();

            foreach (var user in users)
            {
                //listBoxUsers.Items.Add($"{user.Username} ({user.Role})");
            }
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists("users.json"))
                return new List<User>();

            string json = File.ReadAllText("users.json");
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("users.json", json);
        }
    }
}
