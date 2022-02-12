using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            user_type.SelectedIndex = 1;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            if (user_type.Text == "" || user_name.Text == "" || user_address.Text == "" || user_phone.Text == "" || user_email.Text == "" || user_password.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User user = new User();
                user.Id = Guid.NewGuid();
                user.Type = user_type.Text;
                user.Name = user_name.Text;
                user.Address = user_address.Text;
                user.Phone = user_phone.Text;
                user.Email = user_email.Text;
                user.Password = user_password.Text;

                User createdObj = UsersBLL.AddUser(user);

                if (createdObj == null)
                {
                    MessageBox.Show($"Failed to create user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    UserData.UserId = createdObj.Id;
                    UserData.Name = createdObj.Name;
                    UserData.Email = createdObj.Email;
                    UserData.Type = createdObj.Type;

                    switch (createdObj.Type)
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

                    UserData.UserId = user.Id;
                    UserData.Name = user.Name;
                    UserData.Email = user.Email;
                    UserData.Type = user.Type;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            user_type.SelectedIndex = 1;
            user_name.Text = "";
            user_address.Text = "";
            user_phone.Text = "";
            user_email.Text = "";
            user_password.Text = "";
        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }
    }
}
