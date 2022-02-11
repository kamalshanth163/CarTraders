using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.UI.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class ManageCars : Form
    {
        List<Car> carList = new List<Car>();
        int rowIndex;
        string uploadFilePath;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        string currentImageName;

        public ManageCars()
        {
            InitializeComponent();
            label_id.Visible = false;
            car_id.Visible = false;
            car_price.Value = 0;
            car_price.Maximum = decimal.MaxValue;
            car_image.Image = null;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

        }
        private void ManageCars_Load(object sender, EventArgs e)
        {
            carList = CarsBLL.GetCars();
            carsDataView.DataSource = carList;

            carsDataView.Columns[7].Visible = false;
            carsDataView.Columns[8].Visible = false;
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
                var newGuid = Guid.NewGuid();

                Car car = new Car();
                car.Id = car_id.Text == "" || car_id.Text == null || car_id.Text == null ? newGuid : Guid.Parse(car_id.Text);
                car.Name = car_name.Text;
                car.Brand = car_brand.Text;
                car.Price = decimal.Parse(car_price.Text);
                car.Description = car_description.Text;

                // Add ImageName on different scenarios
                if (uploadFilePath == null)
                {
                    if (car_image.Image == null)
                    {
                        car.Image = ConvertImageToBytes(Image.FromFile($"{path}\\Images\\Cars\\empty.jpg"));
                        car.ImageName = "empty.jpg";
                    }
                    else
                    {
                        car.Image = ConvertImageToBytes(car_image.Image);
                        car.ImageName = currentImageName;
                    }
                }
                else
                {
                    car.Image = ConvertImageToBytes(car_image.Image);
                    car.ImageName = SaveImage(car_id.Text == "" || car_id.Text == null ? newGuid.ToString() : car_id.Text);
                }

                if (operation == "Add")
                {
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
                car_price.Value = 0;
                car_description.Clear();
                car_image.Image = null;
                car_name.Focus();
                uploadFilePath = null;
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
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;

            rowIndex = e.RowIndex;
            DataGridViewRow row = carsDataView.Rows[rowIndex];
            car_id.Text = row.Cells[0].Value.ToString();
            car_name.Text = row.Cells[1].Value.ToString();
            car_brand.Text = row.Cells[2].Value.ToString();
            car_price.Value = decimal.Parse(row.Cells[3].Value.ToString());
            car_description.Text = row.Cells[4].Value.ToString();

            car_image.Image = Image.FromFile($"{path}\\Images\\Cars\\{row.Cells[8].Value ?? "empty.jpg"}");

            currentImageName = row.Cells[8].Value.ToString();
        }

        private byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ConvertBytesToImage(byte[] image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

        private void imageUploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*", Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    car_image.Image = Image.FromFile(dialog.FileName);
                    uploadFilePath = dialog.FileName;
                }
            }
        }

        private string SaveImage(string uniqueName)
        {
            string fileName = $"{uniqueName}_{DateTime.Now.ToString("yyyy_MM_dd_mm_ss")}{Path.GetExtension(uploadFilePath)}";
            File.Copy(uploadFilePath, $"{path}\\Images\\Cars\\{fileName}");
            return fileName;
        }

        private void imageRemoveBtn_Click(object sender, EventArgs e)
        {
            car_image.Image = Image.FromFile($"{path}\\Images\\Cars\\empty.jpg");
            currentImageName = "empty.jpg";
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var reportModel = new ReportModel(carsDataView, "Cars Report");
            new Report().GenerateExcel(reportModel);
        }
    }
}
