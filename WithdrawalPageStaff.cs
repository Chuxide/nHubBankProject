using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankApp
{
    public partial class WithdrawalPageStaff : UserControl
    {
        BankingPEntities5 dbe;
        MemoryStream ms;
        string withdrawalType = string.Empty;


        public WithdrawalPageStaff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            staffOnDutyTxt.Text = CoStaffLogin.instance.getStaffId.Text;
        }




        // retrieving customer account info
        private void searchButton_Click(object sender, EventArgs e)
        {
            dbe = new BankingPEntities5();
            int accountNoSearch = Convert.ToInt32(searchAccountNoTxt.Text);
            var item = dbe.customerAccounts.Where(a => a.Account_No == accountNoSearch).FirstOrDefault();
            if (item == null)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("Invalid or unregistered account number.");
            }
            else
            {
                nameTxt.Text = item.First_Name + " " + item.Last_Name;
                phoneNoTxt.Text = item.Phone_No;

                balanceTxt.Text = item.Balance.ToString();

                accountNoTxt.Text = item.Account_No.ToString();




                byte[] img = item.Picture;
                MemoryStream ms1 = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms1);

            }
        }




        // withdraw amount and save details of transaction
        private void withdrawalBtn_Click(object sender, EventArgs e)
        {
            if (accountNoTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No account number has been entered.");
            }

            else if (withdrawalAmountTxt.Text.Length == 0)
            {
                MessageBox.Show("Please enter withdrawal amount.");
            }
            else if (withdrawalSlipRadioButton.Checked == false && chequeRadioButton.Checked == false)
            {
                MessageBox.Show("Please choose a withdrawal type.");
            }
            else if (chequeRadioButton.Checked == true && chequeNoTxt.Text.Length == 0)
            {
                MessageBox.Show("Please enter the cheque number.");
            }
            else if (chequeRadioButton.Checked == true && chequeBearerTxt.Text.Length == 0)
            {
                MessageBox.Show("Please enter the cheque bearer's name.");
            }
            else if (withdrawalSlipRadioButton.Checked == true && withdrawalSlipNoTxt.Text.Length == 0)
            {
                MessageBox.Show("Please enter the withdrawal slip number.");
            }
            else if (chequeRadioButton.Checked == true && ms == null)
            {
                errorUpload.Visible = true;
                MessageBox.Show("Please upload a picture for the cheque bearer.");
            }
            else if (Convert.ToInt32(withdrawalAmountTxt.Text) > Convert.ToDecimal(balanceTxt.Text))
            {
                MessageBox.Show("Insufficient balance to perform this transaction.");

            }


            else
            {
                if (withdrawalSlipRadioButton.Checked)
                {
                    withdrawalType = "Withdrawal Slip";
                    chequeNoTxt.Text = "NIL";
                    chequeBearerTxt.Text = "NIL";
                }
                else if (chequeRadioButton.Checked)
                {
                    withdrawalType = "Cheque";
                    withdrawalSlipNoTxt.Text = "NIL";

                }





                dbe = new BankingPEntities5();
                Withdrawal withdraw = new Withdrawal();

                withdraw.Account_No = Convert.ToInt32(accountNoTxt.Text);
                withdraw.Customer_Name = nameTxt.Text;
                withdraw.Phone_No = phoneNoTxt.Text;
                withdraw.Previous_Balance = Convert.ToDecimal(balanceTxt.Text);
                withdraw.Withdrawal_Amount = Convert.ToInt32(withdrawalAmountTxt.Text);
                withdraw.Cheque_Bearer = chequeBearerTxt.Text;
                withdraw.Cheque_No = chequeNoTxt.Text;
                withdraw.Withdrawal_Slip_No = withdrawalSlipNoTxt.Text;
                withdraw.Date_Of_Withdrawal = dateLabel.Text;
                withdraw.Withdrawal_Type = withdrawalType;
                withdraw.Staff_On_Duty = staffOnDutyTxt.Text;
                withdraw.New_Balance = Convert.ToDecimal(balanceTxt.Text) - Convert.ToInt32(withdrawalAmountTxt.Text);


                if (withdrawalSlipRadioButton.Checked)
                {
                    withdraw.Cheque_Bearer_Picture = null;
                }
                else if (chequeRadioButton.Checked)
                {
                    withdraw.Cheque_Bearer_Picture = ms.ToArray();
                }
                


                dbe.Withdrawals.Add(withdraw);
                dbe.SaveChanges();



                int b = Convert.ToInt32(accountNoTxt.Text);
                var item = (from u in dbe.customerAccounts
                            where u.Account_No == b
                            select u).FirstOrDefault();
                item.Balance = item.Balance - Convert.ToDecimal(withdrawalAmountTxt.Text);
                dbe.SaveChanges();



                withdrawalPagePanel.BringToFront();

                TransactionsPage transactionspage = new TransactionsPage();
                addUserControl(transactionspage);

                MessageBox.Show("The withdrawal of N" + withdrawalAmountTxt.Text + " on account number: " + accountNoTxt.Text + " was successful!");

            }
        }


        // user control function
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            withdrawalPagePanel.Controls.Clear();
            withdrawalPagePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void withdrawalSlipRadioButton_Click(object sender, EventArgs e)
        {
            chequeBearerTxt.Visible = false;
            errorChequeBearerLabel.Visible = false;
            chequeBearerLabel.Visible = false;

            chequeNoTxt.Visible = false;
            chequeNoLabel.Visible = false;
            errorChequeNoLabel.Visible = false;

            withdrawalSlipNoTxt.Visible = true;
            errorwithdrawalSlipNoLabel.Visible = true;
            withdrawalSlipNoLabel.Visible = true;

            pictureBox2.Visible = false;
            uploadBtn.Visible = false;

            chequeBearerTxt.Clear();
            chequeNoTxt.Clear();
        }

        private void chequeRadioButton_Click(object sender, EventArgs e)
        {
            chequeBearerTxt.Visible = true;
            errorChequeBearerLabel.Visible = true;
            chequeBearerLabel.Visible = true;

            chequeNoTxt.Visible = true;
            chequeNoLabel.Visible = true;
            errorChequeNoLabel.Visible = true;

            withdrawalSlipNoTxt.Visible = false;
            errorwithdrawalSlipNoLabel.Visible = false;
            withdrawalSlipNoLabel.Visible = false;

            pictureBox2.Visible = true;
            uploadBtn.Visible = true;

            withdrawalSlipNoTxt.Clear();
        }



        // clear the fields on the page
        private void clearBtn_Click(object sender, EventArgs e)
        {
            withdrawalPagePanel.BringToFront();

            WithdrawalPageStaff withdrawpage = new WithdrawalPageStaff();
            addUserControl(withdrawpage);
        }

        private void chequeNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void withdrawalSlipNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchAccountNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                Image img = Image.FromFile(openDialog.FileName);
                pictureBox2.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void viewWithdrawalRecordsBtn_Click(object sender, EventArgs e)
        {
            withdrawalPagePanel.BringToFront();

            AllWithdrawalRecords_Staff withdrawpage = new AllWithdrawalRecords_Staff();
            addUserControl(withdrawpage);
        }
    }
}
