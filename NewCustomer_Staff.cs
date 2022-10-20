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
    public partial class NewCustomer_Staff : UserControl
    {

        string gender = string.Empty;
        string m_status = string.Empty;
        int no;
        BankingPEntities5 BSE;
        MemoryStream ms;


        public NewCustomer_Staff()
        {
            InitializeComponent();
            loadDate();
            loadState();
            loadStaff();
        }

        private void loadStaff()
        {
            BSE = new BankingPEntities5();
            var item = BSE.customerAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accountNoTxt.Text = Convert.ToString(no);

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




        // save customer details
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (firstNameTxt.Text.Length == 0 || lastNameTxt.Text.Length == 0 ||
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
                    errorUpload.Visible = true;
                    MessageBox.Show("Please upload a picture for the new customer.");
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



                    BSE = new BankingPEntities5();
                    customerAccount customer = new customerAccount();
                    customer.Account_No = no;
                    customer.First_Name = firstNameTxt.Text;
                    customer.Last_Name = lastNameTxt.Text;
                    customer.DOB = dateTimePicker1.Value.Date.ToString();
                    customer.State_Of_Origin = comboBox1.SelectedItem.ToString();
                    customer.Mother_Maiden_Name = motherMaidenNameTxt.Text;
                    customer.Balance = Convert.ToDecimal(balanceTxt.Text);
                    customer.Email_Id = emailIdTxt.Text;
                    customer.Residential_Address = addressTxt.Text;
                    customer.Emergency_Name = emergencyNameTxt.Text;
                    customer.Emergency_No = emergencyPhoneNoTxt.Text;
                    customer.Phone_No = phoneNoTxt.Text;
                    customer.Gender = gender;
                    customer.Marital_Status = m_status;
                    customer.Date_Of_Registration = dateLabel.Text;
                    customer.Last_Edited = dateLabel.Text;
                    customer.Staff_On_Duty = "KS " + CoStaffLogin.instance.getStaffId.Text;
                    customer.Picture = ms.ToArray();
                    BSE.customerAccounts.Add(customer);
                    BSE.SaveChanges();


                    newCustomerPanel.BringToFront();

                    CustomerPage customerpage = new CustomerPage();
                    addUserControl(customerpage);

                    // Visible = false;

                    MessageBox.Show("A new customer has been created successfully!");

                }
            }

            catch (Exception ex)
            {
                errorBalance.Visible = true;
                MessageBox.Show("Invalid input. Please enter a numeric value for the openning balance.");
            }
        }


        // getting profile picture
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


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            newCustomerPanel.Controls.Clear();
            newCustomerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            newCustomerPanel.BringToFront();

            NewCustomer_Staff newcustomerpage = new NewCustomer_Staff();
            addUserControl(newcustomerpage);
        }

        private void phoneNoTxt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
