using CarTraders.BLL;
using CarTraders.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class ManageCars : Form
    {
        public ManageCars()
        {
            InitializeComponent();
        }
        private void ManageCars_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (car_name.Text == "" || car_brand.Text == "" || car_price.Text == "" || car_description.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Car car = new Car();
                car.Id = Guid.NewGuid();
                car.Name = car_name.Text;
                car.Brand = car_brand.Text;
                car.Price = car_price.Text;
                car.Description = car_description.Text;
                car.CreatedAt = DateTime.Now;

                Car createdObj = CarsBLL.AddCar(car);

                if (createdObj == null)
                {
                    MessageBox.Show($"Failed to add car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    MessageBox.Show($"Car added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    car_name.Focus();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMenu().ShowDialog();
        }
    }
}
