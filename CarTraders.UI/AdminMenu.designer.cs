
namespace CarTraders
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_carParts = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btn_orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_dashboard.Location = new System.Drawing.Point(249, 93);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(187, 40);
            this.btn_dashboard.TabIndex = 8;
            this.btn_dashboard.Text = "View Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_cars
            // 
            this.btn_cars.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_cars.Location = new System.Drawing.Point(259, 137);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(165, 40);
            this.btn_cars.TabIndex = 9;
            this.btn_cars.Text = "Manage Cars";
            this.btn_cars.UseVisualStyleBackColor = true;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_customers.Location = new System.Drawing.Point(198, 226);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(290, 40);
            this.btn_customers.TabIndex = 10;
            this.btn_customers.Text = "Manage Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            // 
            // btn_carParts
            // 
            this.btn_carParts.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_carParts.Location = new System.Drawing.Point(229, 182);
            this.btn_carParts.Name = "btn_carParts";
            this.btn_carParts.Size = new System.Drawing.Size(224, 40);
            this.btn_carParts.TabIndex = 11;
            this.btn_carParts.Text = "Manage Car Parts";
            this.btn_carParts.UseVisualStyleBackColor = true;
            this.btn_carParts.Click += new System.EventHandler(this.btn_carParts_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_reports.Location = new System.Drawing.Point(247, 315);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(189, 40);
            this.btn_reports.TabIndex = 13;
            this.btn_reports.Text = "Generate Reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.title.Location = new System.Drawing.Point(220, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(254, 54);
            this.title.TabIndex = 15;
            this.title.Text = "Admin Menu";
            // 
            // btn_orders
            // 
            this.btn_orders.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_orders.Location = new System.Drawing.Point(198, 271);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(290, 40);
            this.btn_orders.TabIndex = 16;
            this.btn_orders.Text = "Manage Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_carParts);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_cars);
            this.Controls.Add(this.btn_dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_carParts;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_orders;
    }
}