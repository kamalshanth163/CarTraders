
namespace CarTraders.UI.CustomerPages
{
    partial class OrderCard
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
            this.order_status = new System.Windows.Forms.Label();
            this.order_createdAt = new System.Windows.Forms.Label();
            this.order_price = new System.Windows.Forms.Label();
            this.order_index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // order_status
            // 
            this.order_status.AutoSize = true;
            this.order_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_status.Location = new System.Drawing.Point(542, 28);
            this.order_status.Name = "order_status";
            this.order_status.Size = new System.Drawing.Size(56, 20);
            this.order_status.TabIndex = 10;
            this.order_status.Text = "Status";
            // 
            // order_createdAt
            // 
            this.order_createdAt.AutoSize = true;
            this.order_createdAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_createdAt.Location = new System.Drawing.Point(92, 28);
            this.order_createdAt.Name = "order_createdAt";
            this.order_createdAt.Size = new System.Drawing.Size(105, 20);
            this.order_createdAt.TabIndex = 9;
            this.order_createdAt.Text = "Created Date";
            // 
            // order_price
            // 
            this.order_price.AutoSize = true;
            this.order_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_price.Location = new System.Drawing.Point(349, 28);
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(83, 20);
            this.order_price.TabIndex = 8;
            this.order_price.Text = "Total Price";
            // 
            // order_index
            // 
            this.order_index.AutoSize = true;
            this.order_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.order_index.Location = new System.Drawing.Point(26, 28);
            this.order_index.Name = "order_index";
            this.order_index.Size = new System.Drawing.Size(18, 20);
            this.order_index.TabIndex = 7;
            this.order_index.Text = "1";
            // 
            // OrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.order_status);
            this.Controls.Add(this.order_createdAt);
            this.Controls.Add(this.order_price);
            this.Controls.Add(this.order_index);
            this.Name = "OrderCard";
            this.Size = new System.Drawing.Size(692, 73);
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label order_status;
        private System.Windows.Forms.Label order_createdAt;
        private System.Windows.Forms.Label order_price;
        private System.Windows.Forms.Label order_index;
    }
}
