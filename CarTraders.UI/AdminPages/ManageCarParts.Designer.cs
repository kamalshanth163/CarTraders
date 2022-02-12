
namespace CarTraders.UI.AdminPages
{
    partial class ManageCarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarParts));
            this.imageRemoveBtn = new System.Windows.Forms.Button();
            this.imageUploadBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.carPart_image = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            this.carPart_id = new System.Windows.Forms.TextBox();
            this.carPartsDataView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.carPart_description = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carPart_brand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.carPart_name = new System.Windows.Forms.TextBox();
            this.carPart_price = new System.Windows.Forms.NumericUpDown();
            this.reportBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPart_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPart_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageRemoveBtn
            // 
            this.imageRemoveBtn.BackColor = System.Drawing.Color.White;
            this.imageRemoveBtn.FlatAppearance.BorderSize = 0;
            this.imageRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageRemoveBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imageRemoveBtn.Location = new System.Drawing.Point(255, 397);
            this.imageRemoveBtn.Name = "imageRemoveBtn";
            this.imageRemoveBtn.Size = new System.Drawing.Size(70, 29);
            this.imageRemoveBtn.TabIndex = 56;
            this.imageRemoveBtn.Text = "Remove";
            this.imageRemoveBtn.UseVisualStyleBackColor = false;
            this.imageRemoveBtn.Click += new System.EventHandler(this.imageRemoveBtn_Click);
            // 
            // imageUploadBtn
            // 
            this.imageUploadBtn.BackColor = System.Drawing.Color.White;
            this.imageUploadBtn.FlatAppearance.BorderSize = 0;
            this.imageUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageUploadBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.imageUploadBtn.Location = new System.Drawing.Point(255, 362);
            this.imageUploadBtn.Name = "imageUploadBtn";
            this.imageUploadBtn.Size = new System.Drawing.Size(70, 29);
            this.imageUploadBtn.TabIndex = 55;
            this.imageUploadBtn.Text = "Upload";
            this.imageUploadBtn.UseVisualStyleBackColor = false;
            this.imageUploadBtn.Click += new System.EventHandler(this.imageUploadBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(94, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Image";
            // 
            // carPart_image
            // 
            this.carPart_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carPart_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPart_image.Location = new System.Drawing.Point(99, 362);
            this.carPart_image.Name = "carPart_image";
            this.carPart_image.Size = new System.Drawing.Size(150, 83);
            this.carPart_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPart_image.TabIndex = 53;
            this.carPart_image.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_id.Location = new System.Drawing.Point(94, 94);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 19);
            this.label_id.TabIndex = 52;
            this.label_id.Text = "Id";
            // 
            // carPart_id
            // 
            this.carPart_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carPart_id.Location = new System.Drawing.Point(98, 116);
            this.carPart_id.Name = "carPart_id";
            this.carPart_id.Size = new System.Drawing.Size(227, 23);
            this.carPart_id.TabIndex = 51;
            // 
            // carPartsDataView
            // 
            this.carPartsDataView.BackgroundColor = System.Drawing.Color.White;
            this.carPartsDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carPartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carPartsDataView.Location = new System.Drawing.Point(364, 152);
            this.carPartsDataView.Name = "carPartsDataView";
            this.carPartsDataView.RowTemplate.Height = 60;
            this.carPartsDataView.Size = new System.Drawing.Size(461, 328);
            this.carPartsDataView.TabIndex = 48;
            this.carPartsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carPartsDataView_CellContentClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(257, 451);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(68, 29);
            this.deleteBtn.TabIndex = 47;
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
            this.updateBtn.Location = new System.Drawing.Point(171, 451);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 29);
            this.updateBtn.TabIndex = 46;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Black;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(99, 451);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(61, 29);
            this.addBtn.TabIndex = 45;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // carPart_description
            // 
            this.carPart_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carPart_description.Location = new System.Drawing.Point(97, 294);
            this.carPart_description.Name = "carPart_description";
            this.carPart_description.Size = new System.Drawing.Size(227, 41);
            this.carPart_description.TabIndex = 4;
            this.carPart_description.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(93, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(93, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Price (LKR)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(93, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Brand";
            // 
            // carPart_brand
            // 
            this.carPart_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carPart_brand.Location = new System.Drawing.Point(97, 204);
            this.carPart_brand.Name = "carPart_brand";
            this.carPart_brand.Size = new System.Drawing.Size(227, 23);
            this.carPart_brand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(93, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(104, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(225, 37);
            this.title.TabIndex = 37;
            this.title.Text = "Manage Car Parts";
            // 
            // carPart_name
            // 
            this.carPart_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carPart_name.Location = new System.Drawing.Point(97, 159);
            this.carPart_name.Name = "carPart_name";
            this.carPart_name.Size = new System.Drawing.Size(227, 23);
            this.carPart_name.TabIndex = 1;
            // 
            // carPart_price
            // 
            this.carPart_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carPart_price.Location = new System.Drawing.Point(97, 249);
            this.carPart_price.Name = "carPart_price";
            this.carPart_price.Size = new System.Drawing.Size(227, 23);
            this.carPart_price.TabIndex = 3;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Yellow;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportBtn.ForeColor = System.Drawing.Color.Black;
            this.reportBtn.Location = new System.Drawing.Point(670, 116);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(155, 30);
            this.reportBtn.TabIndex = 58;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(755, 30);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 60;
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
            this.exitBtn.Location = new System.Drawing.Point(860, 28);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 59;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ManageCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(937, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.carPart_price);
            this.Controls.Add(this.imageRemoveBtn);
            this.Controls.Add(this.imageUploadBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carPart_image);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.carPart_id);
            this.Controls.Add(this.carPartsDataView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.carPart_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carPart_brand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.carPart_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCarParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCarParts";
            this.Load += new System.EventHandler(this.ManageCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPart_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPartsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPart_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imageRemoveBtn;
        private System.Windows.Forms.Button imageUploadBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox carPart_image;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox carPart_id;
        private System.Windows.Forms.DataGridView carPartsDataView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RichTextBox carPart_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carPart_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox carPart_name;
        private System.Windows.Forms.NumericUpDown carPart_price;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}