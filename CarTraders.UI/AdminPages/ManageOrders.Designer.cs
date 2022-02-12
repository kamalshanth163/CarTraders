
namespace CarTraders.UI.AdminPages
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.ordersDataView = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.orderItemsDataView = new System.Windows.Forms.DataGridView();
            this.customer_name = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.setStatusBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewAllBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataView
            // 
            this.ordersDataView.BackgroundColor = System.Drawing.Color.White;
            this.ordersDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataView.Location = new System.Drawing.Point(96, 236);
            this.ordersDataView.Name = "ordersDataView";
            this.ordersDataView.RowTemplate.Height = 60;
            this.ordersDataView.Size = new System.Drawing.Size(357, 240);
            this.ordersDataView.TabIndex = 31;
            this.ordersDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataView_CellContentClick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(110, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 37);
            this.title.TabIndex = 30;
            this.title.Text = "Manage Orders";
            // 
            // orderItemsDataView
            // 
            this.orderItemsDataView.BackgroundColor = System.Drawing.Color.White;
            this.orderItemsDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderItemsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsDataView.Location = new System.Drawing.Point(472, 160);
            this.orderItemsDataView.Name = "orderItemsDataView";
            this.orderItemsDataView.RowTemplate.Height = 60;
            this.orderItemsDataView.Size = new System.Drawing.Size(369, 316);
            this.orderItemsDataView.TabIndex = 34;
            this.orderItemsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderItemsDataView_CellContentClick);
            // 
            // customer_name
            // 
            this.customer_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customer_name.FormattingEnabled = true;
            this.customer_name.ItemHeight = 16;
            this.customer_name.Location = new System.Drawing.Point(95, 156);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(220, 24);
            this.customer_name.TabIndex = 35;
            this.customer_name.SelectedIndexChanged += new System.EventHandler(this.customer_name_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(246, 201);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(69, 29);
            this.deleteBtn.TabIndex = 37;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // setStatusBtn
            // 
            this.setStatusBtn.BackColor = System.Drawing.Color.Black;
            this.setStatusBtn.FlatAppearance.BorderSize = 0;
            this.setStatusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setStatusBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setStatusBtn.ForeColor = System.Drawing.Color.White;
            this.setStatusBtn.Location = new System.Drawing.Point(318, 201);
            this.setStatusBtn.Name = "setStatusBtn";
            this.setStatusBtn.Size = new System.Drawing.Size(135, 29);
            this.setStatusBtn.TabIndex = 36;
            this.setStatusBtn.Text = "Set as Completed";
            this.setStatusBtn.UseVisualStyleBackColor = false;
            this.setStatusBtn.Click += new System.EventHandler(this.setStatusBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(92, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(467, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Order Items";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(92, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Customer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // order_status
            // 
            this.order_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.order_status.FormattingEnabled = true;
            this.order_status.ItemHeight = 16;
            this.order_status.Items.AddRange(new object[] {
            "Pending",
            "Completed"});
            this.order_status.Location = new System.Drawing.Point(329, 156);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(122, 24);
            this.order_status.TabIndex = 41;
            this.order_status.SelectedIndexChanged += new System.EventHandler(this.order_status_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(325, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Order Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.Black;
            this.viewAllBtn.FlatAppearance.BorderSize = 0;
            this.viewAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Location = new System.Drawing.Point(172, 201);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(71, 29);
            this.viewAllBtn.TabIndex = 44;
            this.viewAllBtn.Text = "View all";
            this.viewAllBtn.UseVisualStyleBackColor = false;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Yellow;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportBtn.ForeColor = System.Drawing.Color.Black;
            this.reportBtn.Location = new System.Drawing.Point(588, 123);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(253, 30);
            this.reportBtn.TabIndex = 59;
            this.reportBtn.Text = "Generate Order and Item Reports";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(757, 33);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 62;
            this.menuBtn.Text = "Go to menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(862, 31);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 61;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(935, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.order_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.setStatusBtn);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.orderItemsDataView);
            this.Controls.Add(this.ordersDataView);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ordersDataView;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView orderItemsDataView;
        private System.Windows.Forms.ComboBox customer_name;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button setStatusBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox order_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewAllBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}