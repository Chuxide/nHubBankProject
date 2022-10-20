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
    public partial class AllDepositRecords_Staff : UserControl
    {
        BankingPEntities5 dme;
        BindingList<Deposit> mi;
        public AllDepositRecords_Staff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            bindgrid();
            loadSearchCriteria();
        }

        private void bindgrid()
        {
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.Deposits.ToList();
            dataGridView1.DataSource = item;

            // throw new NotImplementedException();
        }

        private void loadSearchCriteria()
        {
            comboBox1.Items.Add("Account No");
            comboBox1.Items.Add("Customer Name");
            comboBox1.Items.Add("Deposit Type");
            comboBox1.Items.Add("Date Of Deposit");
            comboBox1.Items.Add("Staff On Duty");
            comboBox1.Items.Add("Cheque No");
            comboBox1.Items.Add("Depositor Name");
        }

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
                mi = new BindingList<Deposit>();
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        int accountNoSearch = Convert.ToInt32(searchCriteriaTxt.Text);
                        var item = dme.Deposits.Where(a => a.Account_No == accountNoSearch);
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
                    var item = dme.Deposits.Where(a => a.Name == customerNameSearch);
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
                    string depositTypeSearch = searchCriteriaTxt.Text;
                    var item = dme.Deposits.Where(a => a.Deposit_Type == depositTypeSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid deposit type. Deposit Type is either 'Cheque' or 'Cash'.");
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
                    string dateofdepositSearch = searchCriteriaTxt.Text;
                    var item = dme.Deposits.Where(a => a.Date_Of_Deposit == dateofdepositSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid date of depsoit. Date should be in format: 'day(numeric) month(full spelling) year(numeric)'.");
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
                    var item = dme.Deposits.Where(a => a.Staff_On_Duty == staffondutySearch);
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
                    var item = dme.Deposits.Where(a => a.Cheque_No == chequenoSearch);
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
                    string depositornameSearch = searchCriteriaTxt.Text;
                    var item = dme.Deposits.Where(a => a.Depositor_Name == depositornameSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("There are no records with this depositor name.");
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
            allDepositRecordsPanel.Controls.Clear();
            allDepositRecordsPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void backToDepositPageBtn_Click(object sender, EventArgs e)
        {
            allDepositRecordsPanel.BringToFront();

            DepositPageStaff depositpage = new DepositPageStaff();
            addUserControl(depositpage);
        }

        private void viewAllRecordsBtn_Click(object sender, EventArgs e)
        {
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.Deposits.ToList();
            dataGridView1.DataSource = item;
        }
    }
}
