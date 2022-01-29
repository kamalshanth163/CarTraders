
namespace CarTraders
{
    partial class CustomerMenu
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
            this.customerMenuBtn2 = new System.Windows.Forms.Button();
            this.customerMenuBtn1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerMenuBtn2
            // 
            this.customerMenuBtn2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerMenuBtn2.Location = new System.Drawing.Point(283, 238);
            this.customerMenuBtn2.Name = "customerMenuBtn2";
            this.customerMenuBtn2.Size = new System.Drawing.Size(223, 46);
            this.customerMenuBtn2.TabIndex = 16;
            this.customerMenuBtn2.Text = "Rent Car Parts";
            this.customerMenuBtn2.UseVisualStyleBackColor = true;
            // 
            // customerMenuBtn1
            // 
            this.customerMenuBtn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerMenuBtn1.Location = new System.Drawing.Point(316, 174);
            this.customerMenuBtn1.Name = "customerMenuBtn1";
            this.customerMenuBtn1.Size = new System.Drawing.Size(171, 46);
            this.customerMenuBtn1.TabIndex = 15;
            this.customerMenuBtn1.Text = "Rent Cars";
            this.customerMenuBtn1.UseVisualStyleBackColor = true;
            this.customerMenuBtn1.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(246, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(308, 54);
            this.title.TabIndex = 14;
            this.title.Text = "Customer Menu";
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerMenuBtn2);
            this.Controls.Add(this.customerMenuBtn1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerMenuBtn2;
        private System.Windows.Forms.Button customerMenuBtn1;
        private System.Windows.Forms.Label title;
    }
}