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
            switch (member.Role)
            {
                case Staff_Type.Bartender:
                    ShowForm(new KitchenBar(Staff_Type.Bartender));
                    this.Close();
                    break;
                case Staff_Type.Chef:
                    ShowForm(new KitchenBar(Staff_Type.Chef));
                    this.Close();
                    break;
                case Staff_Type.Waiter:
                    ShowForm(new TableView(member));
                    this.Close();
                    break;
                case Staff_Type.Manager:
                default:
                    this.Show();
                    break;
            }
        }

        private void ShowForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            ShowForm(new Ordering());
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
            login_form.GetForm.Show();
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
            login_form.GetForm.Show();
        }
    }
}
