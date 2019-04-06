namespace Demo
{
    partial class AddAdminUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.password2Field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CearButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.WrongInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(196, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 26);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameField.ForeColor = System.Drawing.Color.Black;
            this.nameField.Location = new System.Drawing.Point(196, 121);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(195, 20);
            this.nameField.TabIndex = 3;
            this.nameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // phoneField
            // 
            this.phoneField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.phoneField.ForeColor = System.Drawing.Color.Black;
            this.phoneField.Location = new System.Drawing.Point(196, 165);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(195, 20);
            this.phoneField.TabIndex = 4;
            this.phoneField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passwordField.ForeColor = System.Drawing.Color.Black;
            this.passwordField.Location = new System.Drawing.Point(196, 208);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(195, 20);
            this.passwordField.TabIndex = 5;
            this.passwordField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // password2Field
            // 
            this.password2Field.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.password2Field.ForeColor = System.Drawing.Color.Black;
            this.password2Field.Location = new System.Drawing.Point(196, 250);
            this.password2Field.Name = "password2Field";
            this.password2Field.PasswordChar = '*';
            this.password2Field.Size = new System.Drawing.Size(195, 20);
            this.password2Field.TabIndex = 6;
            this.password2Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password2Field.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(149, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(93, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(129, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(146, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CearButton
            // 
            this.CearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CearButton.Location = new System.Drawing.Point(305, 297);
            this.CearButton.Name = "CearButton";
            this.CearButton.Size = new System.Drawing.Size(86, 26);
            this.CearButton.TabIndex = 11;
            this.CearButton.Text = "Clear";
            this.CearButton.UseVisualStyleBackColor = false;
            this.CearButton.Click += new System.EventHandler(this.CearButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(129, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username :";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usernameField.ForeColor = System.Drawing.Color.Black;
            this.usernameField.Location = new System.Drawing.Point(196, 76);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(195, 20);
            this.usernameField.TabIndex = 12;
            this.usernameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WrongInputLabel
            // 
            this.WrongInputLabel.AutoSize = true;
            this.WrongInputLabel.BackColor = System.Drawing.Color.Transparent;
            this.WrongInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongInputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.WrongInputLabel.Location = new System.Drawing.Point(197, 273);
            this.WrongInputLabel.Name = "WrongInputLabel";
            this.WrongInputLabel.Size = new System.Drawing.Size(0, 15);
            this.WrongInputLabel.TabIndex = 14;
            this.WrongInputLabel.Visible = false;
            this.WrongInputLabel.Click += new System.EventHandler(this.WrongInputLabel_Click);
            // 
            // AddAdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.WrongInputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.CearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password2Field);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.phoneField);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.AddButton);
            this.Name = "AddAdminUserControl";
            this.Size = new System.Drawing.Size(499, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox password2Field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label WrongInputLabel;
    }
}
