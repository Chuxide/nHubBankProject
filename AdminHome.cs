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
    public partial class AdminHome : Form
    {
        bool staffCollapsed;
        bool customerCollapsed;
        bool transactionsCollapsed;
        bool profilesettingsCollapsed;

       
        public AdminHome()
        {
            InitializeComponent();

            adminIdLabel.Text = CoAdminLogin.instance.getAdminId.Text;

            slidepanel.Visible = true;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;

            HomePageAdmin homepage = new HomePageAdmin();
            addUserControl(homepage);
        }



        // HOME SECTION
        private void homeButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = true;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;

            HomePageAdmin homepage = new HomePageAdmin();
            addUserControl(homepage);
        }



        // STAFF SECTION
        private void staffTimer_Tick(object sender, EventArgs e)
        {
            if (staffCollapsed)
            {
                staffContainer.Height += 10;
                if (staffContainer.Height == staffContainer.MaximumSize.Height)
                {
                    customerContainer.Visible = false;
                    transactionsContainer.Visible = false;
                    balanceSheetContainer.Visible = true;
                    profileSettingsContainer.Visible = true;
                    staffCollapsed = false;
                    
                    staffTimer.Stop();
                }
            }
            else
            {
                staffContainer.Height -= 10;
                if (staffContainer.Height == staffContainer.MinimumSize.Height)
                {
                    staffCollapsed = true;                   
                    customerContainer.Visible = true;
                    transactionsContainer.Visible = true;
                    staffTimer.Stop();
                                                       
                }

            }
        }

        private void staffButton_Click(object sender, EventArgs e)
        {

            slidePanelStaff.Visible = true;
            slidepanel.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;

            customerContainer.Height = customerContainer.MinimumSize.Height;
            transactionsContainer.Height = transactionsContainer.MinimumSize.Height;
            staffTimer.Start();
            StaffPage newstaffpage = new StaffPage();
            addUserControl(newstaffpage);

            
        }
               

        private void newStaffButton_Click(object sender, EventArgs e)
        {
            NewStaff newstaffreg = new NewStaff();  
            addUserControl(newstaffreg);
        }

        private void editStaffButton_Click(object sender, EventArgs e)
        {
            EditStaff editstaffpage = new EditStaff();
            addUserControl(editstaffpage);
        }

        private void allStaffButton_Click(object sender, EventArgs e)
        {
            AllStaff staffpage = new AllStaff();
            addUserControl(staffpage);
        }

        

        // USER CONTROL METHOD
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerNewStaff.Controls.Clear();
            panelContainerNewStaff.Controls.Add(userControl);
            userControl.BringToFront();
        }



        // CUSTOMER SECTION
        private void customerTimer_Tick(object sender, EventArgs e)
        {
            if (customerCollapsed)
            {
                customerContainer.Height += 10;
                if (customerContainer.Height == customerContainer.MaximumSize.Height)
                {
                    customerCollapsed = false;
                    transactionsContainer.Visible = false;
                    customerTimer.Stop();
                }
            }
            else
            {
                customerContainer.Height -= 10;
                if (customerContainer.Height == customerContainer.MinimumSize.Height)
                {
                    customerCollapsed = true;
                    transactionsContainer.Visible = true;
                    customerTimer.Stop();
                }
            }
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = false;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = true;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;
            customerTimer.Start();
            CustomerPage custompage = new CustomerPage();
            addUserControl(custompage);
        }

        private void newCustomerAccountButton_Click(object sender, EventArgs e)
        {
            NewCustomer newcustomerpage = new NewCustomer();
            addUserControl(newcustomerpage);
        }

        private void editCustomerAccountButton_Click(object sender, EventArgs e)
        {
            EditCustomer editcustomerpage = new EditCustomer();
            addUserControl(editcustomerpage);
        }

        private void viewCustomerAccountsButton_Click(object sender, EventArgs e)
        {
            AllCustomers viewcustomerpage = new AllCustomers();
            addUserControl(viewcustomerpage);
        }



        // TRANSACTIONS SECTION
        private void transactionsTimer_Tick(object sender, EventArgs e)
        {

            if (transactionsCollapsed)
            {
               transactionsContainer.Height += 10;
                if (transactionsContainer.Height == transactionsContainer.MaximumSize.Height)
                {
                    transactionsCollapsed = false;
                  balanceSheetContainer.Visible = false;
                    profileSettingsContainer.Visible = false;
                    transactionsTimer.Stop();
                }
            }
            else
            {
                transactionsContainer.Height -= 10;
                if (transactionsContainer.Height == transactionsContainer.MinimumSize.Height)
                {
                    transactionsCollapsed = true;
                  balanceSheetContainer.Visible = true;
                    profileSettingsContainer.Visible = true;
                    transactionsTimer.Stop();
                }
            }
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            transactionsTimer.Start();
            slidepanel.Visible = false;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = true;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;
           

           TransactionsPage homepage = new TransactionsPage();
            addUserControl(homepage);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositPage depositpage = new DepositPage();
            addUserControl(depositpage);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawalPage withdraw = new WithdrawalPage();
            addUserControl(withdraw);
        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }




        //  PROFILE SETTINGS SECTION
        private void profileSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (profilesettingsCollapsed)
            {
                profileSettingsContainer.Height += 10;
                if (profileSettingsContainer.Height == profileSettingsContainer.MaximumSize.Height)
                {
                    profilesettingsCollapsed = false;
                    
                    profileSettingsTimer.Stop();
                }
            }
            else
            {
                profileSettingsContainer.Height -= 10;
                if (profileSettingsContainer.Height == profileSettingsContainer.MinimumSize.Height)
                {
                    profilesettingsCollapsed = true;
                   
                    profileSettingsTimer.Stop();
                }
            }
        }

        private void profileSettingsButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = false;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = true;
            profileSettingsTimer.Start();
        }

        private void resetPasswordButtonn_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login staff = new Login();
            staff.Show();
            Visible = false;
        }



        // BALANCE SHEET SECTION
        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = false;
            slidePanelStaff.Visible = false;
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = true;
            slidePanelProfileSettings.Visible = false;
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelContainerNewStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
