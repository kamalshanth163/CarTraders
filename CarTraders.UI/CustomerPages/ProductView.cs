using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class ProductView : Form
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        Guid userId;
        Guid productId;
        string productType;

        public ProductView(ProductViewDto model)
        {
            InitializeComponent();

            var imageFolder = model.ProductType == "Car" ? "Cars" : "CarParts";
            product_image.Image = Image.FromFile($"{path}\\Images\\{imageFolder}\\{model.ImageName}");
            product_name.Text = model.Name;
            product_brand.Text = model.Brand;
            product_description.Text = model.Description;
            product_price.Text = model.Price;

            productId = model.Id;
            userId = model.UserId;
            productType = model.ProductType;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            var totalPricePerItem = double.Parse(product_price.Text) * (double)product_quantity.Value;

            OrderItem orderItem = new OrderItem();
            orderItem.Id = Guid.NewGuid();
            orderItem.OrderId = null;
            orderItem.UserId = userId;
            orderItem.ProductId = productId;
            orderItem.ProductType = productType;
            orderItem.Price = totalPricePerItem;
            orderItem.Quantity = (int)product_quantity.Value;

            OrderItem createdObj = OrdersBLL.AddOrderItem(orderItem);

            if (createdObj == null)
            {
                MessageBox.Show($"Failed to add order item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Order Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
