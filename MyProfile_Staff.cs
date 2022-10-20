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
    public partial class MyProfile_Staff : UserControl
    {

        BankingPEntities5 dbe;
        MemoryStream ms;

        public MyProfile_Staff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();

            dbe = new BankingPEntities5();
            int staffIdSearch = Convert.ToInt32(CoStaffLogin.instance.getStaffId.Text);
            var item = dbe.staffAccount1.Where(a => a.staffId == staffIdSearch).FirstOrDefault();

            firstNameTxt.Text = item.First_Name;
            lastNameTxt.Text = item.Last_Name;
            motherMaidenNameTxt.Text = item.Mother_Maiden_Name;
            phoneNoTxt.Text = item.Phone_No;
            emailIdTxt.Text = item.Email_Id;
            addressTxt.Text = item.Residential_Address;
            emergencyNameTxt.Text = item.Emergency_Name;
            emergencyPhoneNoTxt.Text = item.Emergency_Phone_No;
            userNameTxt.Text = item.Username;
            passwordTxt.Text = item.Password;
            staffIdTxt.Text = "KS" + item.staffId.ToString();
            dateTimePicker1.Text = item.DOB;
            dobTxt.Text = dateTimePicker1.Value.Date.ToString();
            dateOfRegistrationTxt.Text = item.Date_Of_Registration;
            lastEditedTxt.Text = item.Last_Edited;
            genderTxt.Text = item.Gender;
            stateOfOriginTxt.Text = item.State_Of_Origin;
            maritalStatusTxt.Text = item.Marital_Status;

            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

        }




        private void editStaffPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            myProfilePanel.Controls.Clear();
            myProfilePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            myProfilePanel.BringToFront();
            changePassword_Staff changePasswordpage = new changePassword_Staff();
            addUserControl(changePasswordpage);
        }

        private void changeUsernameBtn_Click(object sender, EventArgs e)
        {
            myProfilePanel.BringToFront();
            changeUsername_Staff changeUsernamepage = new changeUsername_Staff();
            addUserControl(changeUsernamepage);
        }
    }
}
