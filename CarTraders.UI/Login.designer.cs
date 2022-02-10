
namespace CarTraders
{
    partial class Login
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this.user_password = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.user_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.title.Location = new System.Drawing.Point(110, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 54);
            this.title.TabIndex = 1;
            this.title.Text = "Login";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.loginBtn.Location = new System.Drawing.Point(290, 279);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(126, 43);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.cancelBtn.Location = new System.Drawing.Point(432, 285);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 30);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(209, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.Location = new System.Drawing.Point(209, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(352, 178);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(198, 23);
            this.user_email.TabIndex = 2;
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(352, 227);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(198, 23);
            this.user_password.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(749, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.user_type.Location = new System.Drawing.Point(352, 129);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(198, 23);
            this.user_type.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label6.Location = new System.Drawing.Point(209, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "User Type";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registerLink.Location = new System.Drawing.Point(358, 368);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(61, 17);
            this.registerLink.TabIndex = 32;
            this.registerLink.Text = "Register";
            this.registerLink.Click += new System.EventHandler(this.registerLink_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(327, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Don\'t have an account?";
            // 
            // homeBtn
            // 
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homeBtn.Location = new System.Drawing.Point(638, 14);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(105, 29);
            this.homeBtn.TabIndex = 37;
            this.homeBtn.Text = "Go to home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ComboBox user_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label registerLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button homeBtn;
    }
}