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
            user_type.SelectedIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (user_email.Text == "" || user_password.Text == "")
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
                    string query = $"SELECT* FROM Users WHERE Type = '{user_type.Text}' AND Email = '{user_email.Text}' AND Password = '{user_password.Text}'";

                    var command = new SqlCommand(query, con);
                    var dr = command.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        if (user_type.Text == "Admin")
                        {
                            new AdminMenu().ShowDialog();
                        }
                        else
                        {
                            new CustomerMenu().ShowDialog();
                        }
                        this.Hide();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show($"No {user_type} Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
            this.Hide();
        }
    }
}
