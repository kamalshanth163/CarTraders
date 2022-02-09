using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.Data;
using CarTraders.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CartPage : Form
    {
        List<OrderItemDto> orderItemList = new List<OrderItemDto>();
        decimal totalAmount;

        public CartPage()
        {
            InitializeComponent();
        }

        public void CartPage_Load(object sender, EventArgs e)
        {
            orderItemList = OrdersBLL.GetCartItemsOfUser(UserData.UserId);
            LoadOrderItems(orderItemList);

            totalAmount = orderItemList.Sum(i => i.Price);
            total_price.Text = totalAmount.ToString();
        }

        public void LoadOrderItems(List<OrderItemDto> items)
        {
            cart_list.Controls.Clear();

            for (var i=0; i<items.Count; i++)
            {
                items[i].Index = i+1;
                var cartItem = new CartItem(items[i]);

                cart_list.Controls.Add(cartItem);
            }
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

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Id = Guid.NewGuid();
            order.UserId = UserData.UserId;
            order.Price = totalAmount;
            order.Status = "Pending";

            Order createdObj = OrdersBLL.AddOrder(order);

            if (createdObj == null)
            {
                MessageBox.Show($"Failed to add order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Order added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
            new CarStore().ShowDialog();
        }
    }
}
