
namespace CarTraders.UI.CustomerPages
{
    partial class CustomerOrders
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.completedBtn = new System.Windows.Forms.Button();
            this.pendingBtn = new System.Windows.Forms.Button();
            this.orders_listing = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(278, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 37);
            this.title.TabIndex = 31;
            this.title.Text = "View Order Details";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(740, 22);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 35;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(629, 24);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 34;
            this.menuBtn.Text = "Go to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allBtn.Location = new System.Drawing.Point(92, 157);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(90, 29);
            this.allBtn.TabIndex = 36;
            this.allBtn.Text = "All";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // completedBtn
            // 
            this.completedBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.completedBtn.Location = new System.Drawing.Point(92, 227);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(90, 29);
            this.completedBtn.TabIndex = 37;
            this.completedBtn.Text = "Completed";
            this.completedBtn.UseVisualStyleBackColor = true;
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // pendingBtn
            // 
            this.pendingBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pendingBtn.Location = new System.Drawing.Point(92, 192);
            this.pendingBtn.Name = "pendingBtn";
            this.pendingBtn.Size = new System.Drawing.Size(90, 29);
            this.pendingBtn.TabIndex = 38;
            this.pendingBtn.Text = "Pending";
            this.pendingBtn.UseVisualStyleBackColor = true;
            this.pendingBtn.Click += new System.EventHandler(this.pendingBtn_Click);
            // 
            // orders_listing
            // 
            this.orders_listing.Location = new System.Drawing.Point(198, 154);
            this.orders_listing.Name = "orders_listing";
            this.orders_listing.Size = new System.Drawing.Size(450, 261);
            this.orders_listing.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ordered Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Price (LKR)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Orders";
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orders_listing);
            this.Controls.Add(this.pendingBtn);
            this.Controls.Add(this.completedBtn);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.CustomerOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button completedBtn;
        private System.Windows.Forms.Button pendingBtn;
        private System.Windows.Forms.FlowLayoutPanel orders_listing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}