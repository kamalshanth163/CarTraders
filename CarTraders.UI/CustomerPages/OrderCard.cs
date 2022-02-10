using CarTraders.DAL.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class OrderCard : UserControl
    {
        public Guid OrderId { get; set; }

        public OrderCard(int index, DateTime createdAt, decimal price, string status, Guid orderId)
        {
            InitializeComponent();
            order_index.Text = index.ToString();
            order_createdAt.Text = createdAt.ToString();
            order_price.Text = price.ToString();
            order_status.Text = status;

            OrderId = orderId;
        }

        private void OnClick(object sender, EventArgs e)
        {
            OrderData.OrderId = OrderId;
            new OrderView().ShowDialog();
        }
    }
}
