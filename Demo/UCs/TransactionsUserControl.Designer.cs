namespace Demo
{
    partial class TransactionsUserControl
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
            this.SearchTransactionNoField = new System.Windows.Forms.TextBox();
            this.SearchBorrowersIdField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BorrowersIdField = new System.Windows.Forms.TextBox();
            this.AccessionNoField = new System.Windows.Forms.TextBox();
            this.AuthorizedByField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AccNoLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.HasReturnedCheckBox = new System.Windows.Forms.CheckBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDoneLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTransactionNoField
            // 
            this.SearchTransactionNoField.Location = new System.Drawing.Point(125, 34);
            this.SearchTransactionNoField.Name = "SearchTransactionNoField";
            this.SearchTransactionNoField.Size = new System.Drawing.Size(165, 20);
            this.SearchTransactionNoField.TabIndex = 3;
            this.SearchTransactionNoField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTransactionNoField_MouseClick);
            this.SearchTransactionNoField.TextChanged += new System.EventHandler(this.SearchTransactionNoField_TextChanged);
            // 
            // SearchBorrowersIdField
            // 
            this.SearchBorrowersIdField.Location = new System.Drawing.Point(399, 34);
            this.SearchBorrowersIdField.Name = "SearchBorrowersIdField";
            this.SearchBorrowersIdField.Size = new System.Drawing.Size(165, 20);
            this.SearchBorrowersIdField.TabIndex = 4;
            this.SearchBorrowersIdField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBorrowersIdField_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OR Borrower\'s ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transaction No. :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(573, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "Search Borrower";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(103, 309);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 26);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(43, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(652, 207);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BorrowersIdField
            // 
            this.BorrowersIdField.Location = new System.Drawing.Point(484, 363);
            this.BorrowersIdField.Name = "BorrowersIdField";
            this.BorrowersIdField.Size = new System.Drawing.Size(165, 20);
            this.BorrowersIdField.TabIndex = 30;
            // 
            // AccessionNoField
            // 
            this.AccessionNoField.Location = new System.Drawing.Point(171, 362);
            this.AccessionNoField.Name = "AccessionNoField";
            this.AccessionNoField.Size = new System.Drawing.Size(165, 20);
            this.AccessionNoField.TabIndex = 33;
            // 
            // AuthorizedByField
            // 
            this.AuthorizedByField.Location = new System.Drawing.Point(171, 457);
            this.AuthorizedByField.Name = "AuthorizedByField";
            this.AuthorizedByField.Size = new System.Drawing.Size(165, 20);
            this.AuthorizedByField.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Has Returned :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Authorized by :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Time :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Return Date :";
            // 
            // AccNoLabel
            // 
            this.AccNoLabel.AutoSize = true;
            this.AccNoLabel.Location = new System.Drawing.Point(83, 366);
            this.AccNoLabel.Name = "AccNoLabel";
            this.AccNoLabel.Size = new System.Drawing.Size(82, 13);
            this.AccNoLabel.TabIndex = 42;
            this.AccNoLabel.Text = "Accession No. :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Borrower\'s ID :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // HasReturnedCheckBox
            // 
            this.HasReturnedCheckBox.AutoSize = true;
            this.HasReturnedCheckBox.Location = new System.Drawing.Point(386, 499);
            this.HasReturnedCheckBox.Name = "HasReturnedCheckBox";
            this.HasReturnedCheckBox.Size = new System.Drawing.Size(44, 17);
            this.HasReturnedCheckBox.TabIndex = 44;
            this.HasReturnedCheckBox.Text = "Yes";
            this.HasReturnedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(169, 409);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(167, 20);
            this.DatePicker.TabIndex = 45;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(484, 409);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(167, 20);
            this.TimePicker.TabIndex = 46;
            // 
            // ReturnDateDatePicker
            // 
            this.ReturnDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDateDatePicker.Location = new System.Drawing.Point(484, 457);
            this.ReturnDateDatePicker.Name = "ReturnDateDatePicker";
            this.ReturnDateDatePicker.Size = new System.Drawing.Size(167, 20);
            this.ReturnDateDatePicker.TabIndex = 47;
            // 
            // TransactionDoneLabel
            // 
            this.TransactionDoneLabel.AutoSize = true;
            this.TransactionDoneLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.TransactionDoneLabel.Location = new System.Drawing.Point(298, 532);
            this.TransactionDoneLabel.Name = "TransactionDoneLabel";
            this.TransactionDoneLabel.Size = new System.Drawing.Size(0, 13);
            this.TransactionDoneLabel.TabIndex = 48;
            this.TransactionDoneLabel.Visible = false;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SearchLabel.Location = new System.Drawing.Point(570, 59);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(0, 13);
            this.SearchLabel.TabIndex = 49;
            this.SearchLabel.Visible = false;
            this.SearchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(573, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 28;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(226, 309);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(80, 26);
            this.UpdateButton.TabIndex = 50;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(346, 309);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 26);
            this.DeleteButton.TabIndex = 51;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(462, 309);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(80, 26);
            this.RefreshButton.TabIndex = 52;
            this.RefreshButton.Text = "Refresh View";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TransactionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.TransactionDoneLabel);
            this.Controls.Add(this.ReturnDateDatePicker);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.HasReturnedCheckBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AccNoLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AuthorizedByField);
            this.Controls.Add(this.AccessionNoField);
            this.Controls.Add(this.BorrowersIdField);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBorrowersIdField);
            this.Controls.Add(this.SearchTransactionNoField);
            this.Name = "TransactionsUserControl";
            this.Size = new System.Drawing.Size(745, 558);
            this.Load += new System.EventHandler(this.TransactionsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTransactionNoField;
        private System.Windows.Forms.TextBox SearchBorrowersIdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BorrowersIdField;
        private System.Windows.Forms.TextBox AccessionNoField;
        private System.Windows.Forms.TextBox AuthorizedByField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AccNoLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox HasReturnedCheckBox;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker ReturnDateDatePicker;
        private System.Windows.Forms.Label TransactionDoneLabel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}
