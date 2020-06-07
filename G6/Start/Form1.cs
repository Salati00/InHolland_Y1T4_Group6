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

namespace Start
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            //btn_signin.Click -= btn_signin_Click;
            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=dbchapeau06;Persist Security Info=True;User ID=dbchapeau06;Password=Xc113m-Ed78?");
            string query = "SELECT * FROM Login_Details WHERE ID_Hash = '"+username.Text+"' AND Password_Hash = '"+password.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable db = new DataTable();
            sda.Fill(db);
            if (db.Rows[0][0].ToString() == "1")
            {
                //hiding LOGIN form
                this.Hide();

                // showing OVERVIEW form
                new Overview(Model.Staff_Types.Manager).ShowDialog();

                // closing LOGIN form
                this.Close();
            }
            else if (db.Rows[0][0].ToString() == "2")
            {
                this.Hide();
                new TableView(Model.Staff_Types.Waiter).ShowDialog();
                this.Close();
            }
            else if (db.Rows[0][0].ToString() == "3")
            {
                this.Hide();
                new KitchenBar(Model.Staff_Types.Chef).ShowDialog();
                this.Close();
            }
            else if (db.Rows[0][0].ToString() == "4")
            {
                this.Hide();
                new KitchenBar(Model.Staff_Types.Bartender).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid ID or password");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
