using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarTraders.UI.CustomerPages
{
    public partial class CarStore : Form
    {
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        List<Car> carList = new List<Car>();
        List<CarPart> carPartList = new List<CarPart>();
        string carSearchTerm;
        string carPartSearchTerm;

        public CarStore()
        {
            InitializeComponent();
        }

        private void CarStore_Load(object sender, EventArgs e)
        {
            carList = CarsBLL.GetCars();
            carPartList = CarPartsBLL.GetCarParts();
            LoadCarsData(carList);
            LoadCarPartsData(carPartList);
        }

        public void LoadCarsData(List<Car> cars)
        {
            cars_listing.Controls.Clear();

            var list = carSearchTerm == "" ? carList : cars;

            foreach (Car car in list)
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

        public void LoadCarPartsData(List<CarPart> carParts)
        {
            carParts_listing.Controls.Clear();

            var list = carPartSearchTerm == "" ? carPartList : carParts;

            foreach (CarPart carPart in list)
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

        private void cars_searchBox_TextChanged(object sender, EventArgs e)
        {
            carSearchTerm = cars_searchBox.Text;
            var filter = carList.FindAll(c => c.Name.ToLower().Contains(cars_searchBox.Text.ToLower()));
            LoadCarsData(filter);
        }

        private void carParts_searchBox_TextChanged(object sender, EventArgs e)
        {
            carPartSearchTerm = carParts_searchBox.Text;
            var filter = carPartList.FindAll(c => c.Name.ToLower().Contains(carParts_searchBox.Text.ToLower()));
            LoadCarPartsData(filter);
        }
    }
}
