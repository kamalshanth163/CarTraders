using CarTraders.BLL;
using CarTraders.DAL;
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
            user_type.SelectedIndex = 0;
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
                user.CreatedAt = DateTime.Now;

                User createdUser = UsersBLL.AddUser(user);

                if (createdUser == null)
                {
                    MessageBox.Show($"Failed to create user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    switch (createdUser.Type)
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            user_type.SelectedIndex = 0;
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
    }
}
