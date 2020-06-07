using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Start
{
    public partial class TableView : Form
    {
        Staff_Types role;
        public TableView(Staff_Types role)
        {
            InitializeComponent();
            this.role = role;
        }
 
        private void btn_back_Click(object sender, EventArgs e)
        {
            // hides TABLEVIEW form
            this.Hide();
            if (role == Staff_Types.Manager)
            {
                new Overview(role).ShowDialog();
            }
            else
            {
                // display OVERVIEW form
                new login_form().ShowDialog();
            }
            // closes TABLEVIEW form
            this.Close();
        }
    }
}
