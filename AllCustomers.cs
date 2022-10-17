﻿using System;
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
    public partial class AllCustomers : UserControl
    {
        public AllCustomers()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            bindgrid();
        }

        private void bindgrid()
        {
            BankingPEntities1 bs = new BankingPEntities1();
            var item = bs.customerAccounts.ToList();
            dataGridView1.DataSource = item;

            // throw new NotImplementedException();
        }
    }
}
