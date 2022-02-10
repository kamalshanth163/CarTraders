
namespace CarTraders.UI.CustomerPages
{
    partial class OrderItemCard
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
            this.item_name = new System.Windows.Forms.Label();
            this.item_quantity = new System.Windows.Forms.Label();
            this.item_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.Location = new System.Drawing.Point(18, 13);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(51, 20);
            this.item_name.TabIndex = 0;
            this.item_name.Text = "Name";
            // 
            // item_quantity
            // 
            this.item_quantity.AutoSize = true;
            this.item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.Location = new System.Drawing.Point(196, 13);
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(18, 20);
            this.item_quantity.TabIndex = 1;
            this.item_quantity.Text = "2";
            // 
            // item_price
            // 
            this.item_price.AutoSize = true;
            this.item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price.Location = new System.Drawing.Point(244, 13);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(36, 20);
            this.item_price.TabIndex = 2;
            this.item_price.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // OrderItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.item_price);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.item_name);
            this.Name = "OrderItemCard";
            this.Size = new System.Drawing.Size(367, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label item_quantity;
        private System.Windows.Forms.Label item_price;
        private System.Windows.Forms.Label label1;
    }
}
