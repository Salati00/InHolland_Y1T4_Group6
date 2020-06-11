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
using System.Text.RegularExpressions;

namespace Start
{
    public partial class TableView : Form
    {
        Staff member;
        TableService tab;

        public TableView(Staff member)
        {
            InitializeComponent();
            tab = new TableService();

            date.Text = DateTime.Today.ToShortDateString();
            this.member = member;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Table_Click_Handler(object sender, EventArgs e)
        {
            SingleTable table = new SingleTable(tab.GetTableFromInt(Convert.ToInt32(Regex.Match(((Button)sender).Name, @"[0-9]+").Value)));
            table.ShowDialog();
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            Lbl_ID.Text = member.Role.ToString();
        }
    }
}
