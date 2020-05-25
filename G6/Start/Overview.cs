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
        public Overview()
        {
            InitializeComponent();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Ordering frm = new Ordering();
            frm.ShowDialog();
        }

        private void btn_kitchen_Click(object sender, EventArgs e)
        {
            KitchenBar kitchenBar = new KitchenBar("kitchen");
            kitchenBar.Show();
        }

        private void btn_bar_Click(object sender, EventArgs e)
        {
            KitchenBar kitchenBar = new KitchenBar("bar");
            kitchenBar.Show();
        }

        public void btn_signout_Click(object sender, EventArgs e)
        {
            // showing LOGIN form
            login_form login = new login_form();
            login.Visible = false;
            login_form.ActiveForm.Show();
            
            // hiding OVERVIEW form
            Overview.ActiveForm.Hide();
        }
    }
}
