using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class AllWithdrawalRecords : UserControl
    {
        BankingPEntities5 dme;
        BindingList<Withdrawal> mi;
        public AllWithdrawalRecords()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            bindgrid();
            loadSearchCriteria();
        }


        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.Withdrawals.ToList();
            dataGridView1.DataSource = item;

            // throw new NotImplementedException();
        }

        private void loadSearchCriteria()
        {
            comboBox1.Items.Add("Account No");
            comboBox1.Items.Add("Customer Name");
            comboBox1.Items.Add("Withdrawal Type");
            comboBox1.Items.Add("Date Of Withdrawal");
            comboBox1.Items.Add("Staff On Duty");
            comboBox1.Items.Add("Cheque No");
            comboBox1.Items.Add("Cheque Bearer");
            comboBox1.Items.Add("Withdrawal Slip No");
        }



        // search withdrawal records by criteria
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("Please choose a search criteria.");
            }
            else if (searchCriteriaTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("Please enter a value for the search.");
            }

            else
            {
                dme = new BankingPEntities5();
                mi = new BindingList<Withdrawal>();
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {

                        int accountNoSearch = Convert.ToInt32(searchCriteriaTxt.Text);
                        var item = dme.Withdrawals.Where(a => a.Account_No == accountNoSearch);
                        if (item == null)
                        {
                            searchErrorLabel.Visible = true;
                            MessageBox.Show("Unregistered account number.");
                        }
                        else
                        {
                            foreach (var item2 in item)
                            {
                                mi.Add(item2);
                            }
                            dataGridView1.DataSource = mi;
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Invalid account number. Please enter only numeric values.");
                    }
                }

              
                else if (comboBox1.SelectedIndex == 1)
                {
                    string customerNameSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Customer_Name == customerNameSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid or unregistered customer name.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 2)
                {
                    string withdrawalTypeSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Withdrawal_Type == withdrawalTypeSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid withdrawal type. Withdrawal Type is either 'Cheque' or 'Withdrawal Slip'.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 3)
                {
                    string dateofwithdrawalSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Date_Of_Withdrawal == dateofwithdrawalSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid date of withdrawal. Date should be in format: 'day(numeric) month(full spelling) year(numeric)'.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 4)
                {
                    string staffondutySearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Staff_On_Duty == staffondutySearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid or unregistered staff id.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 5)
                {
                    string chequenoSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Cheque_No == chequenoSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid cheque no.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 6)
                {
                    string chequebearerSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Cheque_Bearer == chequebearerSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("There are no records with this cheque bearer name.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }

                else if (comboBox1.SelectedIndex == 7)
                {
                    string withdrawalslipnoSearch = searchCriteriaTxt.Text;
                    var item = dme.Withdrawals.Where(a => a.Withdrawal_Slip_No == withdrawalslipnoSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("There are no records with this withdrawal slip number.");
                    }
                    else
                    {
                        foreach (var item2 in item)
                        {
                            mi.Add(item2);
                        }
                        dataGridView1.DataSource = mi;
                    }
                }



            }
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            allWithdrawalRecordsPanel.Controls.Clear();
            allWithdrawalRecordsPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void backToWithdrawalPageBtn_Click(object sender, EventArgs e)
        {
            allWithdrawalRecordsPanel.BringToFront();

            WithdrawalPage withdrawpage = new WithdrawalPage();
            addUserControl(withdrawpage);
        }

        private void viewAllRecordsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.Withdrawals.ToList();
            dataGridView1.DataSource = item;
        }
    }
}
