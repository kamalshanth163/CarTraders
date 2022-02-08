
namespace CarTraders.UI.AdminPages
{
    partial class ManageCustomers
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
            this.label_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.customersDataView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label_id.Location = new System.Drawing.Point(31, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 19);
            this.label_id.TabIndex = 52;
            this.label_id.Text = "Id";
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(35, 61);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(227, 20);
            this.customer_id.TabIndex = 51;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(731, 28);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 31);
            this.exitBtn.TabIndex = 50;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuBtn.Location = new System.Drawing.Point(620, 30);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(105, 29);
            this.menuBtn.TabIndex = 49;
            this.menuBtn.Text = "Go to menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // customersDataView
            // 
            this.customersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataView.Location = new System.Drawing.Point(293, 82);
            this.customersDataView.Name = "customersDataView";
            this.customersDataView.RowTemplate.Height = 60;
            this.customersDataView.Size = new System.Drawing.Size(461, 343);
            this.customersDataView.TabIndex = 48;
            this.customersDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataView_CellContentClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(153, 396);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 29);
            this.deleteBtn.TabIndex = 47;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateBtn.Location = new System.Drawing.Point(36, 396);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 29);
            this.updateBtn.TabIndex = 46;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phone";
            // 
            // customer_phone
            // 
            this.customer_phone.Location = new System.Drawing.Point(34, 194);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(227, 20);
            this.customer_phone.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Address";
            // 
            // customer_address
            // 
            this.customer_address.Location = new System.Drawing.Point(34, 149);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(227, 20);
            this.customer_address.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.Location = new System.Drawing.Point(286, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 37);
            this.title.TabIndex = 37;
            this.title.Text = "Manage Customers";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(34, 104);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(227, 20);
            this.customer_name.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(32, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Password";
            // 
            // customer_password
            // 
            this.customer_password.Location = new System.Drawing.Point(36, 284);
            this.customer_password.Name = "customer_password";
            this.customer_password.Size = new System.Drawing.Size(227, 20);
            this.customer_password.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(32, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Email";
            // 
            // customer_email
            // 
            this.customer_email.Location = new System.Drawing.Point(36, 239);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(227, 20);
            this.customer_email.TabIndex = 53;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customer_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customer_email);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.customersDataView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customer_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.customer_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.DataGridView customersDataView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customer_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customer_email;
    }
}