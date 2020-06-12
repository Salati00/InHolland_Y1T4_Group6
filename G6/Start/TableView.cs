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
        List<Table> tabList;
        public TableView(Staff member)
        {
            InitializeComponent();
            tab = new TableService();
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
            date.Text = DateTime.Today.ToShortDateString();
            tabList = tab.GetAllTables();
            InitializeTableStatus(tabList);
        }

        private List<Button> ButtonList()
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(t1);
            buttons.Add(t2);
            buttons.Add(t3);
            buttons.Add(t4);
            buttons.Add(t5);
            buttons.Add(t6);
            buttons.Add(t7);
            buttons.Add(t8);
            buttons.Add(t9);
            buttons.Add(t10);
            return buttons;
        }

        public void InitializeTableStatus(List<Table> tab)
        {
            List<Button> buttons = ButtonList();
            for (int i = 0; i < tab.Count; i++)
            {
                if (tab[i].Status == Table_Status.Available)
                {
                    buttons[i].BackColor = Color.White;
                }
                else if (tab[i].Status == Table_Status.Occupied)
                {
                    buttons[i].BackColor = Color.Blue;
                    buttons[i].ForeColor = Color.White;
                }
                else
                {
                    buttons[i].BackColor = Color.Red;
                    buttons[i].ForeColor = Color.White;
                }
            }
        }
    }
}
