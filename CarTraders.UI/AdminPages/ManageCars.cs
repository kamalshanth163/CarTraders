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
        List<Car> carList = new List<Car>();
        int rowIndex;
        string operation;

        public ManageCars()
        {
            InitializeComponent();
            label_id.Visible = false;
            car_id.Visible = false;
        }
        private void ManageCars_Load(object sender, EventArgs e)
        {
            carList = CarsBLL.GetCars();
            carsDataView.DataSource = carList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ManageOperation("Add");
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            ManageOperation("Update");
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ManageOperation("Delete");
        }

        private void ManageOperation(string operation)
        {
            if (car_name.Text == "" || car_brand.Text == "" || car_price.Text == "" || car_description.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Car car = new Car();
                car.Name = car_name.Text;
                car.Brand = car_brand.Text;
                car.Price = car_price.Text;
                car.Description = car_description.Text;

                if (operation == "Add")
                {
                    car.Id = Guid.NewGuid();
                    Car createdObj = CarsBLL.AddCar(car);
                    if (createdObj == null)
                    {
                        MessageBox.Show($"Failed to add car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operation == "Update")
                {
                    car.Id = Guid.Parse(car_id.Text);
                    Car updatedObj = CarsBLL.UpdateCar(car);
                    if (updatedObj == null)
                    {
                        MessageBox.Show($"Failed to update car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operation == "Delete")
                {
                    car.Id = Guid.Parse(car_id.Text);
                    bool isDeleted = CarsBLL.DeleteCar(car);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Failed to delete car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                carList = CarsBLL.GetCars();
                carsDataView.DataSource = carList;
                car_name.Clear();
                car_brand.Clear();
                car_price.Clear();
                car_description.Clear();
                car_name.Focus();
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

        private void carsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow row = carsDataView.Rows[rowIndex];
            car_id.Text = row.Cells[0].Value.ToString();
            car_name.Text = row.Cells[1].Value.ToString();
            car_brand.Text = row.Cells[2].Value.ToString();
            car_price.Text = row.Cells[3].Value.ToString();
            car_description.Text = row.Cells[4].Value.ToString();
        }
    }
}
