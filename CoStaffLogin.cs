using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace BankApp
{
    public partial class CoStaffLogin : Form
    {
        public static CoStaffLogin instance;
        public TextBox getStaffId;
        private void renderLeftPanel()
        {

            // final panel
            Panel leftPanel = new Panel();
            leftPanel.Size = new Size(300, 530);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.BackColor = Color.Teal;

            this.Controls.Add(leftPanel);

            // label to return to staff login
            Label staffloginlink = new Label();
            staffloginlink.Text = "Admin";
            staffloginlink.Location = new Point(131, 235);
            staffloginlink.Size = new Size(41, 16);
            staffloginlink.Font = new Font("Century Gothic", 7);
            staffloginlink.ForeColor = Color.Silver;
            staffloginlink.BackColor = SystemColors.Control;
            // staffloginlink.Cursor = System.Windows.Forms.Cursors.Hand;
            leftPanel.Controls.Add(staffloginlink);
            staffloginlink.Click += (sender, args) =>
            {
                CoAdminLogin admin = new CoAdminLogin();
                admin.Show();
                Visible = false;
            };

            // picture
            PictureBox loginPic = new PictureBox();
            loginPic.Image = BankApp.Properties.Resources.Bank_Logo_Transparent_Background;
            loginPic.Size = new Size(237, 242);
            loginPic.Location = new Point(33, 25);
            loginPic.SizeMode = PictureBoxSizeMode.Zoom;
            leftPanel.Controls.Add(loginPic);

            // 'welcome to the bank management system' labels 
            Label label = new Label();
            label.Text = "Welcome to the";
            label.Location = new Point(92, 285);
            label.Size = new Size(178, 24);
            label.Font = new Font("Century Gothic", 15);
            label.ForeColor = Color.White;
            leftPanel.Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Bank Management";
            label1.Location = new Point(61, 318);
            label1.Size = new Size(209, 24);
            label1.Font = new Font("Century Gothic", 15);
            label1.ForeColor = Color.White;
            leftPanel.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "System";
            label2.Location = new Point(177, 351);
            label2.Size = new Size(81, 24);
            label2.Font = new Font("Century Gothic", 15);
            label2.ForeColor = Color.White;
            leftPanel.Controls.Add(label2);

            

        }



        private void renderRightPanel()
        {



            // final panel
            Panel rightPanel = new Panel();
            rightPanel.Size = new Size(450, 530);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.BackColor = SystemColors.Control;
            rightPanel.Font = new Font("Century Gothic", 9);


            this.Controls.Add(rightPanel);


            // 'login to admin' label
            Label label3 = new Label();
            label3.Text = "Login to staff account";
            label3.Location = new Point(38, 135);
            label3.Size = new Size(257, 24);
            label3.Font = new Font("Century Gothic", 15);
            label3.ForeColor = Color.Teal;
            rightPanel.Controls.Add(label3);



            // label as close button
            Label label2 = new Label();
            label2.Text = "x";
            label2.Location = new Point(410, 0);
            label2.Size = new Size(40, 40);
            label2.Font = new Font("Verdana", 15, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            rightPanel.Controls.Add(label2);
            label2.Click += (sender, args) =>
            {
                Application.Exit();
            };
            label2.MouseHover += (sender, args) =>
            {
                label2.ForeColor = Color.Red;
            };
            label2.MouseLeave += (sender, args) =>
            {
                label2.ForeColor = Color.Teal;
            };




            // calling other panel functions
            Panel inputfields = compoundPanel();
            rightPanel.Controls.Add(inputfields);

        }



        // panel for user name input
        public Panel compoundPanel()
        {

            Panel compoundPanel = new Panel();
            compoundPanel.Location = new Point(0, 185);
            compoundPanel.Size = new Size(450, 170);
            compoundPanel.BackColor = SystemColors.Control;
            compoundPanel.BorderStyle = BorderStyle.None;


            // login button
            Button loginButton = new Button();
            loginButton.Text = "LOGIN";
            loginButton.Location = new Point(147, 125);
            loginButton.Size = new Size(148, 35);
            loginButton.ForeColor = Color.White;
            loginButton.BackColor = Color.Teal;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            compoundPanel.Controls.Add(loginButton);



            // panel for username
            Panel userNamePanel = new Panel();
            userNamePanel.Location = new Point(0, 0);
            userNamePanel.Size = new Size(450, 45);
            userNamePanel.BackColor = Color.White;


            // textbox for username
            TextBox userName = new TextBox();
            userName.Size = new Size(350, 17);
            userName.Location = new Point(51, 15);
            userName.ForeColor = Color.Teal;
            userName.BorderStyle = BorderStyle.None;
            userName.BackColor = SystemColors.Window;
            userName.Font = new Font("Century Gothic", 10);
            userNamePanel.Controls.Add(userName);


            // picture box in username panel
            PictureBox userPic = new PictureBox();
            userPic.Image = BankApp.Properties.Resources.images__17_;
            userPic.Size = new Size(24, 24);
            userPic.Location = new Point(15, 11);
            userPic.SizeMode = PictureBoxSizeMode.Zoom;
            userNamePanel.Controls.Add(userPic);

            // label for indicating username textbox 
            Label asterixUserName = new Label();
            asterixUserName.Text = "*";
            asterixUserName.Location = new Point(407, 15);
            asterixUserName.Size = new Size(14, 17);
            asterixUserName.Font = new Font("Century Gothic", 9);
            asterixUserName.ForeColor = Color.Red;
            asterixUserName.Visible = false;
            userNamePanel.Controls.Add(asterixUserName);






            // panel for password
            Panel passwordPanel = new Panel();
            passwordPanel.Location = new Point(0, 50);
            passwordPanel.Size = new Size(450, 45);
            passwordPanel.BackColor = SystemColors.Control;


            // textbox for password
            TextBox passWord = new TextBox();
            passWord.Size = new Size(350, 17);
            passWord.Location = new Point(51, 15);
            passWord.ForeColor = Color.Teal;
            passWord.BorderStyle = BorderStyle.None;
            passWord.BackColor = SystemColors.Control;
            passWord.Font = new Font("Century Gothic", 10);
            passWord.UseSystemPasswordChar = true;
            passwordPanel.Controls.Add(passWord);

            // picture box in password panel
            PictureBox passwordPic = new PictureBox();
            passwordPic.Image = BankApp.Properties.Resources.images__14_;
            passwordPic.Size = new Size(24, 24);
            passwordPic.Location = new Point(15, 11);
            passwordPic.SizeMode = PictureBoxSizeMode.Zoom;
            passwordPanel.Controls.Add(passwordPic);

            // label for indicating password textbox 
            Label asterixPassword = new Label();
            asterixPassword.Text = "*";
            asterixPassword.Location = new Point(406, 15);
            asterixPassword.Size = new Size(14, 17);
            asterixPassword.Font = new Font("Century Gothic", 9);
            asterixPassword.ForeColor = Color.Red;
            asterixPassword.Visible = false;
            passwordPanel.Controls.Add(asterixPassword);

            // picture box as button to reveal password in password panel
            PictureBox revealpasswordPic = new PictureBox();
            revealpasswordPic.Image = BankApp.Properties.Resources.images__12_;
            revealpasswordPic.Size = new Size(24, 24);
            revealpasswordPic.Location = new Point(422, 11);
            revealpasswordPic.SizeMode = PictureBoxSizeMode.Zoom;
            passwordPanel.Controls.Add(revealpasswordPic);
            revealpasswordPic.MouseDown += (sender, args) =>
            {
                passWord.UseSystemPasswordChar = false;

            };
            revealpasswordPic.MouseUp += (sender, args) =>
            {
                passWord.UseSystemPasswordChar = true;

            };


            // label to indicate incorrect password or username
            Label errorMessage = new Label();
            errorMessage.Text = "*Incorrect username or password. Please try again.";
            errorMessage.Location = new Point(93, 100);
            errorMessage.Size = new Size(280, 16);
            errorMessage.Font = new Font("Century Gothic", 7);
            errorMessage.ForeColor = Color.Red;
            errorMessage.Visible = false;
            compoundPanel.Controls.Add(errorMessage);


            // username text box click
            userName.Click += (sender, args) =>
            {
                userName.BackColor = Color.White;
                userNamePanel.BackColor = Color.White;
                passWord.BackColor = SystemColors.Control;
                passwordPanel.BackColor = SystemColors.Control;

            };
            // password text box click
            passWord.Click += (sender, args) =>
            {
                passWord.BackColor = Color.White;
                passwordPanel.BackColor = Color.White;
                userName.BackColor = SystemColors.Control;
                userNamePanel.BackColor = SystemColors.Control;
            };

            // textbox for getting staffId
            TextBox staffIdHolder = new TextBox();
            staffIdHolder.Size = new Size(72, 20);
            staffIdHolder.Location = new Point(186, 349);
            staffIdHolder.ForeColor = Color.Teal;
            staffIdHolder.BorderStyle = BorderStyle.None;
            staffIdHolder.BackColor = SystemColors.Control;
            staffIdHolder.Font = new Font("Century Gothic", 10);
            staffIdHolder.Visible = false;
            this.Controls.Add(staffIdHolder);
            getStaffId = staffIdHolder;


            // code for when button is clicked
            loginButton.Click += (sender, args) =>
            {
                BankingPEntities5 dbe = new BankingPEntities5();
                if (userName.Text != string.Empty || passWord.Text != string.Empty)
                {
                    var user1 = dbe.staffAccount1.FirstOrDefault(a => a.Username.Equals(userName.Text));
                    if (user1 != null)
                    {
                        if (user1.Password.Equals(passWord.Text))
                        {
                            staffIdHolder.Text = user1.staffId.ToString();
                            StaffHome staffhomepage = new StaffHome();
                            staffhomepage.Show();
                            Visible = false;
                        }
                        else
                        {
                            errorMessage.Visible = true;
                        }
                    }

                    else
                    {
                        errorMessage.Visible = true;
                    }
                }

                else
                {
                    asterixPassword.Visible = true;
                    asterixUserName.Visible = true;
                    MessageBox.Show("Please enter username and password.");
                }
            };


            compoundPanel.Controls.Add(userNamePanel);
            compoundPanel.Controls.Add(passwordPanel);

            return compoundPanel;
        }


        public CoStaffLogin()
        {
            InitializeComponent();
            instance = this;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(750, 530);
            renderRightPanel();
            renderLeftPanel();
        }
    }
}
