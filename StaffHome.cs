using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class StaffHome : Form
    {

        bool customerCollapsed;
        bool transactionsCollapsed;
        bool profilesettingsCollapsed;

        public StaffHome()
        {

            InitializeComponent();

            staffIdLabel.Text = CoStaffLogin.instance.getStaffId.Text;

            slidepanel.Visible = true;
            
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;

            HomePageStaff homepage = new HomePageStaff();
            addUserControl(homepage);
        }

        private void HideSubmenu()
        {
            if (slidepanel.Visible == true)
                slidepanel.Visible = false;
        }

        // USER CONTROL METHOD
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerNewStaff.Controls.Clear();
            panelContainerNewStaff.Controls.Add(userControl);
            userControl.BringToFront();
            HideSubmenu();
        }


        // HOME SECTION
        private void homeButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = true;
            
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;

            HomePageStaff homepage = new HomePageStaff();
            addUserControl(homepage);
            HideSubmenu();
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
           
            slidePanelCustomer.Visible = true;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;
            customerTimer.Start();
            CustomerPage custompage = new CustomerPage();
            addUserControl(custompage);
            HideSubmenu();
        }

        private void newCustomerAccountButton_Click(object sender, EventArgs e)
        {
            NewCustomer_Staff newcustomerpage = new NewCustomer_Staff();
            addUserControl(newcustomerpage);
        }

        private void editCustomerAccountButton_Click(object sender, EventArgs e)
        {
            EditCustomer_Staff editcustomerpage = new EditCustomer_Staff();
            addUserControl(editcustomerpage);
        }

        private void viewCustomerAccountsButton_Click(object sender, EventArgs e)
        {
            AllCustomers_Staff viewcustomerpage = new AllCustomers_Staff();
            addUserControl(viewcustomerpage);
            HideSubmenu();
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
                  //  profileSettingsContainer.Visible = true;
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
            
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = true;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = false;


            TransactionsPage homepage = new TransactionsPage();
            addUserControl(homepage);
            HideSubmenu();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositPageStaff depositpage = new DepositPageStaff();
            addUserControl(depositpage);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawalPageStaff withdraw = new WithdrawalPageStaff();
            addUserControl(withdraw);
        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }




        //  BALANCE SHEET SECTION
        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            slidepanel.Visible = false;

            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = true;
            slidePanelProfileSettings.Visible = false;

            BalanceSheet_Staff balancesheetpage = new BalanceSheet_Staff();
            addUserControl(balancesheetpage);
            HideSubmenu();       
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
           
            slidePanelCustomer.Visible = false;
            slidePanelTransactions.Visible = false;
            slidePanelBalanceSheet.Visible = false;
            slidePanelProfileSettings.Visible = true;
            profileSettingsTimer.Start();

            ProfileSettingsPage profilepage = new ProfileSettingsPage();
            addUserControl(profilepage);
            HideSubmenu();
        }

        private void resetPasswordButtonn_Click(object sender, EventArgs e)
        {
            MyProfile_Staff myprofilepage = new MyProfile_Staff();
            addUserControl(myprofilepage);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            CoStaffLogin staff = new CoStaffLogin();
            staff.Show();
            Visible = false;
        }

       

        private void closebtn_MouseHover(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.Red;
        }

        private void closebtn_MouseLeave(object sender, EventArgs e)
        {
            closebtn.ForeColor = Color.Teal;
        }
    }
}
