using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankApp
{
    public partial class BalanceSheet : UserControl
    {
        BankingPEntities5 dme;
        BindingList<Withdrawal> mi;
        BindingList<Deposit> mi2;
        public BalanceSheet()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dme = new BankingPEntities5();
            mi = new BindingList<Withdrawal>();
            mi2 = new BindingList<Deposit>();
            try
            {

                int accountNoSearch = Convert.ToInt32(searchAccountNoTxt.Text);
                var item = dme.Withdrawals.Where(a => a.Account_No == accountNoSearch);
                var item1 = dme.Deposits.Where(a => a.Account_No == accountNoSearch);
                var item4 = dme.customerAccounts.Where(a => a.Account_No == accountNoSearch).FirstOrDefault();

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
                    dataGridView2.DataSource = mi;

                    foreach (var item3 in item1)
                    {
                        mi2.Add(item3);
                    }
                    dataGridView1.DataSource = mi2;

                }

                balanceLabel.Text = item4.Balance.ToString();
                label4.Visible = true;
                balanceLabel.Visible = true;
            }

            catch
            {
                MessageBox.Show("Please enter an account number.");
            }
        }

        private void searchAccountNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
