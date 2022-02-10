using CarTraders.BLL;
using CarTraders.DAL.Data;
using CarTraders.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class OrderView : Form
    {
        Guid orderId = OrderData.OrderId;
        List<OrderItemDto> orderItemList = new List<OrderItemDto>();

        public OrderView()
        {
            InitializeComponent();

            orderItemList = OrdersBLL.GetCartItemsByOrderId(OrderData.OrderId);
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadOrderItemsData(orderItemList);
        }

        public void LoadOrderItemsData(List<OrderItemDto> orderItems)
        {
            orderItems_listing.Controls.Clear();

            for (var i = 0; i < orderItems.Count; i++)
            {
                var orderItemCard = new OrderItemCard(
                    orderItems[i].ProductName,
                    orderItems[i].Quantity,
                    orderItems[i].Price
                );

                orderItems_listing.Controls.Add(orderItemCard);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
