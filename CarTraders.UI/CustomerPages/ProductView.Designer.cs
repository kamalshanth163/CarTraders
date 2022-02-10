
namespace CarTraders.UI.CustomerPages
{
    partial class ProductView
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
            this.product_description = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.NumericUpDown();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.Label();
            this.product_brand = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.product_image = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // product_description
            // 
            this.product_description.AutoSize = true;
            this.product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_description.Location = new System.Drawing.Point(21, 288);
            this.product_description.Name = "product_description";
            this.product_description.Size = new System.Drawing.Size(100, 13);
            this.product_description.TabIndex = 52;
            this.product_description.Text = "Product Description";
            // 
            // product_quantity
            // 
            this.product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity.Location = new System.Drawing.Point(136, 413);
            this.product_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(69, 26);
            this.product_quantity.TabIndex = 51;
            this.product_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addToCartBtn.Location = new System.Drawing.Point(211, 412);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(105, 29);
            this.addToCartBtn.TabIndex = 50;
            this.addToCartBtn.Text = "Add to cart";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(20, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "LKR";
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.Cursor = System.Windows.Forms.Cursors.Cross;
            this.product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.product_price.Location = new System.Drawing.Point(62, 366);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(84, 26);
            this.product_price.TabIndex = 48;
            this.product_price.Text = "100000";
            // 
            // product_brand
            // 
            this.product_brand.AutoSize = true;
            this.product_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_brand.Location = new System.Drawing.Point(21, 237);
            this.product_brand.Name = "product_brand";
            this.product_brand.Size = new System.Drawing.Size(99, 17);
            this.product_brand.TabIndex = 47;
            this.product_brand.Text = "Product Brand";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(19, 255);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(143, 24);
            this.product_name.TabIndex = 46;
            this.product_name.Text = "Product Name";
            // 
            // product_image
            // 
            this.product_image.Location = new System.Drawing.Point(26, 53);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(283, 169);
            this.product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_image.TabIndex = 45;
            this.product_image.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(296, 8);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 34);
            this.exitBtn.TabIndex = 53;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 469);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.product_description);
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_brand);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.product_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductView";
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_description;
        private System.Windows.Forms.NumericUpDown product_quantity;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label product_price;
        private System.Windows.Forms.Label product_brand;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.PictureBox product_image;
        private System.Windows.Forms.Button exitBtn;
    }
}