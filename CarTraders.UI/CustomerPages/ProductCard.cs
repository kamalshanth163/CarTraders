using CarTraders.DAL.Data;
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
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductType { get; set; }

        public ProductCard(ProductCardDto model)
        {
            InitializeComponent();

            var imageFolder = model.ProductType == "Car" ? "Cars" : "CarParts";
            Image = Image.FromFile($"{path}\\Images\\{imageFolder}\\{model.ImageName}");
            ImageName = model.ImageName;
            Id = model.Id;
            Name = model.Name;
            Brand = model.Brand;
            Description = model.Description;
            Price = model.Price;
            ProductType = model.ProductType;
        }
        private void ProductCard_Load(object sender, EventArgs e)
        {
            product_image.Image = Image;
            product_name.Text = Name;
            product_brand.Text = Brand;
            product_price.Text = Price.ToString();
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            ProductViewDto productViewDto = new ProductViewDto();
            productViewDto.ImageName = ImageName;
            productViewDto.Id = Id;
            productViewDto.Name = Name;
            productViewDto.Brand = Brand;
            productViewDto.Description = Description;
            productViewDto.Price = Price;
            productViewDto.ProductType = ProductType;
            productViewDto.UserId = UserData.UserId;

            new ProductView(productViewDto).ShowDialog();
        }
    }
}
