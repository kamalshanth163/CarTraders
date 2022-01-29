
namespace CarTraders
{
    partial class AdminMenu
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
            this.adminMenuBtn1 = new System.Windows.Forms.Button();
            this.adminMenuBtn2 = new System.Windows.Forms.Button();
            this.adminMenuBtn4 = new System.Windows.Forms.Button();
            this.adminMenuBtn3 = new System.Windows.Forms.Button();
            this.adminMenuBtn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminMenuBtn1
            // 
            this.adminMenuBtn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenuBtn1.Location = new System.Drawing.Point(290, 150);
            this.adminMenuBtn1.Name = "adminMenuBtn1";
            this.adminMenuBtn1.Size = new System.Drawing.Size(218, 46);
            this.adminMenuBtn1.TabIndex = 8;
            this.adminMenuBtn1.Text = "View Dashboard";
            this.adminMenuBtn1.UseVisualStyleBackColor = true;
            
            // 
            // adminMenuBtn2
            // 
            this.adminMenuBtn2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenuBtn2.Location = new System.Drawing.Point(302, 202);
            this.adminMenuBtn2.Name = "adminMenuBtn2";
            this.adminMenuBtn2.Size = new System.Drawing.Size(193, 46);
            this.adminMenuBtn2.TabIndex = 9;
            this.adminMenuBtn2.Text = "Manage Cars";
            this.adminMenuBtn2.UseVisualStyleBackColor = true;
            // 
            // adminMenuBtn4
            // 
            this.adminMenuBtn4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenuBtn4.Location = new System.Drawing.Point(231, 306);
            this.adminMenuBtn4.Name = "adminMenuBtn4";
            this.adminMenuBtn4.Size = new System.Drawing.Size(338, 46);
            this.adminMenuBtn4.TabIndex = 10;
            this.adminMenuBtn4.Text = "Manage Customers and Orders";
            this.adminMenuBtn4.UseVisualStyleBackColor = true;
            this.adminMenuBtn4.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminMenuBtn3
            // 
            this.adminMenuBtn3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenuBtn3.Location = new System.Drawing.Point(267, 254);
            this.adminMenuBtn3.Name = "adminMenuBtn3";
            this.adminMenuBtn3.Size = new System.Drawing.Size(261, 46);
            this.adminMenuBtn3.TabIndex = 11;
            this.adminMenuBtn3.Text = "Manage Car Parts";
            this.adminMenuBtn3.UseVisualStyleBackColor = true;
            // 
            // adminMenuBtn5
            // 
            this.adminMenuBtn5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adminMenuBtn5.Location = new System.Drawing.Point(288, 358);
            this.adminMenuBtn5.Name = "adminMenuBtn5";
            this.adminMenuBtn5.Size = new System.Drawing.Size(220, 46);
            this.adminMenuBtn5.TabIndex = 13;
            this.adminMenuBtn5.Text = "Generate Reports";
            this.adminMenuBtn5.UseVisualStyleBackColor = true;
            this.adminMenuBtn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminMenuBtn5);
            this.Controls.Add(this.adminMenuBtn3);
            this.Controls.Add(this.adminMenuBtn4);
            this.Controls.Add(this.adminMenuBtn2);
            this.Controls.Add(this.adminMenuBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminMenuBtn1;
        private System.Windows.Forms.Button adminMenuBtn2;
        private System.Windows.Forms.Button adminMenuBtn4;
        private System.Windows.Forms.Button adminMenuBtn3;
        private System.Windows.Forms.Button adminMenuBtn5;
    }
}