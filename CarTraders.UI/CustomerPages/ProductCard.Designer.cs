
namespace CarTraders.UI.CustomerPages
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product_image = new System.Windows.Forms.PictureBox();
            this.product_name = new System.Windows.Forms.Label();
            this.product_brand = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // product_image
            // 
            this.product_image.Location = new System.Drawing.Point(0, 0);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(156, 96);
            this.product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.product_image.TabIndex = 0;
            this.product_image.TabStop = false;
            this.product_image.Click += new System.EventHandler(this.ProductCard_Click);
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(12, 112);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(110, 17);
            this.product_name.TabIndex = 1;
            this.product_name.Text = "Product Name";
            // 
            // product_brand
            // 
            this.product_brand.AutoSize = true;
            this.product_brand.Location = new System.Drawing.Point(12, 138);
            this.product_brand.Name = "product_brand";
            this.product_brand.Size = new System.Drawing.Size(75, 13);
            this.product_brand.TabIndex = 2;
            this.product_brand.Text = "Product Brand";
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.Cursor = System.Windows.Forms.Cursors.Cross;
            this.product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.product_price.Location = new System.Drawing.Point(44, 189);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(56, 17);
            this.product_price.TabIndex = 4;
            this.product_price.Text = "100000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "LKR";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_brand);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.product_image);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(156, 223);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            this.Click += new System.EventHandler(this.ProductCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox product_image;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label product_brand;
        private System.Windows.Forms.Label product_price;
        private System.Windows.Forms.Label label1;
    }
}
