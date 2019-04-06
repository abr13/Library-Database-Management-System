namespace Demo
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WrongInputLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.AddAdminPanel = new System.Windows.Forms.Panel();
            this.CloseAddAdmin = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Location = new System.Drawing.Point(181, 312);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(195, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(10, 380);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 26);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.passwordField.ForeColor = System.Drawing.SystemColors.Window;
            this.passwordField.Location = new System.Drawing.Point(181, 268);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(195, 20);
            this.passwordField.TabIndex = 3;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordField_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(321, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(323, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // WrongInputLabel
            // 
            this.WrongInputLabel.AutoSize = true;
            this.WrongInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongInputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WrongInputLabel.Location = new System.Drawing.Point(221, 341);
            this.WrongInputLabel.Name = "WrongInputLabel";
            this.WrongInputLabel.Size = new System.Drawing.Size(127, 15);
            this.WrongInputLabel.TabIndex = 6;
            this.WrongInputLabel.Text = "Credentials are wrong";
            this.WrongInputLabel.Visible = false;
            this.WrongInputLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(241, 366);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add New Admin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Karavali Institute Of Technology";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Demo.Properties.Resources.KITLogo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 108);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Library Management System";
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(177, 161);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(54, 20);
            this.AdminLabel.TabIndex = 11;
            this.AdminLabel.Text = "Admin";
            // 
            // AddAdminPanel
            // 
            this.AddAdminPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AddAdminPanel.Location = new System.Drawing.Point(29, 45);
            this.AddAdminPanel.Name = "AddAdminPanel";
            this.AddAdminPanel.Size = new System.Drawing.Size(499, 335);
            this.AddAdminPanel.TabIndex = 12;
            this.AddAdminPanel.Visible = false;
            this.AddAdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddAdminPanel_Paint);
            // 
            // CloseAddAdmin
            // 
            this.CloseAddAdmin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloseAddAdmin.FlatAppearance.BorderSize = 0;
            this.CloseAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAddAdmin.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseAddAdmin.Location = new System.Drawing.Point(492, 380);
            this.CloseAddAdmin.Name = "CloseAddAdmin";
            this.CloseAddAdmin.Size = new System.Drawing.Size(36, 26);
            this.CloseAddAdmin.TabIndex = 13;
            this.CloseAddAdmin.Text = "Close";
            this.CloseAddAdmin.UseVisualStyleBackColor = false;
            this.CloseAddAdmin.Visible = false;
            this.CloseAddAdmin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.usernameField.ForeColor = System.Drawing.SystemColors.Window;
            this.usernameField.Location = new System.Drawing.Point(181, 224);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(195, 20);
            this.usernameField.TabIndex = 2;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameField_MouseClick);
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.LoginCover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 418);
            this.Controls.Add(this.AddAdminPanel);
            this.Controls.Add(this.CloseAddAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.WrongInputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WrongInputLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Panel AddAdminPanel;
        private System.Windows.Forms.Button CloseAddAdmin;
        private System.Windows.Forms.TextBox usernameField;
    }
}

