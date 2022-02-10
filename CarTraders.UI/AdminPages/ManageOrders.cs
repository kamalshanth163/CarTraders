using CarTraders.BLL;
using CarTraders.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class ManageOrders : Form
    {
        List<User> customerList = new List<User>();
        List<Order> orderList = new List<Order>();
        User customer = null;
        string orderStatus = null;
        Guid selectedOrderId;
        string orderStatusToUpdate;

        public ManageOrders()
        {
            InitializeComponent();
            setStatusBtn.Visible = false;
            deleteBtn.Visible = false;
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            // Get all customers and list in dropdown
            customerList = UsersBLL.GetUsersByType("Customer");

            customer_name.DataSource = customerList;
            customer_name.DisplayMember = "Name";
            customer_name.ValueMember = "Id";
            customer_name.SelectedIndex = -1;

            // Get all orders
            orderList = OrdersBLL.GetOrders();
            LoadOrdersData(orderList);
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

        private void LoadOrdersData(List<Order> orderList)
        {
            ordersDataView.DataSource = orderList;
        }

        private void customer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer = (User)customer_name.SelectedItem;
            filterOrders(customer, orderStatus);
        }

        private void order_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderStatus = order_status.SelectedItem != null ? order_status.SelectedItem.ToString() : null;
            filterOrders(customer, orderStatus);
        }

        private void filterOrders(User customer, string orderStatus)
        {
            List<Order> orders = new List<Order>();

            if(customer == null && orderStatus == null)
            {
                orders = orderList;
            }
            else if(customer == null)
            {
                orders = orderList.FindAll(o => o.Status == orderStatus);
            }
            else if (orderStatus == null)
            {
                orders = orderList.FindAll(o => o.UserId == customer.Id);
            }
            else
            {
                orders = orderList.FindAll(o => o.UserId == customer.Id && o.Status == orderStatus);
            }

            LoadOrdersData(orders);
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            LoadOrdersData(orderList);
            customer_name.SelectedItem = null;
            order_status.SelectedItem = null;
        }

        private void carsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setStatusBtn.Visible = true;
            deleteBtn.Visible = true;

            DataGridViewRow row = ordersDataView.Rows[e.RowIndex];
            selectedOrderId = Guid.Parse(row.Cells[0].Value.ToString());            

            switch (row.Cells[5].Value.ToString())
            {
                case "Pending":
                    setStatusBtn.Text = "Set as Completed";
                    orderStatusToUpdate = "Completed";
                    break;
                case "Completed":
                    setStatusBtn.Text = "Set as Pending";
                    orderStatusToUpdate = "Pending";
                    break;
                default:
                    break;
            }
        }

        private void setStatusBtn_Click(object sender, EventArgs e)
        {
            var isUpdated = OrdersBLL.UpdateOrderStatus(selectedOrderId, orderStatusToUpdate);

            if(!isUpdated)
            {
                MessageBox.Show($"Failed to update order status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Order status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orderList = OrdersBLL.GetOrders();
                filterOrders(customer, orderStatus);
                setStatusBtn.Visible = false;
                deleteBtn.Visible = false;
            }
        }
    }
}
