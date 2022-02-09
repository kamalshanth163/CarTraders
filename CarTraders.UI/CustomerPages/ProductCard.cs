using CarTraders.DAL.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class ProductCard : UserControl
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public Image Image { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public string ProductType { get; set; } = "Car";

        public ProductCard(ProductCardDto model)
        {
            InitializeComponent();

            var imageFolder = model.ProductType == "Car" ? "Cars" : "CarParts";
            Image = Image.FromFile($"{path}\\Images\\{imageFolder}\\{model.ImageName}");
            ImageName = model.ImageName;
            Name = model.Name;
            Brand = model.Brand;
            Price = model.Price;
        }
        private void ProductCard_Load(object sender, EventArgs e)
        {
            product_image.Image = Image;
            product_name.Text = Name;
            product_brand.Text = Brand;
            product_price.Text = Price;
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            ProductViewDto productViewDto = new ProductViewDto();
            productViewDto.ImageName = ImageName;
            productViewDto.Name = Name;
            productViewDto.Brand = Brand;
            productViewDto.Description = "DESC";
            productViewDto.Price = Price;
            productViewDto.ProductType = ProductType;

            new ProductView(productViewDto).ShowDialog();
        }
    }
}
