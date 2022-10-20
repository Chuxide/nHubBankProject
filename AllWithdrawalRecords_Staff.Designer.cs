namespace BankApp
{
    partial class AllWithdrawalRecords_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllWithdrawalRecords_Staff));
            this.viewAllRecordsBtn = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.backToWithdrawalPageBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchCriteriaTxt = new System.Windows.Forms.TextBox();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.allWithdrawalRecordsPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.Serial_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previous_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdrawal_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdrawal_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Of_Withdrawal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_On_Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheque_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheque_Bearer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Withdrawal_Slip_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cheque_Bearer_Picture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.allWithdrawalRecordsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllRecordsBtn
            // 
            this.viewAllRecordsBtn.BackColor = System.Drawing.Color.Teal;
            this.viewAllRecordsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllRecordsBtn.FlatAppearance.BorderSize = 0;
            this.viewAllRecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllRecordsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllRecordsBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllRecordsBtn.Location = new System.Drawing.Point(3, 374);
            this.viewAllRecordsBtn.Name = "viewAllRecordsBtn";
            this.viewAllRecordsBtn.Size = new System.Drawing.Size(154, 23);
            this.viewAllRecordsBtn.TabIndex = 178;
            this.viewAllRecordsBtn.Text = "VIEW ALL RECORDS";
            this.viewAllRecordsBtn.UseVisualStyleBackColor = false;
            this.viewAllRecordsBtn.Click += new System.EventHandler(this.viewAllRecordsBtn_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel.Location = new System.Drawing.Point(38, 16);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 16);
            this.dateLabel.TabIndex = 65;
            this.dateLabel.Text = "label for date";
            // 
            // backToWithdrawalPageBtn
            // 
            this.backToWithdrawalPageBtn.BackColor = System.Drawing.Color.Teal;
            this.backToWithdrawalPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToWithdrawalPageBtn.FlatAppearance.BorderSize = 0;
            this.backToWithdrawalPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToWithdrawalPageBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToWithdrawalPageBtn.ForeColor = System.Drawing.Color.White;
            this.backToWithdrawalPageBtn.Location = new System.Drawing.Point(430, 374);
            this.backToWithdrawalPageBtn.Name = "backToWithdrawalPageBtn";
            this.backToWithdrawalPageBtn.Size = new System.Drawing.Size(154, 23);
            this.backToWithdrawalPageBtn.TabIndex = 178;
            this.backToWithdrawalPageBtn.Text = "BACK TO WITHDRAWAL";
            this.backToWithdrawalPageBtn.UseVisualStyleBackColor = false;
            this.backToWithdrawalPageBtn.Click += new System.EventHandler(this.backToWithdrawalPageBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 24);
            this.comboBox1.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(255, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 4);
            this.panel1.TabIndex = 106;
            // 
            // searchCriteriaTxt
            // 
            this.searchCriteriaTxt.BackColor = System.Drawing.Color.White;
            this.searchCriteriaTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchCriteriaTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCriteriaTxt.Location = new System.Drawing.Point(256, 334);
            this.searchCriteriaTxt.Name = "searchCriteriaTxt";
            this.searchCriteriaTxt.Size = new System.Drawing.Size(140, 14);
            this.searchCriteriaTxt.TabIndex = 105;
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(26, 335);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.searchErrorLabel.TabIndex = 103;
            this.searchErrorLabel.Text = "*";
            this.searchErrorLabel.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(38, 334);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 15);
            this.label23.TabIndex = 104;
            this.label23.Text = "Search by ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_No,
            this.Customer_Name,
            this.Phone_No,
            this.Previous_Balance,
            this.Withdrawal_Type,
            this.Withdrawal_Amount,
            this.Date_Of_Withdrawal,
            this.New_Balance,
            this.Staff_On_Duty,
            this.Cheque_No,
            this.Cheque_Bearer,
            this.Withdrawal_Slip_No,
            this.Cheque_Bearer_Picture});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(587, 272);
            this.dataGridView1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(183, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "WITHDRAWAL RECORDS";
            // 
            // allWithdrawalRecordsPanel
            // 
            this.allWithdrawalRecordsPanel.Controls.Add(this.viewAllRecordsBtn);
            this.allWithdrawalRecordsPanel.Controls.Add(this.backToWithdrawalPageBtn);
            this.allWithdrawalRecordsPanel.Controls.Add(this.comboBox1);
            this.allWithdrawalRecordsPanel.Controls.Add(this.searchButton);
            this.allWithdrawalRecordsPanel.Controls.Add(this.panel1);
            this.allWithdrawalRecordsPanel.Controls.Add(this.searchCriteriaTxt);
            this.allWithdrawalRecordsPanel.Controls.Add(this.searchErrorLabel);
            this.allWithdrawalRecordsPanel.Controls.Add(this.label23);
            this.allWithdrawalRecordsPanel.Controls.Add(this.dataGridView1);
            this.allWithdrawalRecordsPanel.Controls.Add(this.dateLabel);
            this.allWithdrawalRecordsPanel.Controls.Add(this.label1);
            this.allWithdrawalRecordsPanel.Location = new System.Drawing.Point(0, 0);
            this.allWithdrawalRecordsPanel.Name = "allWithdrawalRecordsPanel";
            this.allWithdrawalRecordsPanel.Size = new System.Drawing.Size(587, 401);
            this.allWithdrawalRecordsPanel.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(402, 333);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 16);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 107;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Serial_No
            // 
            this.Serial_No.DataPropertyName = "Serial_No";
            this.Serial_No.HeaderText = "Serial No";
            this.Serial_No.Name = "Serial_No";
            this.Serial_No.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 68;
            // 
            // Phone_No
            // 
            this.Phone_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Phone_No.DataPropertyName = "Phone_No";
            this.Phone_No.HeaderText = "Phone No";
            this.Phone_No.Name = "Phone_No";
            this.Phone_No.ReadOnly = true;
            this.Phone_No.Width = 89;
            // 
            // Previous_Balance
            // 
            this.Previous_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Previous_Balance.DataPropertyName = "Previous_Balance";
            this.Previous_Balance.HeaderText = "Previous Balance";
            this.Previous_Balance.Name = "Previous_Balance";
            this.Previous_Balance.ReadOnly = true;
            this.Previous_Balance.Width = 133;
            // 
            // Withdrawal_Type
            // 
            this.Withdrawal_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Withdrawal_Type.DataPropertyName = "Withdrawal_Type";
            this.Withdrawal_Type.HeaderText = "Withdrawal Type";
            this.Withdrawal_Type.Name = "Withdrawal_Type";
            this.Withdrawal_Type.ReadOnly = true;
            this.Withdrawal_Type.Width = 129;
            // 
            // Withdrawal_Amount
            // 
            this.Withdrawal_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Withdrawal_Amount.DataPropertyName = "Withdrawal_Amount";
            this.Withdrawal_Amount.HeaderText = "Withdrawal Amount";
            this.Withdrawal_Amount.Name = "Withdrawal_Amount";
            this.Withdrawal_Amount.ReadOnly = true;
            this.Withdrawal_Amount.Width = 145;
            // 
            // Date_Of_Withdrawal
            // 
            this.Date_Of_Withdrawal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Date_Of_Withdrawal.DataPropertyName = "Date_Of_Withdrawal";
            this.Date_Of_Withdrawal.HeaderText = "Date Of Withdrawal";
            this.Date_Of_Withdrawal.Name = "Date_Of_Withdrawal";
            this.Date_Of_Withdrawal.ReadOnly = true;
            this.Date_Of_Withdrawal.Width = 143;
            // 
            // New_Balance
            // 
            this.New_Balance.DataPropertyName = "New_Balance";
            this.New_Balance.HeaderText = "New Balance";
            this.New_Balance.Name = "New_Balance";
            this.New_Balance.ReadOnly = true;
            // 
            // Staff_On_Duty
            // 
            this.Staff_On_Duty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Staff_On_Duty.DataPropertyName = "Staff_On_Duty";
            this.Staff_On_Duty.HeaderText = "Staff On Duty";
            this.Staff_On_Duty.Name = "Staff_On_Duty";
            this.Staff_On_Duty.ReadOnly = true;
            this.Staff_On_Duty.Width = 103;
            // 
            // Cheque_No
            // 
            this.Cheque_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cheque_No.DataPropertyName = "Cheque_No";
            this.Cheque_No.HeaderText = "Cheque_No";
            this.Cheque_No.Name = "Cheque_No";
            this.Cheque_No.ReadOnly = true;
            this.Cheque_No.Width = 102;
            // 
            // Cheque_Bearer
            // 
            this.Cheque_Bearer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cheque_Bearer.DataPropertyName = "Cheque_Bearer";
            this.Cheque_Bearer.HeaderText = "Cheque Bearer";
            this.Cheque_Bearer.Name = "Cheque_Bearer";
            this.Cheque_Bearer.ReadOnly = true;
            this.Cheque_Bearer.Width = 121;
            // 
            // Withdrawal_Slip_No
            // 
            this.Withdrawal_Slip_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Withdrawal_Slip_No.DataPropertyName = "Withdrawal_Slip_No";
            this.Withdrawal_Slip_No.HeaderText = "Withdrawal Slip No";
            this.Withdrawal_Slip_No.Name = "Withdrawal_Slip_No";
            this.Withdrawal_Slip_No.ReadOnly = true;
            this.Withdrawal_Slip_No.Width = 140;
            // 
            // Cheque_Bearer_Picture
            // 
            this.Cheque_Bearer_Picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cheque_Bearer_Picture.DataPropertyName = "Cheque_Bearer_Picture";
            this.Cheque_Bearer_Picture.HeaderText = "Cheque Bearer Picture";
            this.Cheque_Bearer_Picture.Name = "Cheque_Bearer_Picture";
            this.Cheque_Bearer_Picture.ReadOnly = true;
            this.Cheque_Bearer_Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cheque_Bearer_Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cheque_Bearer_Picture.Width = 164;
            // 
            // AllWithdrawalRecords_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.allWithdrawalRecordsPanel);
            this.Name = "AllWithdrawalRecords_Staff";
            this.Size = new System.Drawing.Size(587, 401);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.allWithdrawalRecordsPanel.ResumeLayout(false);
            this.allWithdrawalRecordsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewAllRecordsBtn;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button backToWithdrawalPageBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchCriteriaTxt;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel allWithdrawalRecordsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previous_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdrawal_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdrawal_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Of_Withdrawal;
        private System.Windows.Forms.DataGridViewTextBoxColumn New_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_On_Duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cheque_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cheque_Bearer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Withdrawal_Slip_No;
        private System.Windows.Forms.DataGridViewImageColumn Cheque_Bearer_Picture;
    }
}
