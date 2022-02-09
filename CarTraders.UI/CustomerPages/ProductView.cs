using CarTraders.DAL.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class ProductView : Form
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public ProductView(ProductViewDto model)
        {
            InitializeComponent();

            var imageFolder = model.ProductType == "Car" ? "Cars" : "CarParts";
            product_image.Image = Image.FromFile($"{path}\\Images\\{imageFolder}\\{model.ImageName}");
            product_name.Text = model.Name;
            product_brand.Text = model.Brand;
            product_description.Text = model.Description;
            product_price.Text = model.Price;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
