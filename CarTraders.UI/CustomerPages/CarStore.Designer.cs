
namespace CarTraders.UI.CustomerPages
{
    partial class CarStore
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
            this.title = new System.Windows.Forms.Label();
            this.products_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(23, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(136, 37);
            this.title.TabIndex = 38;
            this.title.Text = "Cars Store";
            // 
            // products_listing
            // 
            this.products_listing.AutoScroll = true;
            this.products_listing.BackColor = System.Drawing.Color.Transparent;
            this.products_listing.Location = new System.Drawing.Point(50, 100);
            this.products_listing.Name = "products_listing";
            this.products_listing.Size = new System.Drawing.Size(688, 338);
            this.products_listing.TabIndex = 39;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(744, 17);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 42;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(633, 19);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 41;
            this.menuBtn.Text = "Go to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // CarStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.products_listing);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarStore";
            this.Load += new System.EventHandler(this.CarStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel products_listing;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
    }
}