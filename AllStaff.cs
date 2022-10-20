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
    public partial class AllStaff : UserControl
    {
        public AllStaff()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            bindgrid();
        }

        private void bindgrid()
        {
            BankingPEntities5 bs = new BankingPEntities5();
            var item = bs.staffAccount1.ToList();
            dataGridView1.DataSource = item;

            // throw new NotImplementedException();
        }
    }
}
