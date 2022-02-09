
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
            this.cars_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.store_tabs = new System.Windows.Forms.TabControl();
            this.cars_tabPage = new System.Windows.Forms.TabPage();
            this.cars_searchBox = new System.Windows.Forms.TextBox();
            this.carParts_tabPage = new System.Windows.Forms.TabPage();
            this.carParts_searchBox = new System.Windows.Forms.TextBox();
            this.carParts_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.cartBtn = new System.Windows.Forms.Button();
            this.store_tabs.SuspendLayout();
            this.cars_tabPage.SuspendLayout();
            this.carParts_tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(309, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 37);
            this.title.TabIndex = 38;
            this.title.Text = "Car Store";
            // 
            // cars_listing
            // 
            this.cars_listing.AutoScroll = true;
            this.cars_listing.BackColor = System.Drawing.Color.Transparent;
            this.cars_listing.Location = new System.Drawing.Point(16, 52);
            this.cars_listing.Name = "cars_listing";
            this.cars_listing.Size = new System.Drawing.Size(700, 303);
            this.cars_listing.TabIndex = 39;
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
            // store_tabs
            // 
            this.store_tabs.Controls.Add(this.cars_tabPage);
            this.store_tabs.Controls.Add(this.carParts_tabPage);
            this.store_tabs.Location = new System.Drawing.Point(31, 54);
            this.store_tabs.Name = "store_tabs";
            this.store_tabs.SelectedIndex = 0;
            this.store_tabs.Size = new System.Drawing.Size(739, 387);
            this.store_tabs.TabIndex = 43;
            // 
            // cars_tabPage
            // 
            this.cars_tabPage.Controls.Add(this.cars_searchBox);
            this.cars_tabPage.Controls.Add(this.cars_listing);
            this.cars_tabPage.Location = new System.Drawing.Point(4, 22);
            this.cars_tabPage.Name = "cars_tabPage";
            this.cars_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cars_tabPage.Size = new System.Drawing.Size(731, 361);
            this.cars_tabPage.TabIndex = 0;
            this.cars_tabPage.Text = "Cars";
            this.cars_tabPage.UseVisualStyleBackColor = true;
            // 
            // cars_searchBox
            // 
            this.cars_searchBox.Location = new System.Drawing.Point(238, 17);
            this.cars_searchBox.Name = "cars_searchBox";
            this.cars_searchBox.Size = new System.Drawing.Size(259, 20);
            this.cars_searchBox.TabIndex = 40;
            this.cars_searchBox.TextChanged += new System.EventHandler(this.cars_searchBox_TextChanged);
            // 
            // carParts_tabPage
            // 
            this.carParts_tabPage.Controls.Add(this.carParts_searchBox);
            this.carParts_tabPage.Controls.Add(this.carParts_listing);
            this.carParts_tabPage.Location = new System.Drawing.Point(4, 22);
            this.carParts_tabPage.Name = "carParts_tabPage";
            this.carParts_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carParts_tabPage.Size = new System.Drawing.Size(731, 361);
            this.carParts_tabPage.TabIndex = 1;
            this.carParts_tabPage.Text = "Car Parts";
            this.carParts_tabPage.UseVisualStyleBackColor = true;
            // 
            // carParts_searchBox
            // 
            this.carParts_searchBox.Location = new System.Drawing.Point(238, 17);
            this.carParts_searchBox.Name = "carParts_searchBox";
            this.carParts_searchBox.Size = new System.Drawing.Size(259, 20);
            this.carParts_searchBox.TabIndex = 46;
            this.carParts_searchBox.TextChanged += new System.EventHandler(this.carParts_searchBox_TextChanged);
            // 
            // carParts_listing
            // 
            this.carParts_listing.AutoScroll = true;
            this.carParts_listing.BackColor = System.Drawing.Color.Transparent;
            this.carParts_listing.Location = new System.Drawing.Point(16, 52);
            this.carParts_listing.Name = "carParts_listing";
            this.carParts_listing.Size = new System.Drawing.Size(700, 303);
            this.carParts_listing.TabIndex = 45;
            // 
            // cartBtn
            // 
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cartBtn.Location = new System.Drawing.Point(440, 22);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(53, 29);
            this.cartBtn.TabIndex = 44;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // CarStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.store_tabs);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarStore";
            this.Load += new System.EventHandler(this.CarStore_Load);
            this.store_tabs.ResumeLayout(false);
            this.cars_tabPage.ResumeLayout(false);
            this.cars_tabPage.PerformLayout();
            this.carParts_tabPage.ResumeLayout(false);
            this.carParts_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel cars_listing;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.TabControl store_tabs;
        private System.Windows.Forms.TabPage cars_tabPage;
        private System.Windows.Forms.TabPage carParts_tabPage;
        private System.Windows.Forms.TextBox cars_searchBox;
        private System.Windows.Forms.TextBox carParts_searchBox;
        private System.Windows.Forms.FlowLayoutPanel carParts_listing;
        private System.Windows.Forms.Button cartBtn;
    }
}