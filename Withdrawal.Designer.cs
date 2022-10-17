﻿using System.Windows.Forms;

namespace BankApp
{
    partial class Withdrawal : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdrawal));
            this.withdrawalPanel = new System.Windows.Forms.Panel();
            this.slipRadioButton = new System.Windows.Forms.RadioButton();
            this.chequeRadioButton = new System.Windows.Forms.RadioButton();
            this.viewWithdrawalRecordsBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.withdrawalBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchAccountNoTxt = new System.Windows.Forms.TextBox();
            this.staffOnDutyTxt = new System.Windows.Forms.TextBox();
            this.chequeNoTxt = new System.Windows.Forms.TextBox();
            this.depositAmountTxt = new System.Windows.Forms.TextBox();
            this.phoneNoTxt = new System.Windows.Forms.TextBox();
            this.accountNoTxt = new System.Windows.Forms.TextBox();
            this.balanceTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.errorChequeNoLabel = new System.Windows.Forms.Label();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chequeNoLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chequeBearerNameLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chequeBearerNameTxt = new System.Windows.Forms.TextBox();
            this.withdrawalSlipNoLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.withdrawalSlipNoTxt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.withdrawalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawalPanel
            // 
            this.withdrawalPanel.Controls.Add(this.slipRadioButton);
            this.withdrawalPanel.Controls.Add(this.chequeRadioButton);
            this.withdrawalPanel.Controls.Add(this.viewWithdrawalRecordsBtn);
            this.withdrawalPanel.Controls.Add(this.uploadBtn);
            this.withdrawalPanel.Controls.Add(this.clearBtn);
            this.withdrawalPanel.Controls.Add(this.withdrawalBtn);
            this.withdrawalPanel.Controls.Add(this.label5);
            this.withdrawalPanel.Controls.Add(this.pictureBox2);
            this.withdrawalPanel.Controls.Add(this.pictureBox1);
            this.withdrawalPanel.Controls.Add(this.searchButton);
            this.withdrawalPanel.Controls.Add(this.panel1);
            this.withdrawalPanel.Controls.Add(this.searchAccountNoTxt);
            this.withdrawalPanel.Controls.Add(this.staffOnDutyTxt);
            this.withdrawalPanel.Controls.Add(this.withdrawalSlipNoTxt);
            this.withdrawalPanel.Controls.Add(this.chequeBearerNameTxt);
            this.withdrawalPanel.Controls.Add(this.chequeNoTxt);
            this.withdrawalPanel.Controls.Add(this.depositAmountTxt);
            this.withdrawalPanel.Controls.Add(this.phoneNoTxt);
            this.withdrawalPanel.Controls.Add(this.accountNoTxt);
            this.withdrawalPanel.Controls.Add(this.balanceTxt);
            this.withdrawalPanel.Controls.Add(this.nameTxt);
            this.withdrawalPanel.Controls.Add(this.label13);
            this.withdrawalPanel.Controls.Add(this.label12);
            this.withdrawalPanel.Controls.Add(this.errorChequeNoLabel);
            this.withdrawalPanel.Controls.Add(this.searchErrorLabel);
            this.withdrawalPanel.Controls.Add(this.dateLabel);
            this.withdrawalPanel.Controls.Add(this.label23);
            this.withdrawalPanel.Controls.Add(this.label4);
            this.withdrawalPanel.Controls.Add(this.withdrawalSlipNoLabel);
            this.withdrawalPanel.Controls.Add(this.chequeBearerNameLabel);
            this.withdrawalPanel.Controls.Add(this.chequeNoLabel);
            this.withdrawalPanel.Controls.Add(this.label7);
            this.withdrawalPanel.Controls.Add(this.label8);
            this.withdrawalPanel.Controls.Add(this.label10);
            this.withdrawalPanel.Controls.Add(this.label6);
            this.withdrawalPanel.Controls.Add(this.label2);
            this.withdrawalPanel.Controls.Add(this.label9);
            this.withdrawalPanel.Controls.Add(this.label3);
            this.withdrawalPanel.Controls.Add(this.label1);
            this.withdrawalPanel.Location = new System.Drawing.Point(0, 0);
            this.withdrawalPanel.Name = "withdrawalPanel";
            this.withdrawalPanel.Size = new System.Drawing.Size(587, 401);
            this.withdrawalPanel.TabIndex = 0;
          //  this.withdrawalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.withdrawalPanel_Paint);
            // 
            // slipRadioButton
            // 
            this.slipRadioButton.AutoSize = true;
            this.slipRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slipRadioButton.Location = new System.Drawing.Point(118, 248);
            this.slipRadioButton.Name = "slipRadioButton";
            this.slipRadioButton.Size = new System.Drawing.Size(109, 20);
            this.slipRadioButton.TabIndex = 144;
            this.slipRadioButton.TabStop = true;
            this.slipRadioButton.Text = "Withdrawal Slip";
            this.slipRadioButton.UseVisualStyleBackColor = true;
            // 
            // chequeRadioButton
            // 
            this.chequeRadioButton.AutoSize = true;
            this.chequeRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeRadioButton.Location = new System.Drawing.Point(239, 248);
            this.chequeRadioButton.Name = "chequeRadioButton";
            this.chequeRadioButton.Size = new System.Drawing.Size(70, 20);
            this.chequeRadioButton.TabIndex = 145;
            this.chequeRadioButton.TabStop = true;
            this.chequeRadioButton.Text = "Cheque";
            this.chequeRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewWithdrawalRecordsBtn
            // 
            this.viewWithdrawalRecordsBtn.BackColor = System.Drawing.Color.SlateGray;
            this.viewWithdrawalRecordsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewWithdrawalRecordsBtn.FlatAppearance.BorderSize = 0;
            this.viewWithdrawalRecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewWithdrawalRecordsBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWithdrawalRecordsBtn.ForeColor = System.Drawing.Color.White;
            this.viewWithdrawalRecordsBtn.Location = new System.Drawing.Point(373, 369);
            this.viewWithdrawalRecordsBtn.Name = "viewWithdrawalRecordsBtn";
            this.viewWithdrawalRecordsBtn.Size = new System.Drawing.Size(153, 23);
            this.viewWithdrawalRecordsBtn.TabIndex = 177;
            this.viewWithdrawalRecordsBtn.Text = "WITHDRAWAL RECORDS";
            this.viewWithdrawalRecordsBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.SlateGray;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(237, 369);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(118, 23);
            this.clearBtn.TabIndex = 178;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // withdrawalBtn
            // 
            this.withdrawalBtn.BackColor = System.Drawing.Color.SlateGray;
            this.withdrawalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrawalBtn.FlatAppearance.BorderSize = 0;
            this.withdrawalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawalBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalBtn.ForeColor = System.Drawing.Color.White;
            this.withdrawalBtn.Location = new System.Drawing.Point(65, 369);
            this.withdrawalBtn.Name = "withdrawalBtn";
            this.withdrawalBtn.Size = new System.Drawing.Size(153, 23);
            this.withdrawalBtn.TabIndex = 176;
            this.withdrawalBtn.Text = "MAKE WITHDRAWAL";
            this.withdrawalBtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 175;
            this.label5.Text = "Withdrawal Type: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankApp.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(271, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(381, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(20, 16);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchButton.TabIndex = 173;
            this.searchButton.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(286, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 3);
            this.panel1.TabIndex = 172;
            // 
            // searchAccountNoTxt
            // 
            this.searchAccountNoTxt.BackColor = System.Drawing.Color.White;
            this.searchAccountNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchAccountNoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAccountNoTxt.Location = new System.Drawing.Point(288, 40);
            this.searchAccountNoTxt.Name = "searchAccountNoTxt";
            this.searchAccountNoTxt.Size = new System.Drawing.Size(87, 14);
            this.searchAccountNoTxt.TabIndex = 162;
            // 
            // staffOnDutyTxt
            // 
            this.staffOnDutyTxt.BackColor = System.Drawing.Color.White;
            this.staffOnDutyTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffOnDutyTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffOnDutyTxt.Location = new System.Drawing.Point(100, 332);
            this.staffOnDutyTxt.Name = "staffOnDutyTxt";
            this.staffOnDutyTxt.ReadOnly = true;
            this.staffOnDutyTxt.Size = new System.Drawing.Size(178, 14);
            this.staffOnDutyTxt.TabIndex = 168;
            // 
            // chequeNoTxt
            // 
            this.chequeNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chequeNoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNoTxt.Location = new System.Drawing.Point(415, 249);
            this.chequeNoTxt.Name = "chequeNoTxt";
            this.chequeNoTxt.Size = new System.Drawing.Size(141, 14);
            this.chequeNoTxt.TabIndex = 167;
            this.chequeNoTxt.Visible = false;
            // 
            // depositAmountTxt
            // 
            this.depositAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.depositAmountTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountTxt.Location = new System.Drawing.Point(135, 282);
            this.depositAmountTxt.Name = "depositAmountTxt";
            this.depositAmountTxt.Size = new System.Drawing.Size(178, 14);
            this.depositAmountTxt.TabIndex = 163;
            // 
            // phoneNoTxt
            // 
            this.phoneNoTxt.BackColor = System.Drawing.Color.White;
            this.phoneNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoTxt.Location = new System.Drawing.Point(93, 126);
            this.phoneNoTxt.Name = "phoneNoTxt";
            this.phoneNoTxt.ReadOnly = true;
            this.phoneNoTxt.Size = new System.Drawing.Size(161, 14);
            this.phoneNoTxt.TabIndex = 164;
            // 
            // accountNoTxt
            // 
            this.accountNoTxt.BackColor = System.Drawing.Color.White;
            this.accountNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountNoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNoTxt.Location = new System.Drawing.Point(93, 172);
            this.accountNoTxt.Name = "accountNoTxt";
            this.accountNoTxt.ReadOnly = true;
            this.accountNoTxt.Size = new System.Drawing.Size(161, 14);
            this.accountNoTxt.TabIndex = 169;
            // 
            // balanceTxt
            // 
            this.balanceTxt.BackColor = System.Drawing.Color.White;
            this.balanceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balanceTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTxt.Location = new System.Drawing.Point(93, 149);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.ReadOnly = true;
            this.balanceTxt.Size = new System.Drawing.Size(161, 14);
            this.balanceTxt.TabIndex = 170;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(92, 103);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(161, 14);
            this.nameTxt.TabIndex = 171;
            // 
            // errorChequeNoLabel
            // 
            this.errorChequeNoLabel.AutoSize = true;
            this.errorChequeNoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorChequeNoLabel.ForeColor = System.Drawing.Color.Red;
            this.errorChequeNoLabel.Location = new System.Drawing.Point(326, 252);
            this.errorChequeNoLabel.Name = "errorChequeNoLabel";
            this.errorChequeNoLabel.Size = new System.Drawing.Size(12, 15);
            this.errorChequeNoLabel.TabIndex = 148;
            this.errorChequeNoLabel.Text = "*";
            this.errorChequeNoLabel.Visible = false;
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(170, 41);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.searchErrorLabel.TabIndex = 147;
            this.searchErrorLabel.Text = "*";
            this.searchErrorLabel.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel.Location = new System.Drawing.Point(28, 15);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(80, 16);
            this.dateLabel.TabIndex = 149;
            this.dateLabel.Text = "label for date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(182, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 15);
            this.label23.TabIndex = 150;
            this.label23.Text = "Enter Account No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 156;
            this.label4.Text = "Staff On Duty:";
            // 
            // chequeNoLabel
            // 
            this.chequeNoLabel.AutoSize = true;
            this.chequeNoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeNoLabel.Location = new System.Drawing.Point(336, 249);
            this.chequeNoLabel.Name = "chequeNoLabel";
            this.chequeNoLabel.Size = new System.Drawing.Size(73, 16);
            this.chequeNoLabel.TabIndex = 155;
            this.chequeNoLabel.Text = "Cheque No:";
            this.chequeNoLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 158;
            this.label7.Text = "Withdrawal Amount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 154;
            this.label8.Text = "Phone No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 153;
            this.label10.Text = "Account No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 152;
            this.label6.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 160;
            this.label2.Text = "TRANSACTION INFORMATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 15);
            this.label9.TabIndex = 159;
            this.label9.Text = "ACCOUNT INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 161;
            this.label3.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 146;
            this.label1.Text = "WITHDRAWAL FORM";
            // 
            // chequeBearerNameLabel
            // 
            this.chequeBearerNameLabel.AutoSize = true;
            this.chequeBearerNameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeBearerNameLabel.Location = new System.Drawing.Point(336, 280);
            this.chequeBearerNameLabel.Name = "chequeBearerNameLabel";
            this.chequeBearerNameLabel.Size = new System.Drawing.Size(92, 16);
            this.chequeBearerNameLabel.TabIndex = 155;
            this.chequeBearerNameLabel.Text = "Cheque Bearer:";
            this.chequeBearerNameLabel.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(326, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 15);
            this.label12.TabIndex = 148;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // chequeBearerNameTxt
            // 
            this.chequeBearerNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chequeBearerNameTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chequeBearerNameTxt.Location = new System.Drawing.Point(434, 280);
            this.chequeBearerNameTxt.Name = "chequeBearerNameTxt";
            this.chequeBearerNameTxt.Size = new System.Drawing.Size(122, 14);
            this.chequeBearerNameTxt.TabIndex = 167;
            this.chequeBearerNameTxt.Visible = false;
            // 
            // withdrawalSlipNoLabel
            // 
            this.withdrawalSlipNoLabel.AutoSize = true;
            this.withdrawalSlipNoLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalSlipNoLabel.Location = new System.Drawing.Point(336, 330);
            this.withdrawalSlipNoLabel.Name = "withdrawalSlipNoLabel";
            this.withdrawalSlipNoLabel.Size = new System.Drawing.Size(112, 16);
            this.withdrawalSlipNoLabel.TabIndex = 155;
            this.withdrawalSlipNoLabel.Text = "Withdrawal Slip No:";
            this.withdrawalSlipNoLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(326, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 15);
            this.label13.TabIndex = 148;
            this.label13.Text = "*";
            this.label13.Visible = false;
            // 
            // withdrawalSlipNoTxt
            // 
            this.withdrawalSlipNoTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.withdrawalSlipNoTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalSlipNoTxt.Location = new System.Drawing.Point(454, 330);
            this.withdrawalSlipNoTxt.Name = "withdrawalSlipNoTxt";
            this.withdrawalSlipNoTxt.Size = new System.Drawing.Size(102, 14);
            this.withdrawalSlipNoTxt.TabIndex = 167;
            this.withdrawalSlipNoTxt.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankApp.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(415, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 174;
            this.pictureBox2.TabStop = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.SlateGray;
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(415, 193);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(118, 23);
            this.uploadBtn.TabIndex = 178;
            this.uploadBtn.Text = "UPLOAD";
            this.uploadBtn.UseVisualStyleBackColor = false;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.withdrawalPanel);
            this.Name = "Withdrawal";
            this.Size = new System.Drawing.Size(587, 401);
            this.withdrawalPanel.ResumeLayout(false);
            this.withdrawalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel withdrawalPanel;
        private System.Windows.Forms.RadioButton slipRadioButton;
        private System.Windows.Forms.RadioButton chequeRadioButton;
        private System.Windows.Forms.Button viewWithdrawalRecordsBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button withdrawalBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchAccountNoTxt;
        private System.Windows.Forms.TextBox staffOnDutyTxt;
        private System.Windows.Forms.TextBox chequeNoTxt;
        private System.Windows.Forms.TextBox depositAmountTxt;
        private System.Windows.Forms.TextBox phoneNoTxt;
        private System.Windows.Forms.TextBox accountNoTxt;
        private System.Windows.Forms.TextBox balanceTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label errorChequeNoLabel;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chequeNoLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chequeBearerNameTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label chequeBearerNameLabel;
        private System.Windows.Forms.TextBox withdrawalSlipNoTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label withdrawalSlipNoLabel;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
