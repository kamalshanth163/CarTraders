
namespace CarTraders.UI.CustomerPages
{
    partial class CartItem
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
            this.product_index = new System.Windows.Forms.Label();
            this.product_type = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // product_index
            // 
            this.product_index.AutoSize = true;
            this.product_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_index.Location = new System.Drawing.Point(27, 14);
            this.product_index.Name = "product_index";
            this.product_index.Size = new System.Drawing.Size(16, 17);
            this.product_index.TabIndex = 0;
            this.product_index.Text = "1";
            // 
            // product_type
            // 
            this.product_type.AutoSize = true;
            this.product_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_type.Location = new System.Drawing.Point(305, 14);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(40, 17);
            this.product_type.TabIndex = 1;
            this.product_type.Text = "Type";
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(90, 14);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(45, 17);
            this.product_name.TabIndex = 3;
            this.product_name.Text = "Name";
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.Location = new System.Drawing.Point(486, 14);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(32, 17);
            this.product_price.TabIndex = 5;
            this.product_price.Text = "120";
            // 
            // product_quantity
            // 
            this.product_quantity.AutoSize = true;
            this.product_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_quantity.Location = new System.Drawing.Point(389, 14);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(16, 17);
            this.product_quantity.TabIndex = 6;
            this.product_quantity.Text = "1";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(602, 11);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(26, 23);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.product_type);
            this.Controls.Add(this.product_index);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(650, 45);
            this.Load += new System.EventHandler(this.CartItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_index;
        private System.Windows.Forms.Label product_type;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label product_price;
        private System.Windows.Forms.Label product_quantity;
        private System.Windows.Forms.Button deleteBtn;
    }
}
