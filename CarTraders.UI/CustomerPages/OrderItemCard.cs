using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class OrderItemCard : UserControl
    {
        public OrderItemCard(string productName, int quantity, decimal price)
        {
            InitializeComponent();

            item_name.Text = productName;
            item_quantity.Text = quantity.ToString();
            item_price.Text = price.ToString();
        }
    }
}
