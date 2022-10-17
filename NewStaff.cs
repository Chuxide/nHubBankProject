using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class NewStaff : UserControl
    {

        string gender = string.Empty;
        string m_status = string.Empty;
        int no;
        BankingPEntities1 BSE;
        MemoryStream ms;

        public NewStaff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            loadDate();
            loadState();
            loadStaff();
        }

        private void loadStaff()
        {
            BSE = new BankingPEntities1();
            var item = BSE.staffAccount1.ToArray();
            no = item.LastOrDefault().staffId + 1;
            staffIdTxt.Text = "KS" + Convert.ToString(no);

        }

        private void loadDate()
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        // combo box dropdown list for choosing state
        private void loadState()
        {
            comboBox1.Items.Add("FCT");
            comboBox1.Items.Add("Abia");
            comboBox1.Items.Add("Adamawa");
            comboBox1.Items.Add("Akwa Ibom");
            comboBox1.Items.Add("Anambra");
            comboBox1.Items.Add("Bauchi");
            comboBox1.Items.Add("Bayelsa");
            comboBox1.Items.Add("Benue");
            comboBox1.Items.Add("Borno");
            comboBox1.Items.Add("Cross River");
            comboBox1.Items.Add("Delta");
            comboBox1.Items.Add("Ebonyi");
            comboBox1.Items.Add("Edo");
            comboBox1.Items.Add("Ekiti");
            comboBox1.Items.Add("Enugu");
            comboBox1.Items.Add("Gombe");
            comboBox1.Items.Add("Imo");
            comboBox1.Items.Add("Jigawa");
            comboBox1.Items.Add("Kaduna");
            comboBox1.Items.Add("Kano");
            comboBox1.Items.Add("Katsina");
            comboBox1.Items.Add("Kebbi");
            comboBox1.Items.Add("Kogi");
            comboBox1.Items.Add("Kwara");
            comboBox1.Items.Add("Lagos");
            comboBox1.Items.Add("Nasarawa");
            comboBox1.Items.Add("Niger");
            comboBox1.Items.Add("Ogun");
            comboBox1.Items.Add("Ondo");
            comboBox1.Items.Add("Osun");
            comboBox1.Items.Add("Oyo");
            comboBox1.Items.Add("Plateau");
            comboBox1.Items.Add("Rivers");
            comboBox1.Items.Add("Sokoto");
            comboBox1.Items.Add("Taraba");
            comboBox1.Items.Add("Yobe");
            comboBox1.Items.Add("Zamfara");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NewStaff_Load(object sender, EventArgs e)
        {

        }

        // getting profile picture
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                Image img = Image.FromFile(openDialog.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
                      
        }

        // saving data inputted on the page
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxt.Text.Length == 0 || lastNameTxt.Text.Length == 0 ||
                phoneNoTxt.Text.Length == 0 || motherMaidenNameTxt.Text.Length == 0
                || emailIdTxt.Text.Length == 0 || addressTxt.Text.Length == 0 ||
                emergencyNameTxt.Text.Length == 0 || emergencyPhoneNoTxt.Text.Length == 0
                || userNameTxt.Text.Length == 0 || passwordTxt.Text.Length == 0)
            {
                MessageBox.Show("One or more required fields have not been filled.");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Please choose a gender.");
            }
            else if (marriedRadioButton.Checked == false && 
                singleRadioButton.Checked == false &&
                divorcedRadioButton.Checked == false)
            {
                MessageBox.Show("Please choose a marital status.");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a state of origin.");
            }
            else if (ms == null)
            {
                errorUpload.Visible = true;
                MessageBox.Show("Please upload a picture for the new staff.");
            }


            else
            {
                if (maleRadioButton.Checked)
                {
                    gender = "Male";
                }
                else if (femaleRadioButton.Checked)
                {
                    gender = "Female";
                }


                if (marriedRadioButton.Checked)
                {
                    m_status = "Married";
                }
                else if (singleRadioButton.Checked)
                {
                    m_status = "Single";
                }
                else if (divorcedRadioButton.Checked)
                {
                    m_status = "Divorced";
                }

                BSE = new BankingPEntities1();
                staffAccount1 staff = new staffAccount1();
                staff.staffId = no;
                staff.First_Name = firstNameTxt.Text;
                staff.Last_Name = lastNameTxt.Text;
                staff.DOB = dateTimePicker1.Value.Date.ToString();
                staff.State_Of_Origin = comboBox1.SelectedItem.ToString();
                staff.Mother_Maiden_Name = motherMaidenNameTxt.Text;
                staff.Username = userNameTxt.Text;
                staff.Password = passwordTxt.Text;
                staff.Email_Id = emailIdTxt.Text;
                staff.Residential_Address = addressTxt.Text;
                staff.Emergency_Name = emergencyNameTxt.Text;
                staff.Emergency_Phone_No = emergencyPhoneNoTxt.Text;
                staff.Phone_No = phoneNoTxt.Text;
                staff.Gender = gender;
                staff.Marital_Status = m_status;
                staff.Date_Of_Registration = dateLabel.Text;
                staff.Last_Edited = dateLabel.Text;
                staff.Picture = ms.ToArray();
                BSE.staffAccount1.Add(staff);
                BSE.SaveChanges();


                newStaffPanel.BringToFront();

                StaffPage staffpage = new StaffPage();
                addUserControl(staffpage);

                // Visible = false;

                MessageBox.Show("A new staff has been created successfully!");

            }
        }



        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            newStaffPanel.BringToFront();
            
            NewStaff newstaffform = new NewStaff();
            addUserControl(newstaffform);
            

        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            newStaffPanel.Controls.Clear();
            newStaffPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

    }

}
