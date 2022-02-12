
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarStore));
            this.title = new System.Windows.Forms.Label();
            this.cars_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.store_tabs = new System.Windows.Forms.TabControl();
            this.cars_tabPage = new System.Windows.Forms.TabPage();
            this.cars_searchBox = new System.Windows.Forms.TextBox();
            this.carParts_tabPage = new System.Windows.Forms.TabPage();
            this.carParts_searchBox = new System.Windows.Forms.TextBox();
            this.carParts_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.cartBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.store_tabs.SuspendLayout();
            this.cars_tabPage.SuspendLayout();
            this.carParts_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(114, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 37);
            this.title.TabIndex = 38;
            this.title.Text = "Car Store";
            // 
            // cars_listing
            // 
            this.cars_listing.AutoScroll = true;
            this.cars_listing.BackColor = System.Drawing.Color.Transparent;
            this.cars_listing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cars_listing.Location = new System.Drawing.Point(16, 52);
            this.cars_listing.Name = "cars_listing";
            this.cars_listing.Size = new System.Drawing.Size(826, 305);
            this.cars_listing.TabIndex = 39;
            // 
            // store_tabs
            // 
            this.store_tabs.Controls.Add(this.cars_tabPage);
            this.store_tabs.Controls.Add(this.carParts_tabPage);
            this.store_tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.store_tabs.Location = new System.Drawing.Point(31, 104);
            this.store_tabs.Multiline = true;
            this.store_tabs.Name = "store_tabs";
            this.store_tabs.SelectedIndex = 0;
            this.store_tabs.Size = new System.Drawing.Size(870, 411);
            this.store_tabs.TabIndex = 43;
            // 
            // cars_tabPage
            // 
            this.cars_tabPage.BackColor = System.Drawing.Color.White;
            this.cars_tabPage.Controls.Add(this.pictureBox2);
            this.cars_tabPage.Controls.Add(this.cars_searchBox);
            this.cars_tabPage.Controls.Add(this.cars_listing);
            this.cars_tabPage.Location = new System.Drawing.Point(4, 34);
            this.cars_tabPage.Name = "cars_tabPage";
            this.cars_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cars_tabPage.Size = new System.Drawing.Size(862, 373);
            this.cars_tabPage.TabIndex = 0;
            this.cars_tabPage.Text = "Cars";
            // 
            // cars_searchBox
            // 
            this.cars_searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cars_searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cars_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cars_searchBox.Location = new System.Drawing.Point(248, 11);
            this.cars_searchBox.Name = "cars_searchBox";
            this.cars_searchBox.Size = new System.Drawing.Size(363, 31);
            this.cars_searchBox.TabIndex = 40;
            this.cars_searchBox.TextChanged += new System.EventHandler(this.cars_searchBox_TextChanged);
            // 
            // carParts_tabPage
            // 
            this.carParts_tabPage.BackColor = System.Drawing.Color.White;
            this.carParts_tabPage.Controls.Add(this.pictureBox3);
            this.carParts_tabPage.Controls.Add(this.carParts_searchBox);
            this.carParts_tabPage.Controls.Add(this.carParts_listing);
            this.carParts_tabPage.Location = new System.Drawing.Point(4, 34);
            this.carParts_tabPage.Name = "carParts_tabPage";
            this.carParts_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carParts_tabPage.Size = new System.Drawing.Size(862, 373);
            this.carParts_tabPage.TabIndex = 1;
            this.carParts_tabPage.Text = "Car Parts";
            // 
            // carParts_searchBox
            // 
            this.carParts_searchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.carParts_searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carParts_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.carParts_searchBox.Location = new System.Drawing.Point(250, 11);
            this.carParts_searchBox.Name = "carParts_searchBox";
            this.carParts_searchBox.Size = new System.Drawing.Size(358, 31);
            this.carParts_searchBox.TabIndex = 46;
            this.carParts_searchBox.TextChanged += new System.EventHandler(this.carParts_searchBox_TextChanged);
            // 
            // carParts_listing
            // 
            this.carParts_listing.AutoScroll = true;
            this.carParts_listing.BackColor = System.Drawing.Color.Transparent;
            this.carParts_listing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.carParts_listing.Location = new System.Drawing.Point(16, 52);
            this.carParts_listing.Name = "carParts_listing";
            this.carParts_listing.Size = new System.Drawing.Size(827, 303);
            this.carParts_listing.TabIndex = 45;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.Gold;
            this.cartBtn.FlatAppearance.BorderSize = 0;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cartBtn.Location = new System.Drawing.Point(245, 44);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(88, 29);
            this.cartBtn.TabIndex = 44;
            this.cartBtn.Text = "View Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(760, 35);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 65;
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
            this.exitBtn.Location = new System.Drawing.Point(865, 33);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 64;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(583, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(582, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // CarStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.store_tabs);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel cars_listing;
        private System.Windows.Forms.TabControl store_tabs;
        private System.Windows.Forms.TabPage cars_tabPage;
        private System.Windows.Forms.TabPage carParts_tabPage;
        private System.Windows.Forms.TextBox cars_searchBox;
        private System.Windows.Forms.TextBox carParts_searchBox;
        private System.Windows.Forms.FlowLayoutPanel carParts_listing;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}