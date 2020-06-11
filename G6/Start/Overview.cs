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
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordering frm = new Ordering();
            frm.ShowDialog();
            this.Close();
        }

        private void btn_kitchen_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitchenBar kitchenBar = new KitchenBar(Staff_Types.Chef);
            kitchenBar.ShowDialog();
            this.Close();

        }

        private void btn_bar_Click(object sender, EventArgs e)
        {
            this.Hide();
            KitchenBar kitchenBar = new KitchenBar(Staff_Types.Bartender);
            kitchenBar.ShowDialog();
            this.Close();
        }

        public void btn_signout_Click(object sender, EventArgs e)
        {
            // hiding OVERVIEW form
            this.Hide();

            // showing LOGIN form
            login_form login = new login_form();
            login.ShowDialog();

            // closing OVERVIEW form
            this.Close();
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            // hides OVERVIEW form
            this.Hide();

            // display TABLEVIEW form
            TableView table = new TableView(member);
            table.ShowDialog();

            // closes OVERVIEW form
            this.Close();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            //if (member.Role == Staff_Types.Manager)
            //{
            //    new Overview(member).Enabled = true;
            //}
            //else
            //{
            //    new Overview(member).Enabled = false;
            //}
        }
    }
}
