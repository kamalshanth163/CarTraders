
namespace CarTraders.UI.AdminPages
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.title = new System.Windows.Forms.Label();
            this.manageCarsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cars_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manageCarPartsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carParts_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customers_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manageCustomersBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.orders_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.manageOrdersBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.title.Location = new System.Drawing.Point(117, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(216, 54);
            this.title.TabIndex = 2;
            this.title.Text = "Dashboard";
            // 
            // manageCarsBtn
            // 
            this.manageCarsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.manageCarsBtn.FlatAppearance.BorderSize = 0;
            this.manageCarsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCarsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.manageCarsBtn.Location = new System.Drawing.Point(13, 172);
            this.manageCarsBtn.Name = "manageCarsBtn";
            this.manageCarsBtn.Size = new System.Drawing.Size(163, 44);
            this.manageCarsBtn.TabIndex = 3;
            this.manageCarsBtn.Text = "Manage";
            this.manageCarsBtn.UseVisualStyleBackColor = false;
            this.manageCarsBtn.Click += new System.EventHandler(this.manageCarsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.cars_count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.manageCarsBtn);
            this.panel1.Location = new System.Drawing.Point(92, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 228);
            this.panel1.TabIndex = 4;
            // 
            // cars_count
            // 
            this.cars_count.AutoSize = true;
            this.cars_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.cars_count.ForeColor = System.Drawing.Color.Gold;
            this.cars_count.Location = new System.Drawing.Point(62, 42);
            this.cars_count.Name = "cars_count";
            this.cars_count.Size = new System.Drawing.Size(64, 46);
            this.cars_count.TabIndex = 5;
            this.cars_count.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cars";
            // 
            // manageCarPartsBtn
            // 
            this.manageCarPartsBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.manageCarPartsBtn.FlatAppearance.BorderSize = 0;
            this.manageCarPartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCarPartsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.manageCarPartsBtn.Location = new System.Drawing.Point(13, 172);
            this.manageCarPartsBtn.Name = "manageCarPartsBtn";
            this.manageCarPartsBtn.Size = new System.Drawing.Size(163, 44);
            this.manageCarPartsBtn.TabIndex = 3;
            this.manageCarPartsBtn.Text = "Manage";
            this.manageCarPartsBtn.UseVisualStyleBackColor = false;
            this.manageCarPartsBtn.Click += new System.EventHandler(this.manageCarPartsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.carParts_count);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.manageCarPartsBtn);
            this.panel2.Location = new System.Drawing.Point(288, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 228);
            this.panel2.TabIndex = 5;
            // 
            // carParts_count
            // 
            this.carParts_count.AutoSize = true;
            this.carParts_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.carParts_count.ForeColor = System.Drawing.Color.Gold;
            this.carParts_count.Location = new System.Drawing.Point(67, 42);
            this.carParts_count.Name = "carParts_count";
            this.carParts_count.Size = new System.Drawing.Size(64, 46);
            this.carParts_count.TabIndex = 7;
            this.carParts_count.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car Parts";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.customers_count);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.manageCustomersBtn);
            this.panel3.Location = new System.Drawing.Point(484, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 228);
            this.panel3.TabIndex = 6;
            // 
            // customers_count
            // 
            this.customers_count.AutoSize = true;
            this.customers_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.customers_count.ForeColor = System.Drawing.Color.Gold;
            this.customers_count.Location = new System.Drawing.Point(69, 42);
            this.customers_count.Name = "customers_count";
            this.customers_count.Size = new System.Drawing.Size(64, 46);
            this.customers_count.TabIndex = 6;
            this.customers_count.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customers";
            // 
            // manageCustomersBtn
            // 
            this.manageCustomersBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.manageCustomersBtn.FlatAppearance.BorderSize = 0;
            this.manageCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageCustomersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.manageCustomersBtn.Location = new System.Drawing.Point(13, 172);
            this.manageCustomersBtn.Name = "manageCustomersBtn";
            this.manageCustomersBtn.Size = new System.Drawing.Size(163, 44);
            this.manageCustomersBtn.TabIndex = 3;
            this.manageCustomersBtn.Text = "Manage";
            this.manageCustomersBtn.UseVisualStyleBackColor = false;
            this.manageCustomersBtn.Click += new System.EventHandler(this.manageCustomersBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.orders_count);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.manageOrdersBtn);
            this.panel4.Location = new System.Drawing.Point(680, 178);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 228);
            this.panel4.TabIndex = 7;
            // 
            // orders_count
            // 
            this.orders_count.AutoSize = true;
            this.orders_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.orders_count.ForeColor = System.Drawing.Color.Gold;
            this.orders_count.Location = new System.Drawing.Point(68, 42);
            this.orders_count.Name = "orders_count";
            this.orders_count.Size = new System.Drawing.Size(64, 46);
            this.orders_count.TabIndex = 8;
            this.orders_count.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Orders";
            // 
            // manageOrdersBtn
            // 
            this.manageOrdersBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.manageOrdersBtn.FlatAppearance.BorderSize = 0;
            this.manageOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageOrdersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.manageOrdersBtn.Location = new System.Drawing.Point(13, 172);
            this.manageOrdersBtn.Name = "manageOrdersBtn";
            this.manageOrdersBtn.Size = new System.Drawing.Size(163, 44);
            this.manageOrdersBtn.TabIndex = 3;
            this.manageOrdersBtn.Text = "Manage";
            this.manageOrdersBtn.UseVisualStyleBackColor = false;
            this.manageOrdersBtn.Click += new System.EventHandler(this.manageOrdersBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(872, 34);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 53;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(767, 36);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 54;
            this.menuBtn.Text = "Go to menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(945, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button manageCarsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button manageCarPartsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button manageCustomersBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button manageOrdersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cars_count;
        private System.Windows.Forms.Label carParts_count;
        private System.Windows.Forms.Label customers_count;
        private System.Windows.Forms.Label orders_count;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}