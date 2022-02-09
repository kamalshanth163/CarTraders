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
        List<CarPart> carPartList = new List<CarPart>();

        public CarStore()
        {
            InitializeComponent();
        }

        private void CarStore_Load(object sender, EventArgs e)
        {
            carList = CarsBLL.GetCars();
            carPartList = CarPartsBLL.GetCarParts();
            LoadCarsData();
            LoadCarPartsData();
        }

        public void LoadCarsData()
        {
            cars_listing.Controls.Clear();

            foreach(Car car in carList)
            {
                ProductCardDto productCardDto = new ProductCardDto();
                productCardDto.ImageName = car.ImageName;
                productCardDto.Id = car.Id;
                productCardDto.Name = car.Name;
                productCardDto.Brand = car.Brand;
                productCardDto.Description = car.Description;
                productCardDto.Price = car.Price.ToString();
                productCardDto.ProductType = "Car";

                var productCard = new ProductCard(productCardDto);

                cars_listing.Controls.Add(productCard);
            }
        }

        public void LoadCarPartsData()
        {
            carParts_listing.Controls.Clear();

            foreach (CarPart carPart in carPartList)
            {
                ProductCardDto productCardDto = new ProductCardDto();
                productCardDto.ImageName = carPart.ImageName;
                productCardDto.Id = carPart.Id;
                productCardDto.Name = carPart.Name;
                productCardDto.Brand = carPart.Brand;
                productCardDto.Description = carPart.Description;
                productCardDto.Price = carPart.Price.ToString();
                productCardDto.ProductType = "CarPart";

                var productCard = new ProductCard(productCardDto);

                carParts_listing.Controls.Add(productCard);
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
