﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ordering frm = new Ordering();
            frm.ShowDialog();
        }


        private void Kitchen_Click(object sender, EventArgs e)
        {
            KitchenBar kitchenBar = new KitchenBar("kitchen");
            kitchenBar.Show();
        }

        private void Bar_Click(object sender, EventArgs e)
        {
            KitchenBar kitchenBar = new KitchenBar("bar");
            kitchenBar.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
