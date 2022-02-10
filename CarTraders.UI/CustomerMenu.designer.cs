
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
            this.carsPart_btn = new System.Windows.Forms.Button();
            this.cars_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carsPart_btn
            // 
            this.carsPart_btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.carsPart_btn.Location = new System.Drawing.Point(243, 206);
            this.carsPart_btn.Name = "carsPart_btn";
            this.carsPart_btn.Size = new System.Drawing.Size(191, 40);
            this.carsPart_btn.TabIndex = 16;
            this.carsPart_btn.Text = "Buy Car Parts";
            this.carsPart_btn.UseVisualStyleBackColor = true;
            // 
            // cars_btn
            // 
            this.cars_btn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cars_btn.Location = new System.Drawing.Point(271, 151);
            this.cars_btn.Name = "cars_btn";
            this.cars_btn.Size = new System.Drawing.Size(147, 40);
            this.cars_btn.TabIndex = 15;
            this.cars_btn.Text = "Buy Cars";
            this.cars_btn.UseVisualStyleBackColor = true;
            this.cars_btn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.title.Location = new System.Drawing.Point(211, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(308, 54);
            this.title.TabIndex = 14;
            this.title.Text = "Customer Menu";
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.carsPart_btn);
            this.Controls.Add(this.cars_btn);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carsPart_btn;
        private System.Windows.Forms.Button cars_btn;
        private System.Windows.Forms.Label title;
    }
}