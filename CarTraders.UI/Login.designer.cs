
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.title.Location = new System.Drawing.Point(253, 91);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 54);
            this.title.TabIndex = 1;
            this.title.Text = "Login";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Gold;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(370, 381);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(126, 43);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.cancelBtn.Location = new System.Drawing.Point(512, 387);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 30);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(272, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.Location = new System.Drawing.Point(272, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // user_email
            // 
            this.user_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_email.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.user_email.Location = new System.Drawing.Point(415, 237);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(278, 25);
            this.user_email.TabIndex = 2;
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.Color.White;
            this.user_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.user_password.Location = new System.Drawing.Point(415, 286);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(278, 25);
            this.user_password.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(881, 24);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 35);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // user_type
            // 
            this.user_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_type.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.user_type.FormattingEnabled = true;
            this.user_type.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.user_type.Location = new System.Drawing.Point(415, 180);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(278, 33);
            this.user_type.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label6.Location = new System.Drawing.Point(272, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 29;
            this.label6.Text = "User Type";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.registerLink.Location = new System.Drawing.Point(515, 461);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(83, 25);
            this.registerLink.TabIndex = 32;
            this.registerLink.Text = "Register";
            this.registerLink.Click += new System.EventHandler(this.registerLink_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(350, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Don\'t have an account?";
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.White;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homeBtn.Location = new System.Drawing.Point(758, 27);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(117, 32);
            this.homeBtn.TabIndex = 37;
            this.homeBtn.Text = "Go to home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 549);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}