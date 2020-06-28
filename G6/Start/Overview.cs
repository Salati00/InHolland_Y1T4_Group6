using Model;
using System;
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
    public partial class Overview : Form
    {
        Staff member;
        public Overview(Staff member)
        {
            InitializeComponent();
            this.member = member;
            Initialize();
        }

        private void Initialize()
        {
            lbl_name.Text = member.Name.ToString();
            lbl_role.Text = member.Role.ToString();
        }

        private void ShowForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            ShowForm(new Ordering(member));
        }

        private void btn_kitchen_Click(object sender, EventArgs e)
        {
            ShowForm(new KitchenBar(Staff_Type.Chef));
        }

        private void btn_bar_Click(object sender, EventArgs e)
        {
            ShowForm(new KitchenBar(Staff_Type.Bartender));
        }

        public void btn_signout_Click(object sender, EventArgs e)
        {
            //ShowForm(new login_form());
            this.Close();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            ShowForm(new TableView(member));
        }

        private void Overview_Load(object sender, EventArgs e)
        {
        }

        private void Overview_FormClosing(object sender, FormClosingEventArgs e)
        {
            new login_form().ShowDialog();
        }
    }
}
