using CarTraders.BLL;
using CarTraders.DAL.Data;
using CarTraders.DAL.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CartItem : UserControl
    {
        public int Index { get; set; }
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public CartItem(OrderItemDto model)
        {
            InitializeComponent();

            Index = model.Index;
            Id = model.Id;
            ProductId = model.ProductId;
            ProductName = model.ProductName;
            ProductType = model.ProductType;
            Quantity = model.Quantity;
            Price = model.Price;
        }

        private void CartItem_Load(object sender, EventArgs e)
        {
            product_index.Text = Index.ToString();
            product_name.Text = ProductName;
            product_price.Text = Price.ToString();
            product_type.Text = ProductType;
            product_quantity.Text = Quantity.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isDeleted = OrdersBLL.DeleteOrderItem(Id);
            if (!isDeleted)
            {
                MessageBox.Show($"Failed to delete item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Item deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var f in Application.OpenForms.OfType<CartPage>().ToList())
                {
                    f.Hide();
                }
                new CartPage().ShowDialog();
            }
        }
    }
}
