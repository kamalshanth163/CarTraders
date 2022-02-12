
namespace CarTraders.UI.AdminPages
{
    partial class ManageCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCars));
            this.car_name = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.car_brand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.car_description = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.carsDataView = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.car_id = new System.Windows.Forms.TextBox();
            this.car_image = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageUploadBtn = new System.Windows.Forms.Button();
            this.imageRemoveBtn = new System.Windows.Forms.Button();
            this.car_price = new System.Windows.Forms.NumericUpDown();
            this.reportBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // car_name
            // 
            this.car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.car_name.Location = new System.Drawing.Point(95, 154);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(227, 23);
            this.car_name.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(109, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 37);
            this.title.TabIndex = 15;
            this.title.Text = "Manage Cars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(91, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(91, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand";
            // 
            // car_brand
            // 
            this.car_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.car_brand.Location = new System.Drawing.Point(95, 199);
            this.car_brand.Name = "car_brand";
            this.car_brand.Size = new System.Drawing.Size(227, 23);
            this.car_brand.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(91, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(91, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price (LKR)";
            // 
            // car_description
            // 
            this.car_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.car_description.Location = new System.Drawing.Point(95, 289);
            this.car_description.Name = "car_description";
            this.car_description.Size = new System.Drawing.Size(227, 41);
            this.car_description.TabIndex = 4;
            this.car_description.Text = "";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(98, 456);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(61, 29);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // carsDataView
            // 
            this.carsDataView.BackgroundColor = System.Drawing.Color.White;
            this.carsDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataView.Location = new System.Drawing.Point(359, 147);
            this.carsDataView.Name = "carsDataView";
            this.carsDataView.RowTemplate.Height = 60;
            this.carsDataView.Size = new System.Drawing.Size(486, 338);
            this.carsDataView.TabIndex = 27;
            this.carsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataView_CellContentClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_id.Location = new System.Drawing.Point(92, 91);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 19);
            this.label_id.TabIndex = 31;
            this.label_id.Text = "Id";
            // 
            // car_id
            // 
            this.car_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.car_id.Location = new System.Drawing.Point(96, 111);
            this.car_id.Name = "car_id";
            this.car_id.Size = new System.Drawing.Size(227, 23);
            this.car_id.TabIndex = 30;
            // 
            // car_image
            // 
            this.car_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.car_image.Location = new System.Drawing.Point(97, 357);
            this.car_image.Name = "car_image";
            this.car_image.Size = new System.Drawing.Size(150, 83);
            this.car_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_image.TabIndex = 32;
            this.car_image.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(92, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Image";
            // 
            // imageUploadBtn
            // 
            this.imageUploadBtn.BackColor = System.Drawing.Color.White;
            this.imageUploadBtn.FlatAppearance.BorderSize = 0;
            this.imageUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageUploadBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imageUploadBtn.Location = new System.Drawing.Point(253, 357);
            this.imageUploadBtn.Name = "imageUploadBtn";
            this.imageUploadBtn.Size = new System.Drawing.Size(70, 29);
            this.imageUploadBtn.TabIndex = 34;
            this.imageUploadBtn.Text = "Upload";
            this.imageUploadBtn.UseVisualStyleBackColor = false;
            this.imageUploadBtn.Click += new System.EventHandler(this.imageUploadBtn_Click);
            // 
            // imageRemoveBtn
            // 
            this.imageRemoveBtn.BackColor = System.Drawing.Color.White;
            this.imageRemoveBtn.FlatAppearance.BorderSize = 0;
            this.imageRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageRemoveBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imageRemoveBtn.Location = new System.Drawing.Point(253, 392);
            this.imageRemoveBtn.Name = "imageRemoveBtn";
            this.imageRemoveBtn.Size = new System.Drawing.Size(70, 29);
            this.imageRemoveBtn.TabIndex = 35;
            this.imageRemoveBtn.Text = "Remove";
            this.imageRemoveBtn.UseVisualStyleBackColor = false;
            this.imageRemoveBtn.Click += new System.EventHandler(this.imageRemoveBtn_Click);
            // 
            // car_price
            // 
            this.car_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.car_price.Location = new System.Drawing.Point(95, 244);
            this.car_price.Name = "car_price";
            this.car_price.Size = new System.Drawing.Size(227, 23);
            this.car_price.TabIndex = 3;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Yellow;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportBtn.ForeColor = System.Drawing.Color.Black;
            this.reportBtn.Location = new System.Drawing.Point(690, 111);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(155, 30);
            this.reportBtn.TabIndex = 36;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(764, 32);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 56;
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
            this.exitBtn.Location = new System.Drawing.Point(869, 30);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 55;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(255, 456);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(69, 29);
            this.deleteBtn.TabIndex = 58;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Black;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(170, 456);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 29);
            this.updateBtn.TabIndex = 59;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(936, 543);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.car_price);
            this.Controls.Add(this.imageRemoveBtn);
            this.Controls.Add(this.imageUploadBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.car_image);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.car_id);
            this.Controls.Add(this.carsDataView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.car_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.car_brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.car_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCars";
            this.Load += new System.EventHandler(this.ManageCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox car_name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox car_brand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox car_description;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView carsDataView;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox car_id;
        private System.Windows.Forms.PictureBox car_image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button imageUploadBtn;
        private System.Windows.Forms.Button imageRemoveBtn;
        private System.Windows.Forms.NumericUpDown car_price;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}