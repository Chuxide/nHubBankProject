using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BankApp
{
    public partial class AdminLogin : Form
    {
        public static AdminLogin instance;
        public TextBox getAdminId;
        public AdminLogin()
        {
            InitializeComponent();
            instance = this;
            getAdminId = adminIdHolder;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            textBox2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login staff = new Login();
            staff.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BankingPEntities1 dbe = new BankingPEntities1();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                var user1 = dbe.Admins.FirstOrDefault(a => a.Username.Equals(textBox1.Text));    
                if (user1 != null)
                {
                    if (user1.Password.Equals(textBox2.Text))
                    {
                        adminIdHolder.Text = user1.Id.ToString();
                        AdminHome adminhomepage = new AdminHome();
                        adminhomepage.Show();
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
                asterixUsername.Visible = true;
                MessageBox.Show("Please enter username and password.");
            }
            /* if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                AdminHome adminhomepage = new AdminHome();
                adminhomepage.Show();
                Visible = false;
            }
            else
            {
                errorMessage.Visible = true;
            }
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
