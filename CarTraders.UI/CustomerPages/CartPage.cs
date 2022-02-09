using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.Data;
using CarTraders.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CartPage : Form
    {
        List<OrderItemDto> orderItemList = new List<OrderItemDto>();
        public CartPage()
        {
            InitializeComponent();
        }

        public void CartPage_Load(object sender, EventArgs e)
        {
            orderItemList = OrdersBLL.GetCartItemsOfUser(UserData.UserId);
            LoadOrderItems(orderItemList);
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
    }
}
