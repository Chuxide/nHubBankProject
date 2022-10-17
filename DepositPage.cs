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
    public partial class DepositPage : UserControl
    {

        BankingPEntities1 dbe;
        MemoryStream ms;
        string depositType = string.Empty;

        public DepositPage()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            staffOnDutyTxt.Text = CoAdminLogin.instance.getAdminId.Text;
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
                genderTxt.Text = item.Gender;

                balanceTxt.Text = item.Balance.ToString();

                accountNoTxt.Text = item.Account_No.ToString();



                byte[] img = item.Picture;
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

            }

        }



        // deposit amount and save details of transaction
        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (accountNoTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No account number has been entered.");
            }

            else if (depositAmountTxt.Text.Length == 0 || depositorNameTxt.Text.Length == 0 ||
               depositorPhoneNoTxt.Text.Length == 0)
            {
                MessageBox.Show("One or more required fields have not been filled.");
            }
            else if (cashRadioButton.Checked == false && chequeRadioButton.Checked == false)
            {
                MessageBox.Show("Please choose a deposit type.");
            }
            else if (chequeRadioButton.Checked == true && chequeNoTxt.Text.Length == 0)
            {
                MessageBox.Show("Please enter the cheque number.");
            }


            else
            {
                if (cashRadioButton.Checked)
                {
                    depositType = "Cash";
                    chequeNoTxt.Text = "NIL";
                }
                else if (chequeRadioButton.Checked)
                {
                    depositType = "Cheque";
                }

                
                


                dbe = new BankingPEntities1();
                Deposit deposit = new Deposit();

                deposit.Account_No = Convert.ToInt32(accountNoTxt.Text);
                deposit.Name = nameTxt.Text;
                deposit.Gender = genderTxt.Text;
                deposit.Previous_Balance = Convert.ToDecimal(balanceTxt.Text);
                deposit.Depositor_Name = depositorNameTxt.Text;
                deposit.Depositor_Phone_No = depositorPhoneNoTxt.Text;
                deposit.Cheque_No = chequeNoTxt.Text;
                deposit.Deposit_Amount = Convert.ToDecimal(depositAmountTxt.Text);
                deposit.Date_Of_Deposit = dateLabel.Text;
                deposit.Deposit_Type = depositType;
                deposit.Staff_On_Duty = staffOnDutyTxt.Text;

                dbe.Deposits.Add(deposit);
                dbe.SaveChanges();

                int b = Convert.ToInt32(accountNoTxt.Text);
                var item = (from u in dbe.customerAccounts
                            where u.Account_No == b
                            select u).FirstOrDefault();
                item.Balance = item.Balance + Convert.ToDecimal(depositAmountTxt.Text);
                dbe.SaveChanges();



                depositPanel.BringToFront();

                TransactionsPage transactionspage = new TransactionsPage();
                addUserControl(transactionspage);

                MessageBox.Show("The deposit of N" + depositAmountTxt.Text + " on account number: " + accountNoTxt.Text + " was successful!");

            }
        }

    

        // user control function
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            depositPanel.Controls.Clear();
            depositPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void depositPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void chequeRadioButton_Click(object sender, EventArgs e)
        {
            errorChequeNoLabel.Visible = true;
            chequeNoLabel.Visible = true;
            chequeNoTxt.Visible = true;
        }

        private void cashRadioButton_Click(object sender, EventArgs e)
        {
            chequeNoTxt.Clear();
            errorChequeNoLabel.Visible = false;
            chequeNoLabel.Visible = false;
            chequeNoTxt.Visible = false;
        }



        // clear all fields on the page
        private void clearBtn_Click(object sender, EventArgs e)
        {
            depositPanel.BringToFront();

            DepositPage depositpage = new DepositPage();
            addUserControl(depositpage);
        }



        // navigate to deposit records page
        private void viewDepositRecordsBtn_Click(object sender, EventArgs e)
        {
            depositPanel.BringToFront();

            AllDepositRecords depositrecordspage = new AllDepositRecords();
            addUserControl(depositrecordspage);
        }
    }
}
