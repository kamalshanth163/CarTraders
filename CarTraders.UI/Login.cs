using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            user_type.SelectedIndex = 1;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (user_type.Text == "" || user_email.Text == "" || user_password.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User loggedUser = UsersBLL.LoginUser(user_type.Text, user_email.Text, user_password.Text);
                if (loggedUser == null) {
                    MessageBox.Show($"Failed to login user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    UserData.UserId = loggedUser.Id;
                    UserData.Name = loggedUser.Name;
                    UserData.Email = loggedUser.Email;
                    UserData.Type = loggedUser.Type;

                    var email = UserData.Email;

                    switch (loggedUser.Type)
                    {
                        case "Admin":
                            new AdminMenu().ShowDialog();
                            break;
                        case "Customer":
                            new CustomerMenu().ShowDialog();
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
        }
    }
}
