﻿using CarTraders.UI.AdminPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_cars_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageCars().ShowDialog();
        }
    }
}
