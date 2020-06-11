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
        Overview ov;

        private static login_form inst;
        public static login_form GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new login_form();
                return inst;
            }
        }

        public login_form()
        {
            InitializeComponent();
            service = new StaffService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.AcceptButton = btn_signin;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (username.Text == null || password.Text == null)
            {
                MessageBox.Show("Please provide username and password!");
            }
            else
            {
                member = service.DoLogin(Convert.ToInt32(username.Text), Convert.ToInt32(password.Text));

                if(member.Staff_ID == -1)
                {
                    MessageBox.Show("invalid username or password!");
                }
                else
                {
                    this.Hide();
                    ov = new Overview(member);
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Btn_Temp1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ov = new Overview(new Staff() { Role = Staff_Type.Bartender });

            /*new KitchenBar(Staff_Type.Bartender).ShowDialog();*/
        }

        private void TextEnterNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
