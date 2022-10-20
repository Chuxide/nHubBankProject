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
    public partial class EditCustomer_Staff : UserControl
    {

        BankingPEntities5 dbe;
        MemoryStream ms;
        //  BindingList<staffAccount1> bi;
        string gender = string.Empty;
        string m_status = string.Empty;

        public EditCustomer_Staff()
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




        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            editCustomerPanel.Controls.Clear();
            editCustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }



        //retrieve customer details
        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //  bi = new BindingList<staffAccount1>();
                dbe = new BankingPEntities5();
                int accountNoSearch = Convert.ToInt32(searchAccountNoTxt.Text);
                var item = dbe.customerAccounts.Where(a => a.Account_No == accountNoSearch).FirstOrDefault();
                if (item == null)
                {
                    searchErrorLabel.Visible = true;
                    MessageBox.Show("Invalid or unregistered account number.");
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
                    emergencyPhoneNoTxt.Text = item.Emergency_No;
                    balanceTxt.Text = item.Balance.ToString();
                    //  passwordTxt.Text = item.Password;
                    accountNoTxt.Text = item.Account_No.ToString();
                    dateTimePicker1.Text = item.DOB;
                    dateOfRegistrationTxt.Text = item.Date_Of_Registration;
                    lastEditedTxt.Text = item.Last_Edited;
                    staffOnDutyTxt.Text = item.Staff_On_Duty;

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
                MessageBox.Show("Invalid account number. Please enter only numeric values.");
            }
        }



        // get picture to upload
        private void uploadButton_Click_1(object sender, EventArgs e)
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




        // update customer
        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (accountNoTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No account number has been entered.");
            }

            else if (firstNameTxt.Text.Length == 0 || lastNameTxt.Text.Length == 0 ||
               phoneNoTxt.Text.Length == 0 || motherMaidenNameTxt.Text.Length == 0
               || emailIdTxt.Text.Length == 0 || addressTxt.Text.Length == 0 ||
               emergencyNameTxt.Text.Length == 0 || emergencyPhoneNoTxt.Text.Length == 0
               || balanceTxt.Text.Length == 0)
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

                dbe = new BankingPEntities5();


                int a = Convert.ToInt32(accountNoTxt.Text);
                customerAccount selectedCustomer = dbe.customerAccounts.First(s => s.Account_No.Equals(a));
                dbe.customerAccounts.Remove(selectedCustomer);
                dbe.SaveChanges();


                dbe = new BankingPEntities5();
                customerAccount customer = new customerAccount();
                customer.Account_No = a;
                customer.First_Name = firstNameTxt.Text;
                customer.Last_Name = lastNameTxt.Text;
                customer.DOB = dateTimePicker1.Value.Date.ToString();
                customer.State_Of_Origin = comboBox1.SelectedItem.ToString();
                customer.Mother_Maiden_Name = motherMaidenNameTxt.Text;
                customer.Balance = Convert.ToDecimal(balanceTxt.Text);
                //  staff.Password = passwordTxt.Text;
                customer.Email_Id = emailIdTxt.Text;
                customer.Residential_Address = addressTxt.Text;
                customer.Emergency_Name = emergencyNameTxt.Text;
                customer.Emergency_No = emergencyPhoneNoTxt.Text;
                customer.Phone_No = phoneNoTxt.Text;
                customer.Gender = gender;
                customer.Marital_Status = m_status;
                customer.Date_Of_Registration = dateOfRegistrationTxt.Text;
                customer.Last_Edited = dateLabel.Text;
                customer.Staff_On_Duty = "KS " + CoStaffLogin.instance.getStaffId.Text;
                customer.Picture = ms.ToArray();
                dbe.customerAccounts.Add(customer);
                dbe.SaveChanges();


                editCustomerPanel.BringToFront();

                CustomerPage customerpage = new CustomerPage();
                addUserControl(customerpage);

                MessageBox.Show("The customer with account number: " + accountNoTxt.Text + " has been edited successfully!");
            }
        }



        // delete customer
        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (accountNoTxt.Text.Length == 0)
            {
                searchErrorLabel.Visible = true;
                MessageBox.Show("No account number has been entered.");
            }
            else
            {
                dbe = new BankingPEntities5();
                int a = Convert.ToInt32(accountNoTxt.Text);
                customerAccount selectedCustomer = dbe.customerAccounts.First(s => s.Account_No.Equals(a));
                dbe.customerAccounts.Remove(selectedCustomer);
                dbe.SaveChanges();

                CustomerPage customerpage = new CustomerPage();
                addUserControl(customerpage);
                MessageBox.Show("The customer with account number: " + accountNoTxt.Text + " has been deleted successfully!");
            }
        }

        private void searchAccountNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emergencyPhoneNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
