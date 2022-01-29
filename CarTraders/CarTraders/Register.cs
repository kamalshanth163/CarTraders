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
                try
                {
                    var connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    string query = $"INSERT INTO Users (Id, Type, Name, Address, Phone, Email, Password) VALUES ('{Guid.NewGuid()}','{user_type.Text}','{user_name.Text}','{user_address.Text}','{user_phone.Text}','{user_email.Text}','{user_password.Text}')";

                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User successfully added");
                    con.Close();

                    if(user_type.Text == "Admin")
                    {
                        new AdminMenu().ShowDialog();
                    }
                    else
                    {
                        new CustomerMenu().ShowDialog();
                    }
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            new Login().ShowDialog();
            this.Hide();
        }
    }
}
