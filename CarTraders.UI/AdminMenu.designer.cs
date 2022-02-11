
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
            this.btn_cars = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_carParts = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btn_orders = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cars
            // 
            this.btn_cars.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_cars.Location = new System.Drawing.Point(198, 155);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(290, 40);
            this.btn_cars.TabIndex = 9;
            this.btn_cars.Text = "Manage Cars";
            this.btn_cars.UseVisualStyleBackColor = true;
            this.btn_cars.Click += new System.EventHandler(this.btn_cars_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_customers.Location = new System.Drawing.Point(198, 244);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(290, 40);
            this.btn_customers.TabIndex = 10;
            this.btn_customers.Text = "Manage Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_carParts
            // 
            this.btn_carParts.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_carParts.Location = new System.Drawing.Point(198, 200);
            this.btn_carParts.Name = "btn_carParts";
            this.btn_carParts.Size = new System.Drawing.Size(290, 40);
            this.btn_carParts.TabIndex = 11;
            this.btn_carParts.Text = "Manage Car Parts";
            this.btn_carParts.UseVisualStyleBackColor = true;
            this.btn_carParts.Click += new System.EventHandler(this.btn_carParts_Click);
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
            this.btn_orders.Location = new System.Drawing.Point(198, 289);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(290, 40);
            this.btn_orders.TabIndex = 16;
            this.btn_orders.Text = "Manage Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(635, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 34;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutBtn.Location = new System.Drawing.Point(524, 14);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(105, 29);
            this.logoutBtn.TabIndex = 37;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn_dashboard.Location = new System.Drawing.Point(198, 111);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(290, 40);
            this.btn_dashboard.TabIndex = 8;
            this.btn_dashboard.Text = "View Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.title);
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
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button btn_carParts;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button btn_dashboard;
    }
}