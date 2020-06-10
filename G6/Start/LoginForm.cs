using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using Logic;

namespace Start
{
    public partial class login_form : Form
    {
        StaffService service;
        Staff member; 

        public login_form()
        {
            InitializeComponent();
            member = new Staff();
            service = new StaffService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_signin;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            bool validUsername = int.TryParse(username.Text, out int id);
            string psswrd = password.Text;
            if (this.username.Text == null | this.password.Text == null)
            {
                MessageBox.Show("Please provide username and password!");
            }
            if (validUsername)
            {
                member = service.GetLoginDetails(id, psswrd);
                //if (member.Role == Staff_Types.Manager)
                //{
                this.Hide();
                new Overview(member).ShowDialog();
                this.Close();
                //}
            }
            else
            {
                MessageBox.Show("invalid username or password!");
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KitchenBar(Model.Staff_Types.Bartender).ShowDialog();
            this.Close();
        }

       
    }
}
