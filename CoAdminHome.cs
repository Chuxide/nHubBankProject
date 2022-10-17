using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Web.UI;
using System.Windows.Forms;

namespace BankApp
{
    public partial class CoAdminHome : Form
    {
        bool staffCollapsed;
        bool customerCollapsed;
        bool transactionsCollapsed;
        bool profilesettingsCollapsed;
      

        
        private void renderLeftPanel()
        {

            // final panel
            Panel leftPanel = new Panel();
            leftPanel.Size = new Size(163, 530);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.BackColor = Color.SlateGray;

            this.Controls.Add(leftPanel);
            

            // panel for admin pic
            Panel pictureboxPanel = new Panel();
            pictureboxPanel.Size = new Size(163, 124);
            pictureboxPanel.Location = new Point(0, 0);
            pictureboxPanel.BackColor = Color.SlateGray;

            // admin pic picturebox
            PictureBox adminPic = new PictureBox();
            adminPic.Image = BankApp.Properties.Resources.User_Avatar_in_Suit_PNG;
            adminPic.Size = new Size(114, 107);
            adminPic.Location = new Point(23, 12);
            adminPic.SizeMode = PictureBoxSizeMode.Zoom;
            pictureboxPanel.Controls.Add(adminPic);

            leftPanel.Controls.Add(pictureboxPanel);


            // HOME SECTION
            // panel for home button
            Panel homebuttonPanel = new Panel();
            homebuttonPanel.Size = new Size(163, 44);
            homebuttonPanel.Location = new Point(0, 127);
            homebuttonPanel.BackColor = Color.SlateGray;
            //slide panel for homebutton
            Panel slidePanel = new Panel();
            slidePanel.Size = new Size(10, 44);
            slidePanel.Location = new Point(0, 0);
            slidePanel.BackColor = Color.FromArgb (64, 64, 64);
            homebuttonPanel.Controls.Add(slidePanel);
            // home button
            Button homeButton = new Button();
            homeButton.Text = "HOME";
            homeButton.Location = new Point(0, 0);
            homeButton.Size = new Size(163, 44);
            homeButton.ForeColor = Color.White;
            homeButton.BackColor = Color.SlateGray;
            homeButton.Font = new Font("Comic Sans MS", 9);
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.FlatAppearance.BorderSize = 0;
            homebuttonPanel.Controls.Add(homeButton);

            leftPanel.Controls.Add(homebuttonPanel);


            // STAFF SECTION
            // panel for staff button
            Panel staffContainer = new Panel();
            staffContainer.Size = new Size(163, 44);
            staffContainer.MaximumSize = new Size(163, 142);
            staffContainer.MinimumSize = new Size(163, 44);
            staffContainer.BorderStyle = BorderStyle.None;
            staffContainer.Location = new Point(0, 176);
            staffContainer.BackColor = Color.DarkSlateGray;
            //slide panel for staffbutton
            Panel slidePanelStaff = new Panel();
            slidePanelStaff.Size = new Size(10, 44);
            slidePanelStaff.Location = new Point(0, 0);
            slidePanelStaff.BackColor = Color.FromArgb(64, 64, 64);
            slidePanelStaff.Visible = false;
            staffContainer.Controls.Add(slidePanelStaff);
            // staff button
            Button staffButton = new Button();
            staffButton.Text = "STAFF";
            staffButton.Location = new Point(0, 0);
            staffButton.Size = new Size(163, 44);
            staffButton.ForeColor = Color.White;
            staffButton.BackColor = Color.SlateGray;
            staffButton.Font = new Font("Comic Sans MS", 9);
            staffButton.FlatStyle = FlatStyle.Flat;
            staffButton.FlatAppearance.BorderSize = 0;
            staffContainer.Controls.Add(staffButton);
            // allstaff button
            Button allStaffButton = new Button();
            allStaffButton.Text = "View Staff";
            allStaffButton.Location = new Point(0, 107);
            allStaffButton.Size = new Size(163, 34);
            allStaffButton.ForeColor = Color.White;
            allStaffButton.BackColor = Color.FromArgb(64, 64, 64);
            allStaffButton.Font = new Font("Comic Sans MS", 9);
            allStaffButton.FlatStyle = FlatStyle.Flat;
            allStaffButton.FlatAppearance.BorderSize = 0;
            staffContainer.Controls.Add(allStaffButton);
            // editstaff button
            Button editStaffButton = new Button();
            editStaffButton.Text = "Edit Staff";
            editStaffButton.Location = new Point(0, 74);
            editStaffButton.Size = new Size(163, 34);
            editStaffButton.ForeColor = Color.White;
            editStaffButton.BackColor = Color.FromArgb(64, 64, 64);
            editStaffButton.Font = new Font("Comic Sans MS", 9);
            editStaffButton.FlatStyle = FlatStyle.Flat;
            editStaffButton.FlatAppearance.BorderSize = 0;
            staffContainer.Controls.Add(editStaffButton);
            // new staff button
            Button newStaffButton = new Button();
            newStaffButton.Text = "New Staff";
            newStaffButton.Location = new Point(0, 41);
            newStaffButton.Size = new Size(163, 34);
            newStaffButton.ForeColor = Color.White;
            newStaffButton.BackColor = Color.FromArgb(64, 64, 64);
            newStaffButton.Font = new Font("Comic Sans MS", 9);
            newStaffButton.FlatStyle = FlatStyle.Flat;
            newStaffButton.FlatAppearance.BorderSize = 0;
            staffContainer.Controls.Add(newStaffButton);

            leftPanel.Controls.Add(staffContainer);



            // CUSTOMER SECTION
            // panel for customer button
            Panel customerContainer = new Panel();
            customerContainer.Size = new Size(163, 44);
            customerContainer.MaximumSize = new Size(163, 142);
            customerContainer.MinimumSize = new Size(163, 44);
            customerContainer.BorderStyle = BorderStyle.None;
            customerContainer.Location = new Point(0, 224);
            customerContainer.BackColor = Color.DarkSlateGray;
            //slide panel for customerbutton
            Panel slidePanelCustomer = new Panel();
            slidePanelCustomer.Size = new Size(10, 44);
            slidePanelCustomer.Location = new Point(0, 0);
            slidePanelCustomer.BackColor = Color.FromArgb(64, 64, 64);
            slidePanelCustomer.Visible = false;
            customerContainer.Controls.Add(slidePanelCustomer);
            // customer button
            Button customerButton = new Button();
            customerButton.Text = "CUSTOMER";
            customerButton.Location = new Point(0, 0);
            customerButton.Size = new Size(163, 44);
            customerButton.ForeColor = Color.White;
            customerButton.BackColor = Color.SlateGray;
            customerButton.Font = new Font("Comic Sans MS", 9);
            customerButton.FlatStyle = FlatStyle.Flat;
            customerButton.FlatAppearance.BorderSize = 0;
            customerContainer.Controls.Add(customerButton);
            // newCustomerAccountButton
            Button newCustomerAccountButton = new Button();
            newCustomerAccountButton.Text = "New Account";
            newCustomerAccountButton.Location = new Point(0, 42);
            newCustomerAccountButton.Size = new Size(163, 34);
            newCustomerAccountButton.ForeColor = Color.White;
            newCustomerAccountButton.BackColor = Color.FromArgb(64, 64, 64);
            newCustomerAccountButton.Font = new Font("Comic Sans MS", 9);
            newCustomerAccountButton.FlatStyle = FlatStyle.Flat;
            newCustomerAccountButton.FlatAppearance.BorderSize = 0;
            customerContainer.Controls.Add(newCustomerAccountButton);
            // editCustomerAccountButton
            Button editCustomerAccountButton = new Button();
            editCustomerAccountButton.Text = "Edit Account";
            editCustomerAccountButton.Location = new Point(0, 75);
            editCustomerAccountButton.Size = new Size(163, 34);
            editCustomerAccountButton.ForeColor = Color.White;
            editCustomerAccountButton.BackColor = Color.FromArgb(64, 64, 64);
            editCustomerAccountButton.Font = new Font("Comic Sans MS", 9);
            editCustomerAccountButton.FlatStyle = FlatStyle.Flat;
            editCustomerAccountButton.FlatAppearance.BorderSize = 0;
            customerContainer.Controls.Add(editCustomerAccountButton);
            // viewCustomerAccountsButton
            Button viewCustomerAccountsButton = new Button();
            viewCustomerAccountsButton.Text = "View Accounts";
            viewCustomerAccountsButton.Location = new Point(0, 108);
            viewCustomerAccountsButton.Size = new Size(163, 34);
            viewCustomerAccountsButton.ForeColor = Color.White;
            viewCustomerAccountsButton.BackColor = Color.FromArgb(64, 64, 64);
            viewCustomerAccountsButton.Font = new Font("Comic Sans MS", 9);
            viewCustomerAccountsButton.FlatStyle = FlatStyle.Flat;
            viewCustomerAccountsButton.FlatAppearance.BorderSize = 0;
            customerContainer.Controls.Add(viewCustomerAccountsButton);

            leftPanel.Controls.Add(customerContainer);


            // TRANSACTIONS SECTION
            // panel for transactions button
            Panel transactionsContainer = new Panel();
            transactionsContainer.Size = new Size(163, 44);
            transactionsContainer.MaximumSize = new Size(163, 142);
            transactionsContainer.MinimumSize = new Size(163, 44);
            transactionsContainer.BorderStyle = BorderStyle.None;
            transactionsContainer.Location = new Point(0, 272);
            transactionsContainer.BackColor = Color.DarkSlateGray;
            //slide panel for transactionsbutton
            Panel slidePanelTransactions = new Panel();
            slidePanelTransactions.Size = new Size(10, 44);
            slidePanelTransactions.Location = new Point(0, 0);
            slidePanelTransactions.BackColor = Color.FromArgb(64, 64, 64);
            slidePanelTransactions.Visible = false;
            transactionsContainer.Controls.Add(slidePanelTransactions);
            // transactions button
            Button transactionsButton = new Button();
            transactionsButton.Text = "TRANSACTIONS";
            transactionsButton.Location = new Point(0, 0);
            transactionsButton.Size = new Size(163, 44);
            transactionsButton.ForeColor = Color.White;
            transactionsButton.BackColor = Color.SlateGray;
            transactionsButton.Font = new Font("Comic Sans MS", 9);
            transactionsButton.FlatStyle = FlatStyle.Flat;
            transactionsButton.FlatAppearance.BorderSize = 0;
            transactionsContainer.Controls.Add(transactionsButton);
            // depositButton
            Button depositButton = new Button();
            depositButton.Text = "Deposit";
            depositButton.Location = new Point(0, 43);
            depositButton.Size = new Size(163, 34);
            depositButton.ForeColor = Color.White;
            depositButton.BackColor = Color.FromArgb(64, 64, 64);
            depositButton.Font = new Font("Comic Sans MS", 9);
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.FlatAppearance.BorderSize = 0;
            transactionsContainer.Controls.Add(depositButton);
            // withdrawalButton
            Button withdrawButton = new Button();
            withdrawButton.Text = "Withdraw";
            withdrawButton.Location = new Point(0, 76);
            withdrawButton.Size = new Size(163, 34);
            withdrawButton.ForeColor = Color.White;
            withdrawButton.BackColor = Color.FromArgb(64, 64, 64);
            withdrawButton.Font = new Font("Comic Sans MS", 9);
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.FlatAppearance.BorderSize = 0;
            transactionsContainer.Controls.Add(withdrawButton);
            // transferButton
            Button transferButton = new Button();
            transferButton.Text = "Transfer";
            transferButton.Location = new Point(0, 108);
            transferButton.Size = new Size(163, 34);
            transferButton.ForeColor = Color.White;
            transferButton.BackColor = Color.FromArgb(64, 64, 64);
            transferButton.Font = new Font("Comic Sans MS", 9);
            transferButton.FlatStyle = FlatStyle.Flat;
            transferButton.FlatAppearance.BorderSize = 0;
            transactionsContainer.Controls.Add(transferButton);

            leftPanel.Controls.Add(transactionsContainer);
            

            // SHEET SECTION
            // panel for balance sheet button
            Panel balanceSheetContainer = new Panel();
            balanceSheetContainer.Size = new Size(163, 44);
            balanceSheetContainer.Location = new Point(0, 321);
            balanceSheetContainer.BackColor = Color.SlateGray;
            //slide panel for balance sheet button
            Panel slidePanelBalanceSheet = new Panel();
            slidePanelBalanceSheet.Size = new Size(10, 44);
            slidePanelBalanceSheet.Location = new Point(0, 0);
            slidePanelBalanceSheet.BackColor = Color.FromArgb(64, 64, 64);
            slidePanelBalanceSheet.Visible = false;
            balanceSheetContainer.Controls.Add(slidePanelBalanceSheet);
            // balance sheet button
            Button balanceSheetButton = new Button();
            balanceSheetButton.Text = "BALANCE SHEET";
            balanceSheetButton.Location = new Point(0, 0);
            balanceSheetButton.Size = new Size(163, 44);
            balanceSheetButton.ForeColor = Color.White;
            balanceSheetButton.BackColor = Color.SlateGray;
            balanceSheetButton.Font = new Font("Comic Sans MS", 9);
            balanceSheetButton.FlatStyle = FlatStyle.Flat;
            balanceSheetButton.FlatAppearance.BorderSize = 0;
            balanceSheetContainer.Controls.Add(balanceSheetButton);

            leftPanel.Controls.Add(balanceSheetContainer);


            // PROFILE SETTINGS SECTION
            // panel for profile settings button
            Panel profileSettingsContainer = new Panel();
            profileSettingsContainer.Size = new Size(163, 44);
            profileSettingsContainer.MaximumSize = new Size(163, 142);
            profileSettingsContainer.MinimumSize = new Size(163, 44);
            profileSettingsContainer.BorderStyle = BorderStyle.None;
            profileSettingsContainer.Location = new Point(0, 370);
            profileSettingsContainer.BackColor = Color.DarkSlateGray;
            //slide panel for profile settings button
            Panel slidePanelProfileSettings = new Panel();
            slidePanelProfileSettings.Size = new Size(10, 44);
            slidePanelProfileSettings.Location = new Point(0, 0);
            slidePanelProfileSettings.BackColor = Color.FromArgb(64, 64, 64);
            slidePanelProfileSettings.Visible = false;
            profileSettingsContainer.Controls.Add(slidePanelProfileSettings);
            // profile settings button
            Button profileSettingsButton = new Button();
            profileSettingsButton.Text = "PROFILE SETTINGS";
            profileSettingsButton.Location = new Point(0, 0);
            profileSettingsButton.Size = new Size(163, 44);
            profileSettingsButton.ForeColor = Color.White;
            profileSettingsButton.BackColor = Color.SlateGray;
            profileSettingsButton.Font = new Font("Comic Sans MS", 9);
            profileSettingsButton.FlatStyle = FlatStyle.Flat;
            profileSettingsButton.FlatAppearance.BorderSize = 0;
            profileSettingsContainer.Controls.Add(profileSettingsButton);

            leftPanel.Controls.Add(profileSettingsContainer);


            // TIMERS
            // staff timer
            Timer staffTimer = new Timer();
            staffTimer.Interval = 5;
            staffTimer.Tick += (sender, args) =>
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
            };

