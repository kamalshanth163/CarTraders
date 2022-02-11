using CarTraders.BLL;
using System;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cars_count.Text = CarsBLL.GetCars().Count.ToString();
            carParts_count.Text = CarPartsBLL.GetCarParts().Count.ToString();
            customers_count.Text = UsersBLL.GetUsersByType("Customer").Count.ToString();
            orders_count.Text = OrdersBLL.GetOrders().Count.ToString();
        }

        private void manageCarsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageCars().ShowDialog();
        }

        private void manageCarPartsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageCarParts().ShowDialog();
        }

        private void manageCustomersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageCustomers().ShowDialog();
        }

        private void manageOrdersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageOrders().ShowDialog();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMenu().ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
