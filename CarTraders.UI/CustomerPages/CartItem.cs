using CarTraders.DAL.DTO;
using System;
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
            product_quantity.Value = Quantity;
        }
    }
}
