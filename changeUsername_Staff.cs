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
    public partial class changeUsername_Staff : UserControl
    {
        public changeUsername_Staff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            enterPasswordTxt.UseSystemPasswordChar = false;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            enterPasswordTxt.UseSystemPasswordChar = true;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            myProfilePanel.Controls.Clear();
            myProfilePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void savePasswordBtn_Click(object sender, EventArgs e)
        {
            BankingPEntities5 dbe = new BankingPEntities5();

            if (oldUsernameTxt.Text.Length == 0)
            {
                asterixOld.Visible = true;
                MessageBox.Show("Please enter old username.");
            }
            else if (newUsernameTxt.Text.Length == 0)
            {
                asterixNew.Visible = true;
                MessageBox.Show("Please enter new username.");
            }
            else if (enterPasswordTxt.Text.Length == 0)
            {

                asterixConfirm.Visible = true;
                MessageBox.Show("Please enter your password.");
            }

            else if (oldUsernameTxt.Text != string.Empty || newUsernameTxt.Text != string.Empty || enterPasswordTxt.Text != string.Empty)
            {
                var user1 = dbe.staffAccount1.FirstOrDefault(a => a.Username.Equals(oldUsernameTxt.Text));
                if (user1 != null)
                {
                    if (user1.staffId.Equals(Convert.ToInt32(CoStaffLogin.instance.getStaffId.Text)) && user1.Password.Equals(enterPasswordTxt.Text))
                    {
                        user1.Username = newUsernameTxt.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Username has been changed successfully.");
                        MyProfile_Staff myprofilepage = new MyProfile_Staff();
                        addUserControl(myprofilepage);
                    }
                    else
                    {
                        asterixNew.Visible = true;
                        asterixConfirm.Visible = true;
                        MessageBox.Show("Incorrect password.");
                    }
                }

                else
                {
                    asterixOld.Visible = true;
                    MessageBox.Show("Incorrect username.");
                }
            }

        }

        private void backToProfileBtn_Click(object sender, EventArgs e)
        {
            myProfilePanel.BringToFront();
            MyProfile_Staff myprofilepage = new MyProfile_Staff();
            addUserControl(myprofilepage);
        }
    }
}
