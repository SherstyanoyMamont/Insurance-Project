using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Insurance_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text.Trim();
            string password = textBoxPasswordLogin.Text;

            List<User> users = LoadUsers();

            var user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                              && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Role} {user.Username}!");

                if (user.Role == "Admin")
                {
                    var adminPanel = new MainForm(user); // Передаём пользователя
                    adminPanel.Show();
                }
                else if (user.Role == "Manager")
                {
                    var managerPanel = new MainForm(user);
                    managerPanel.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists("users.json"))
                return new List<User>();

            string json = File.ReadAllText("users.json");
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text.Trim();
            string password = textBoxPasswordLogin.Text;

            List<User> users = LoadUsers();

            var user = users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
                                              && u.Password == password);

            var adminPanel = new MainForm(user); // Передаём пользователя
            adminPanel.Show();
            this.Hide();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm(); // Передаём пользователя

            registrationForm.Show();
            this.Hide();
        }
    }
}
