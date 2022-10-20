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
    public partial class AllCustomers_Staff : UserControl
    {

        BankingPEntities5 dme;
        BindingList<customerAccount> mi;
        public AllCustomers_Staff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            bindgrid();
            loadSearchCriteria();
        }

        private void bindgrid()
        {
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.customerAccounts.ToList();
            dataGridView1.DataSource = item;

            // throw new NotImplementedException();
        }

        private void loadSearchCriteria()
        {
            comboBox1.Items.Add("Account No");
            comboBox1.Items.Add("First Name");
            comboBox1.Items.Add("Last Name");
            comboBox1.Items.Add("Date Of Registration");

        }

        // search customer using crtiteria
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
                mi = new BindingList<customerAccount>();
                if (comboBox1.SelectedIndex == 0)
                {
                    try
                    {
                        int accountNoSearch = Convert.ToInt32(searchCriteriaTxt.Text);
                        var item = dme.customerAccounts.Where(a => a.Account_No == accountNoSearch);
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
                    string firstNameSearch = searchCriteriaTxt.Text;
                    var item = dme.customerAccounts.Where(a => a.First_Name == firstNameSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Unregistered first name.");
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
                    string lastNameSearch = searchCriteriaTxt.Text;
                    var item = dme.customerAccounts.Where(a => a.Last_Name == lastNameSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Unregistered last name.");
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
                    string dateofregistrationSearch = searchCriteriaTxt.Text;
                    var item = dme.customerAccounts.Where(a => a.Date_Of_Registration == dateofregistrationSearch);
                    if (item == null)
                    {
                        searchErrorLabel.Visible = true;
                        MessageBox.Show("Invalid date of registration. Date should be in format: 'day(numeric) month(full spelling) year(numeric)'.");
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

    }
}
