﻿using System;
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
                
               
            }
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
        }
    }
}
