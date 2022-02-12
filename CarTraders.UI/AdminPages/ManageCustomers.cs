using CarTraders.BLL;
using CarTraders.DAL;
using CarTraders.UI.Reports;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarTraders.UI.AdminPages
{
    public partial class ManageCustomers : Form
    {
        List<User> customerList = new List<User>();
        int rowIndex;

        public ManageCustomers()
        {
            InitializeComponent();
            label_id.Visible = false;
            customer_id.Visible = false;
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            customerList = UsersBLL.GetUsersByType("Customer");
            customersDataView.DataSource = customerList;
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

        private void customersDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            DataGridViewRow row = customersDataView.Rows[rowIndex];
            customer_id.Text = row.Cells[0].Value.ToString();
            customer_name.Text = row.Cells[2].Value.ToString();
            customer_address.Text = row.Cells[3].Value.ToString();
            customer_phone.Text = row.Cells[4].Value.ToString();
            customer_email.Text = row.Cells[5].Value.ToString();
            customer_password.Text = row.Cells[6].Value.ToString();
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
            if (customer_name.Text == "" || customer_address.Text == "" || customer_phone.Text == "" || customer_email.Text == "" || customer_password.Text == "")
            {
                MessageBox.Show($"All fields are required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var newGuid = Guid.NewGuid();

                User customer = new User();
                customer.Id = customer_id.Text == "" || customer_id.Text == null ? newGuid : Guid.Parse(customer_id.Text);
                customer.Name = customer_name.Text;
                customer.Address = customer_address.Text;
                customer.Phone = customer_phone.Text;
                customer.Email = customer_email.Text;
                customer.Password = customer_password.Text;
                
                if (operation == "Update")
                {
                    User updatedObj = UsersBLL.UpdateUser(customer);
                    if (updatedObj == null)
                    {
                        MessageBox.Show($"Failed to update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (operation == "Delete")
                {
                    bool isDeleted = UsersBLL.DeleteUser(customer);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Failed to delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                customerList = UsersBLL.GetUsersByType("Customer");
                customersDataView.DataSource = customerList;
                customer_id.Text = null;
                customer_name.Clear();
                customer_address.Clear();
                customer_phone.Clear();
                customer_email.Clear();
                customer_password.Clear();
                customer_name.Focus();
            }
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var reportModel = new ReportModel(customersDataView, "Customers Report");
            new Report().GenerateExcel(reportModel);
        }
    }
}
