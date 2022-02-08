using CarTraders.BLL;
using CarTraders.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class ManageCarParts : Form
    {
        List<CarPart> carPartList = new List<CarPart>();
        int rowIndex;
        string uploadFilePath;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        string currentImageName;

        public ManageCarParts()
        {
            InitializeComponent();
            label_id.Visible = false;
            carPart_id.Visible = false;
            carPart_image.Image = null;
        }
        private void ManageCarParts_Load(object sender, EventArgs e)
        {
            carPartList = CarPartsBLL.GetCarParts();
            carPartsDataView.DataSource = carPartList;
            carPartsDataView.Columns[7].Visible = false;
            carPartsDataView.Columns[8].Visible = false;
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
            if (carPart_name.Text == "" || carPart_brand.Text == "" || carPart_price.Text == "" || carPart_description.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var newGuid = Guid.NewGuid();

                CarPart carPart = new CarPart();
                carPart.Id = carPart_id.Text == "" ? newGuid : Guid.Parse(carPart_id.Text);
                carPart.Name = carPart_name.Text;
                carPart.Brand = carPart_brand.Text;
                carPart.Price = carPart_price.Text;
                carPart.Description = carPart_description.Text;

                // Add ImageName on different scenarios
                if (uploadFilePath == null)
                {
                    if(carPart_image.Image == null)
                    {
                        carPart.Image = ConvertImageToBytes(Image.FromFile($"{path}\\Images\\CarParts\\empty.jpg"));
                        carPart.ImageName = "empty.jpg";
                    }
                    else
                    {
                        carPart.Image = ConvertImageToBytes(carPart_image.Image);
                        carPart.ImageName = currentImageName;
                    }
                }
                else
                {
                    carPart.Image = ConvertImageToBytes(carPart_image.Image);
                    carPart.ImageName = SaveImage(carPart_id.Text == "" ? newGuid.ToString() : carPart_id.Text);
                }

                if (operation == "Add")
                {
                    CarPart createdObj = CarPartsBLL.AddCarPart(carPart);
                    if (createdObj == null)
                    {
                        MessageBox.Show($"Failed to add car part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car Part added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operation == "Update")
                {
                    CarPart updatedObj = CarPartsBLL.UpdateCarPart(carPart);
                    if (updatedObj == null)
                    {
                        MessageBox.Show($"Failed to update car part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car Part updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operation == "Delete")
                {
                    bool isDeleted = CarPartsBLL.DeleteCarPart(carPart);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Failed to delete car part", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Car Part deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                carPartList = CarPartsBLL.GetCarParts();
                carPartsDataView.DataSource = carPartList;
                carPart_name.Clear();
                carPart_brand.Clear();
                carPart_price.Clear();
                carPart_description.Clear();
                carPart_image.Image = null;
                carPart_name.Focus();
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

        private void carPartsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow row = carPartsDataView.Rows[rowIndex];
            carPart_id.Text = row.Cells[0].Value.ToString();
            carPart_name.Text = row.Cells[1].Value.ToString();
            carPart_brand.Text = row.Cells[2].Value.ToString();
            carPart_price.Text = row.Cells[3].Value.ToString();
            carPart_description.Text = row.Cells[4].Value.ToString();

            carPart_image.Image = Image.FromFile($"{path}\\Images\\CarParts\\{row.Cells[8].Value ?? "empty.jpg"}");

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
                    carPart_image.Image = Image.FromFile(dialog.FileName);
                    uploadFilePath = dialog.FileName;
                }
            }
        }

        private string SaveImage(string uniqueName)
        {
            string fileName = $"{uniqueName}_{DateTime.Now.ToString("yyyy_MM_dd_mm_ss")}{Path.GetExtension(uploadFilePath)}";
            File.Copy(uploadFilePath, $"{path}\\Images\\CarParts\\{fileName}");
            return fileName;
        }

        private void imageRemoveBtn_Click(object sender, EventArgs e)
        {
            carPart_image.Image = Image.FromFile($"{path}\\Images\\CarParts\\empty.jpg");
            currentImageName = "empty.jpg";
        }
    }
}
