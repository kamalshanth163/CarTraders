
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
            this.product_description.BackColor = System.Drawing.Color.Black;
            this.product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.product_description.ForeColor = System.Drawing.Color.White;
            this.product_description.Location = new System.Drawing.Point(57, 140);
            this.product_description.Name = "product_description";
            this.product_description.Size = new System.Drawing.Size(174, 24);
            this.product_description.TabIndex = 52;
            this.product_description.Text = "Product Description";
            // 
            // product_quantity
            // 
            this.product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.product_quantity.Location = new System.Drawing.Point(40, 389);
            this.product_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(125, 38);
            this.product_quantity.TabIndex = 51;
            this.product_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.Black;
            this.addToCartBtn.FlatAppearance.BorderSize = 0;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.addToCartBtn.ForeColor = System.Drawing.Color.White;
            this.addToCartBtn.Location = new System.Drawing.Point(407, 385);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(166, 55);
            this.addToCartBtn.TabIndex = 50;
            this.addToCartBtn.Text = "Add to cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "LKR";
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.BackColor = System.Drawing.Color.Black;
            this.product_price.Cursor = System.Windows.Forms.Cursors.Cross;
            this.product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.product_price.ForeColor = System.Drawing.Color.White;
            this.product_price.Location = new System.Drawing.Point(134, 272);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(137, 39);
            this.product_price.TabIndex = 48;
            this.product_price.Text = "100000";
            // 
            // product_brand
            // 
            this.product_brand.AutoSize = true;
            this.product_brand.BackColor = System.Drawing.Color.Black;
            this.product_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.product_brand.ForeColor = System.Drawing.Color.White;
            this.product_brand.Location = new System.Drawing.Point(56, 96);
            this.product_brand.Name = "product_brand";
            this.product_brand.Size = new System.Drawing.Size(166, 29);
            this.product_brand.TabIndex = 47;
            this.product_brand.Text = "Product Brand";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.Color.Black;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.product_name.ForeColor = System.Drawing.Color.White;
            this.product_name.Location = new System.Drawing.Point(55, 43);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(235, 37);
            this.product_name.TabIndex = 46;
            this.product_name.Text = "Product Name";
            // 
            // product_image
            // 
            this.product_image.Location = new System.Drawing.Point(0, 0);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(601, 350);
            this.product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_image.TabIndex = 45;
            this.product_image.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(284, 389);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 47);
            this.exitBtn.TabIndex = 66;
            this.exitBtn.Text = "Cancel";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(600, 469);
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