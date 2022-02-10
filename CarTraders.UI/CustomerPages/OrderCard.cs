using System;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class OrderCard : UserControl
    {
        public OrderCard(int index, DateTime createdAt, decimal price, string status)
        {
            InitializeComponent();
            order_index.Text = index.ToString();
            order_createdAt.Text = createdAt.ToString();
            order_price.Text = price.ToString();
            order_status.Text = status;
        }
    }
}
