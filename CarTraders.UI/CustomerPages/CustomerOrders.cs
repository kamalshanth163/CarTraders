using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CustomerOrders : Form
    {
        List<Order> orderList = new List<Order>();
        string ordersFilterBy;

        public CustomerOrders()
        {
            InitializeComponent();
            orderList = OrdersBLL.GetOrdersByUserId(UserData.UserId);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerMenu().ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            LoadOrdersData(orderList);
        }

        public void LoadOrdersData(List<Order> orders)
        {
            orders_listing.Controls.Clear();

            for (var i=0; i<orders.Count; i++)
            {
                var orderCard = new OrderCard(
                    i+1,
                    orders[i].CreatedAt,
                    orders[i].Price,
                    orders[i].Status,
                    orders[i].Id
                );

                orders_listing.Controls.Add(orderCard);
            }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            ordersFilterBy = "All";
            LoadOrdersData(orderList);
        }

        private void pendingBtn_Click(object sender, EventArgs e)
        {
            ordersFilterBy = "Pending";
            FilterOrders(ordersFilterBy);
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            ordersFilterBy = "Completed";
            FilterOrders(ordersFilterBy);
        }

        private void FilterOrders(string status)
        {
            var filter = orderList.FindAll(x => x.Status == status);
            LoadOrdersData(filter);
        }
    }
}
