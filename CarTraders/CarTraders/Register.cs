using Microsoft.Extensions.Configuration;
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
                MessageBox.Show("All the field are required");
            }
            else
            {
                try
                {
                    var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                    var connectionString = appSettings["ConnectionString"];

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    string query = $"INSERT INTO Users (Id, Type, Name, Address, Phone, Email, Password) VALUES ('{Guid.NewGuid()}','{user_type.Text}','{user_name.Text}','{user_address.Text}','{user_phone.Text}','{user_email.Text}','{user_password.Text}')";

                    SqlCommand command = new SqlCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User successfully added");
                    con.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
    }
}
