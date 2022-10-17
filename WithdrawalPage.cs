using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankApp
{
    public partial class WithdrawalPage : UserControl
    {
        BankingPEntities1 dbe;
        MemoryStream ms;
        string withdrawalType = string.Empty;


        public WithdrawalPage()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }



        // retrieving customer account info
        private void searchButton_Click(object sender, EventArgs e)
        {
            dbe = new BankingPEntities1();
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
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

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
                    withdrawalSlipNoTxt.Text = Convert.ToString(0);
                }





                dbe = new BankingPEntities1();
                Withdrawal withdraw = new Withdrawal();

                withdraw.Account_No = Convert.ToInt32(accountNoTxt.Text);
                withdraw.Name = nameTxt.Text;
                withdraw.Phone_No = phoneNoTxt.Text;
                withdraw.Previous_Balance = Convert.ToDecimal(balanceTxt.Text);
                withdraw.Withdrawal_Amount = Convert.ToInt32(withdrawalAmountTxt.Text);
                withdraw.Cheque_Bearer = chequeBearerTxt.Text;
                withdraw.Cheque_No = chequeNoTxt.Text;
                withdraw.Withdrawal_Slip_No = Convert.ToInt32(withdrawalSlipNoTxt.Text);
                withdraw.Date_Of_Withrawal = dateLabel.Text;
                withdraw.Withdrawal_Type = withdrawalType;
                withdraw.Staff_On_Duty = staffOnDutyTxt.Text;

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




        private void withdrawalSlipRadioButton_CheckedChanged(object sender, EventArgs e)
        {

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

            withdrawalSlipNoTxt.Clear();
        }



        // clear the fields on the page
        private void clearBtn_Click(object sender, EventArgs e)
        {
            withdrawalPagePanel.BringToFront();

            WithdrawalPage withdrawpage = new WithdrawalPage();
            addUserControl(withdrawpage);
        }

        private void withdrawalPagePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
