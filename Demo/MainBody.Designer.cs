namespace Demo
{
    partial class MainBody
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBody));
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HelpTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.BooksTabButton = new System.Windows.Forms.Button();
            this.SlidTabButton = new System.Windows.Forms.Button();
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.SlidingPanel.Controls.Add(this.AboutTabButton);
            this.SlidingPanel.Controls.Add(this.LogoutButton);
            this.SlidingPanel.Controls.Add(this.HelpTabButton);
            this.SlidingPanel.Controls.Add(this.SettingsTabButton);
            this.SlidingPanel.Controls.Add(this.TransactionTabButton);
            this.SlidingPanel.Controls.Add(this.BorrowersTabButton);
            this.SlidingPanel.Controls.Add(this.BooksTabButton);
            this.SlidingPanel.Controls.Add(this.SlidTabButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(174, 558);
            this.SlidingPanel.TabIndex = 2;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Paint);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.AboutTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.Image = global::Demo.Properties.Resources.About;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(-1, 342);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(174, 59);
            this.AboutTabButton.TabIndex = 6;
            this.AboutTabButton.UseVisualStyleBackColor = true;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(-1, 400);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(174, 59);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoffButton_Click);
            // 
            // HelpTabButton
            // 
            this.HelpTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.HelpTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.HelpTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpTabButton.Image = global::Demo.Properties.Resources.Help;
            this.HelpTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpTabButton.Location = new System.Drawing.Point(-1, 285);
            this.HelpTabButton.Name = "HelpTabButton";
            this.HelpTabButton.Size = new System.Drawing.Size(174, 59);
            this.HelpTabButton.TabIndex = 5;
            this.HelpTabButton.UseVisualStyleBackColor = true;
            this.HelpTabButton.Click += new System.EventHandler(this.HelpTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.SettingsTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTabButton.Image = global::Demo.Properties.Resources.Settings;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(-1, 228);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Size = new System.Drawing.Size(174, 59);
            this.SettingsTabButton.TabIndex = 4;
            this.SettingsTabButton.UseVisualStyleBackColor = true;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.TransactionTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTabButton.Image = global::Demo.Properties.Resources.Transactions;
            this.TransactionTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionTabButton.Location = new System.Drawing.Point(-1, 171);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(174, 59);
            this.TransactionTabButton.TabIndex = 3;
            this.TransactionTabButton.UseVisualStyleBackColor = true;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.BorrowersTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowersTabButton.Image = global::Demo.Properties.Resources.Borrowers;
            this.BorrowersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowersTabButton.Location = new System.Drawing.Point(-1, 114);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(174, 59);
            this.BorrowersTabButton.TabIndex = 2;
            this.BorrowersTabButton.UseVisualStyleBackColor = true;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // BooksTabButton
            // 
            this.BooksTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.BooksTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.BooksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksTabButton.Image = global::Demo.Properties.Resources.Books;
            this.BooksTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksTabButton.Location = new System.Drawing.Point(-1, 57);
            this.BooksTabButton.Name = "BooksTabButton";
            this.BooksTabButton.Size = new System.Drawing.Size(174, 59);
            this.BooksTabButton.TabIndex = 1;
            this.BooksTabButton.UseVisualStyleBackColor = true;
            this.BooksTabButton.Click += new System.EventHandler(this.BooksTabButton_Click);
            // 
            // SlidTabButton
            // 
            this.SlidTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.SlidTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.SlidTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlidTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidTabButton.Location = new System.Drawing.Point(-1, 0);
            this.SlidTabButton.Name = "SlidTabButton";
            this.SlidTabButton.Size = new System.Drawing.Size(174, 59);
            this.SlidTabButton.TabIndex = 0;
            this.SlidTabButton.UseVisualStyleBackColor = true;
            this.SlidTabButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Interval = 15;
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(175, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(635, 558);
            this.ContentPanel.TabIndex = 3;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // MainBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 558);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainBody";
            this.Text = "MainBody";
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidTabButton;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button HelpTabButton;
        private System.Windows.Forms.Button SettingsTabButton;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Button BooksTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}