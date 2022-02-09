using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CarStore : Form
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        List<Car> carList = new List<Car>();

        public CarStore()
        {
            InitializeComponent();
        }

        private void CarStore_Load(object sender, EventArgs e)
        {
            carList = CarsBLL.GetCars();
            LoadData();
        }

        public void LoadData()
        {
            products_listing.Controls.Clear();

            foreach(Car car in carList)
            {

                ProductCardDto productCardDto = new ProductCardDto();
                productCardDto.ImageName = car.ImageName;
                productCardDto.Name = car.Name;
                productCardDto.Brand = car.Brand;
                productCardDto.Price = car.Price;
                productCardDto.ProductType = "Car";

                var productCard = new ProductCard(productCardDto);

                products_listing.Controls.Add(productCard);
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerMenu().ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
