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
using DAO;
using Logic;
using System.Data.SqlClient;

namespace Start
{
    public partial class TableView : Form
    {
        Staff member;

        public TableView(Staff member)
        {
            InitializeComponent();
            //staffsv = new StaffService();
            //id.Text = staffsv.GetStaffMembers().ToString();
            date.Text = DateTime.Today.ToShortDateString();
            this.member = member;
            if (member.Roles == Staff_Types.Manager)
            {
                id.Text = "manager";
            }
            else if (member.Roles == Staff_Types.Waiter)
            {
                id.Text = "waiter";
            }
        }
 
        private void btn_back_Click(object sender, EventArgs e)
        {
            // hides TABLEVIEW form
            this.Hide();
            if (member.Roles == Staff_Types.Manager)
            {
                new Overview(member).ShowDialog();
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
