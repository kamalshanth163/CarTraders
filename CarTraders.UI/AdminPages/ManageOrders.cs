using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.UI.Reports;
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
        List<OrderItem> orderItemList = new List<OrderItem>();
        User customer = null;
        string orderStatus = null;
        Guid selectedOrderId;
        string orderStatusToUpdate;

        public ManageOrders()
        {
            InitializeComponent();
            ShowActions(false);
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

        private void LoadOrdersData(List<Order> orders)
        {
            ordersDataView.DataSource = orders;
        }

        private void LoadOrderItemsData(List<OrderItem> orderItems)
        {
            orderItemList = orderItems;            
            orderItemsDataView.DataSource = orderItemList;
        }

        private void customer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowActions(false);
            ResetPageData();

            customer = (User)customer_name.SelectedItem;
            filterOrders(customer, orderStatus);
        }

        private void order_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowActions(false);
            ResetPageData();

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

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            ShowActions(false);
            ResetPageData();
            customer_name.SelectedItem = null;
            order_status.SelectedItem = null;
        }

        private void ShowActions(bool display)
        {
            setStatusBtn.Visible = display;
            deleteBtn.Visible = display;
        }

        private void carsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowActions(true);

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

            List<OrderItem> orderItemList = OrdersBLL.GetOrderItemsByOrderId(selectedOrderId);
            LoadOrderItemsData(orderItemList);
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
                ResetPageData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var isDeleted = OrdersBLL.DeleteOrder(selectedOrderId);

            if (!isDeleted)
            {
                MessageBox.Show($"Failed to update order status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Order status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPageData();
            }
        }

        private void ResetPageData()
        {
            orderList = OrdersBLL.GetOrders();
            filterOrders(customer, orderStatus);
            ShowActions(false);

            orderItemList = null;
            LoadOrderItemsData(orderItemList);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var reportModels = new List<ReportModel>();
            reportModels.Add(new ReportModel(ordersDataView, "Orders Report"));
            reportModels.Add(new ReportModel(orderItemsDataView, "Order Items Report"));

            new Report().GenerateMultipleExcels(reportModels);
        }
    }
}