            // customer timer
            Timer customerTimer = new Timer();
            customerTimer.Interval = 5;
            customerTimer.Tick += (sender, args) =>
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
            };

            // transactions timer
            Timer transactionsTimer = new Timer();
            transactionsTimer.Interval = 5;
            transactionsTimer.Tick += (sender, args) =>
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
            };

            // profile settings timer
           Timer profileSettingsTimer = new Timer();
            profileSettingsTimer.Interval = 5;
            profileSettingsTimer.Tick += (sender, args) =>
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
            };




            // BOTTOM RIGHT PANEL FOR USERCONTROL
            Panel bottomPanel = new Panel();
            bottomPanel.Size = new Size(587, 405);
            bottomPanel.Location = new Point(163, 129);
            bottomPanel.BackColor = Color.White;
            this.Controls.Add(bottomPanel);




            // BUTTON CLICKS
            // customer button click
            homeButton.Click += (sender, args) =>
            {
                slidePanel.Visible = true;
                slidePanelStaff.Visible = false;
                slidePanelCustomer.Visible = false;
                slidePanelTransactions.Visible = false;
                slidePanelBalanceSheet.Visible = false;
                slidePanelProfileSettings.Visible = false;

                HomePageAdmin homepage = new HomePageAdmin();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(homepage);
                bottomPanel.BringToFront();
            };


            // staff button click
            staffButton.Click += (sender, args) =>
            {
                staffTimer.Start();
                slidePanelStaff.Visible = true;
                slidePanel.Visible = false;
                slidePanelCustomer.Visible = false;
                slidePanelTransactions.Visible = false;
                slidePanelBalanceSheet.Visible = false;
                slidePanelProfileSettings.Visible = false;

                customerContainer.Height = customerContainer.MinimumSize.Height;
                transactionsContainer.Height = transactionsContainer.MinimumSize.Height;
               
                StaffPage newstaffpage = new StaffPage();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(newstaffpage);
                bottomPanel.BringToFront();
            };
            // allstaff button click
            allStaffButton.Click += (sender, args) =>
            {
                AllStaff staffpage = new AllStaff();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(staffpage);
                bottomPanel.BringToFront();
            };
            // editstaff button click
            editStaffButton.Click += (sender, args) =>
            {
               
                EditStaff editstaffpage = new EditStaff();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(editstaffpage);
                bottomPanel.BringToFront();
            };
            // newstaff button click
            newStaffButton.Click += (sender, args) =>
            {
                
                NewStaff newstaffreg = new NewStaff();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(newstaffreg);
                bottomPanel.BringToFront();
            };


            // customer button click
            customerButton.Click += (sender, args) =>
            {
                slidePanel.Visible = false;
                slidePanelStaff.Visible = false;
                slidePanelCustomer.Visible = true;
                slidePanelTransactions.Visible = false;
                slidePanelBalanceSheet.Visible = false;
                slidePanelProfileSettings.Visible = false;
                customerTimer.Start();
               
                CustomerPage customerpage = new CustomerPage();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(customerpage);
                bottomPanel.BringToFront();
            };
            // viewcustomer button click
            viewCustomerAccountsButton.Click += (sender, args) =>
            {
                
                AllCustomers allcustomerspage = new AllCustomers();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(allcustomerspage);
                bottomPanel.BringToFront();
            };
            // editcustomer button click
            editCustomerAccountButton.Click += (sender, args) =>
            {
                
                EditCustomer editcustomerpage = new EditCustomer();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(editcustomerpage);
                bottomPanel.BringToFront();
            };
            // newcustomer button click
            newCustomerAccountButton.Click += (sender, args) =>
            {
                
                NewCustomer newcustomerreg = new NewCustomer();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(newcustomerreg);
                bottomPanel.BringToFront();
            };


            // transactions button click
            transactionsButton.Click += (sender, args) =>
            {
                transactionsTimer.Start();
                slidePanel.Visible = false;
                slidePanelStaff.Visible = false;
                slidePanelCustomer.Visible = false;
                slidePanelTransactions.Visible = true;
                slidePanelBalanceSheet.Visible = false;
                slidePanelProfileSettings.Visible = false;

                TransactionsPage transactionspage = new TransactionsPage();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(transactionspage);
                bottomPanel.BringToFront();
            };
            // deposit button click
            depositButton.Click += (sender, args) =>
            {

                DepositPage depositpage = new DepositPage();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(depositpage);
                bottomPanel.BringToFront();
            };
            // withdraw button click
            withdrawButton.Click += (sender, args) =>
            {

                WithdrawalPage withdrawalpage = new WithdrawalPage();
                bottomPanel.Controls.Clear();
                bottomPanel.Controls.Add(withdrawalpage);
                bottomPanel.BringToFront();
            };
            // transfer button click
            transferButton.Click += (sender, args) =>
            {

            };

        }


       
        private void renderTopPanel()
        {
            // final panel
            Panel topPanel = new Panel();
            topPanel.Size = new Size(587, 14);
            topPanel.Location = new Point(163, 0);
            topPanel.Dock = DockStyle.Top;
            topPanel.BackColor = Color.SlateGray;

            this.Controls.Add(topPanel);
        }

      

        private void renderBankImagePanel()
        {
            // final panel
            Panel bankPicPanel = new Panel();
            bankPicPanel.Size = new Size(96, 121);
            bankPicPanel.Location = new Point(196, 2);
            
            bankPicPanel.BackColor = Color.SlateGray;

            this.Controls.Add(bankPicPanel);

            PictureBox bankPic = new PictureBox();
            bankPic.Image = BankApp.Properties.Resources.Bank_Logo_Transparent_Background;
            bankPic.Size = new Size(76, 50);
            bankPic.Location = new Point(10, 14);
            bankPic.SizeMode = PictureBoxSizeMode.Zoom;
            bankPicPanel.Controls.Add(bankPic);

            Label label = new Label();
            label.Text = "Bank";
            label.Location = new Point(4, 67);
            label.Size = new Size(36, 16);
            label.Font = new Font("Century Gothic", 7);
            label.ForeColor = Color.White;
            bankPicPanel.Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Management";
            label1.Location = new Point(4, 84);
            label1.Size = new Size(83, 16);
            label1.Font = new Font("Century Gothic", 7);
            label1.ForeColor = Color.White;
            bankPicPanel.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "System";
            label2.Location = new Point(4, 101);
            label2.Size = new Size(44, 16);
            label2.Font = new Font("Century Gothic", 7);
            label2.ForeColor = Color.White;
            bankPicPanel.Controls.Add(label2);


        }


        
        
        private void renderBottomPanel()
        {
            
            // final panel
            Panel bottomPanel = new Panel();
            bottomPanel.Size = new Size(587, 405);
            bottomPanel.Location = new Point(163, 129);
            // bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.BackColor = Color.White;
            this.Controls.Add(bottomPanel);
            HomePageAdmin homepage = new HomePageAdmin();
            bottomPanel.Controls.Add(homepage);
            bottomPanel.BringToFront();
        }

        private void renderTopRightArea()
        {
            PictureBox piggyPic = new PictureBox();
            piggyPic.Image = BankApp.Properties.Resources.Dumbo_With_Yellow_Hat_PNG_Photos;
            piggyPic.Size = new Size(108, 76);
            piggyPic.Location = new Point(602, 43);
            piggyPic.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(piggyPic);

            //'welcome admin' label
            Label label2 = new Label();
            label2.Text = "Welcome Admin";
            label2.Location = new Point(310, 43);
            label2.Size = new Size(281, 49);
            label2.Font = new Font("Comic Sans MS", 26);
            label2.ForeColor = Color.SlateGray;
            this.Controls.Add(label2);

            //'have a nice day' label
            Label label1 = new Label();
            label1.Text = "Have a nice day!";
            label1.Location = new Point(406, 102);
            label1.Size = new Size(96, 17);
            label1.Font = new Font("Comic Sans MS", 9);
            label1.ForeColor = SystemColors.ControlText;
            this.Controls.Add(label1);

            //'x' label as close button
            Label label3 = new Label();
            label3.Text = "x";
            label3.Location = new Point(720, 0);
            label3.Size = new Size(40, 40);
            label3.Font = new Font("Verdana", 15, FontStyle.Bold);
            label3.ForeColor = Color.SlateGray;
            label3.BringToFront();
            this.Controls.Add(label3);
            label3.Click += (sender, args) =>
            {
                Application.Exit();
            };
            label3.MouseHover += (sender, args) =>
            {
                label3.ForeColor = Color.Red;
            };
            label3.MouseLeave += (sender, args) =>
            {
                label3.ForeColor = Color.SlateGray;
            };

            // label for representing the admin Id
            Label adminIdLabel = new Label();
       //     adminIdLabel.Text = CoAdminLogin.instance.getAdminId.Text;
            adminIdLabel.Location = new Point(483, 30);
            adminIdLabel.Size = new Size(50, 13);
            adminIdLabel.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            adminIdLabel.ForeColor = Color.SlateGray;
            adminIdLabel.BringToFront();
            this.Controls.Add(adminIdLabel);

            //'Admin ID: KS' label
            Label label4 = new Label();
            label4.Text = "Admin ID: KS";
            label4.Location = new Point(404, 30);
            label4.Size = new Size(86, 13);
            label4.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            label4.ForeColor = Color.SlateGray;
            this.Controls.Add(label4);

            

        }



        public CoAdminHome()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(750, 530);
            renderBottomPanel();
            renderLeftPanel();
            renderTopRightArea();
            renderTopPanel();
            renderBankImagePanel();
               
                        

        }

      
    }
}
