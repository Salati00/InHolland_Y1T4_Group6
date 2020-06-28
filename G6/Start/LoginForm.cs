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

        //private static login_form inst;
        //public static login_form GetForm
        //{
        //    get
        //    {
        //        if (inst == null || inst.IsDisposed)
        //            inst = new login_form();
        //        return inst;
        //    }
        //}

        public login_form()
        {
            InitializeComponent();
            service = new StaffService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = btn_signin;
            InitializeCombobox();

        }

        private void InitializeCombobox()
        {
            List<Staff> Users = service.GetStaffMembers();
            Dictionary<int, string> Wrapper = new Dictionary<int, string>();
            foreach (var item in Users)
            {
                Wrapper.Add(item.Staff_ID, $"{item.Staff_ID} | {item.Name} | {item.Role}");
            }
            Cmb_Username.ValueMember = "Key";
            Cmb_Username.DisplayMember = "Value";
            Cmb_Username.DataSource = new BindingSource(Wrapper, null);
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                MessageBox.Show("Please provide password!");
            }
            else
            {
                Staff member = service.DoLogin(Convert.ToInt32(Cmb_Username.SelectedValue), password.Text);

                if (member is null)
                {
                    MessageBox.Show("invalid username or password!");
                }
                else
                {
                    this.Hide();
                    switch (member.Role)
                    {
                        case Staff_Type.Bartender:
                            new KitchenBar(Staff_Type.Bartender).ShowDialog();
                            //this.Close();
                            break;
                        case Staff_Type.Chef:
                            new KitchenBar(Staff_Type.Chef).ShowDialog();
                            //this.Close();
                            break;
                        case Staff_Type.Waiter:
                            new TableView(member).ShowDialog();
                            //this.Close();
                            break;
                        case Staff_Type.Manager:
                        default:
                            new Overview(member).ShowDialog();
                            //this.Close();
                            break;
                    }
                    this.Close();
                }

            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //0 code means no error
        }



        private void TextEnterNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void login_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
