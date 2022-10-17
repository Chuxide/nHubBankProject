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
    public partial class EditStaff : UserControl
    {

        BankingPEntities1 dbe;
        MemoryStream ms;
        BindingList<staffAccount1> bi;
        string gender = string.Empty;
        string m_status = string.Empty;
       

        public EditStaff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            loadState();
        }



        // making drop downn list of items in state combo box
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



        // retrieving info from database to fields
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                bi = new BindingList<staffAccount1>();
                dbe = new BankingPEntities1();
                int staffIdSearch = Convert.ToInt32(searchStaffIdTxt.Text);
                var item = dbe.staffAccount1.Where(a => a.staffId == staffIdSearch).FirstOrDefault();
                if (item == null)
                {
                    searchErrorLabel.Visible = true;
                    MessageBox.Show("Invalid or unregistered staff Id.");
                }
                else
                {
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
                    dateOfRegistrationTxt.Text = item.Date_Of_Registration;
                    lastEditedTxt.Text = item.Last_Edited;

                    byte[] img = item.Picture;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);

                    if (item.Gender == "Male")
                    {
                        maleRadioButton.Checked = true;
                    }
                    else if (item.Gender == "Female")
                    {
                        femaleRadioButton.Checked = true;
                    }

                    if (item.Marital_Status == "Married")
                    {
                        marriedRadioButton.Checked = true;
                    }
                    else if (item.Marital_Status == "Single")
                    {
                        singleRadioButton.Checked = true;
                    }
                    else if (item.Marital_Status == "Divorced")
                    {
                        divorcedRadioButton.Checked = true;
                    }

                    comboBox1.Text = item.State_Of_Origin;
                }
            }

            catch (Exception ex)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("Invalid staff id. Please enter only numeric values.");
            }
        }


        // get picture to upload
        private void uploadButton_Click(object sender, EventArgs e)
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


        // delete a staff
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (staffIdTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No staff Id has been entered.");
            }
            else
            {
                dbe = new BankingPEntities1();
                string b = staffIdTxt.Text.Substring(2);
                int a = Convert.ToInt32(b);
                staffAccount1 selectedStaff = dbe.staffAccount1.First(s => s.staffId.Equals(a));
                dbe.staffAccount1.Remove(selectedStaff);
                dbe.SaveChanges();

                StaffPage staffpage = new StaffPage();
                addUserControl(staffpage);
                MessageBox.Show("The staff account with id: " + staffIdTxt.Text + " has been deleted successfully!");
            }
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            editStaffPanel.Controls.Clear();
            editStaffPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        // update staff
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (staffIdTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No staff Id has been entered.");
            }

            else if (firstNameTxt.Text.Length == 0 || lastNameTxt.Text.Length == 0 ||
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
                MessageBox.Show("Please upload a picture for the customer.");
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

                dbe = new BankingPEntities1();
                
                string b = staffIdTxt.Text.Substring(2);
                int a = Convert.ToInt32(b);
                staffAccount1 selectedStaff = dbe.staffAccount1.First(s => s.staffId.Equals(a));
                dbe.staffAccount1.Remove(selectedStaff);
                dbe.SaveChanges();


                dbe = new BankingPEntities1();
                staffAccount1 staff = new staffAccount1();
                staff.staffId = a;
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
                staff.Date_Of_Registration = dateOfRegistrationTxt.Text;
                staff.Last_Edited = dateLabel.Text;
                staff.Picture = ms.ToArray();
                dbe.staffAccount1.Add(staff);
                dbe.SaveChanges();


                editStaffPanel.BringToFront();

                StaffPage staffpage = new StaffPage();
                addUserControl(staffpage);

                // Visible = false;

                MessageBox.Show("The staff account with id: " + staffIdTxt.Text + " has been edited successfully!");
            }
        }
    }
}
