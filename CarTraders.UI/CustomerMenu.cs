using CarTraders.DAL.Data;
using CarTraders.UI.CustomerPages;
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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }            

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CarStore().ShowDialog();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerOrders().ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserData.UserId = Guid.Empty;
            this.Hide();
            new Home().ShowDialog();
        }
    }
}
