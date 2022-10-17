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
    public partial class Form2 : Form
    {

        private void renderLeftSidePanel()
        {


            // panel on left side
            Panel leftsidepanel = new Panel();
            // leftsidepanel.Dock = DockStyle.Left;
            leftsidepanel.Size = new Size(200, 450);
            leftsidepanel.Location = new Point(0, 0);
            leftsidepanel.BackColor = Color.Green;
            this.Controls.Add(leftsidepanel);

            Panel ontoppanel = new Panel();
            ontoppanel.Size = new Size(100, 200);
            ontoppanel.Location = new Point(40, 50);
            ontoppanel.BackColor = Color.Red;
            leftsidepanel.Controls.Add(ontoppanel);
            ontoppanel.BringToFront();


            PictureBox beatricepic = new PictureBox();
            beatricepic.Size = new Size(60, 60);
            beatricepic.Location = new Point(0, 0);
            beatricepic.SizeMode = PictureBoxSizeMode.Zoom;
            beatricepic.Image = BankApp.Properties.Resources.User_Avatar_in_Suit_PNG;
            ontoppanel.Controls.Add(beatricepic);

        }



        public Form2()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            renderLeftSidePanel();
          
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
