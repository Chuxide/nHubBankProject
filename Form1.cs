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
    public partial class Form1 : Form
    {


        private Panel renderPictureBox()
        {
            Panel pictureBoxPanel = new Panel();
            pictureBoxPanel.Dock = DockStyle.Top;
            pictureBoxPanel.Size = new Size(219, 152);
            pictureBoxPanel.BackColor = Color.Transparent;

            //picturebox in panel
            PictureBox adminPic = new PictureBox();
            adminPic.Image = BankApp.Properties.Resources.User_Avatar_in_Suit_PNG;
            adminPic.Size = new Size(114, 107);
            adminPic.Location = new Point(52, 12);
            adminPic.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPanel.Controls.Add(adminPic);

            return pictureBoxPanel;

        }

        private void renderNavPanel()
        {

            // final panel
            Panel navPanel = new Panel();
            navPanel.Size = new Size(235, 558);
            navPanel.Dock = DockStyle.Left;
            navPanel.BackColor = Color.Gray;

            this.Controls.Add(navPanel);

            // picturebox
            Panel pictureBoxPanel = renderPictureBox();
            navPanel.Controls.Add(pictureBoxPanel);


          /*  int i = 0;
            Panel navPanel = new Panel();
            navPanel.Dock = DockStyle.Fill;
          */
        }
        public Form1()
        {
           
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderNavPanel();
        }
    }
}
