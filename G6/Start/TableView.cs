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
using System.Drawing.Text;

namespace Start
{
    public partial class TableView : Form
    {
        Staff member;
        TableService tableService;

        public TableView(Staff member)
        {
            InitializeComponent();
            tableService = new TableService();
            this.member = member;
            Tmr_Refresh.Enabled = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (member.Role == Staff_Type.Manager)
            {
                new Overview(member).ShowDialog();
            }
            else
            {
                login_form.GetForm.ShowDialog();
            }
            this.Close();
        }

        private void Table_Click_Handler(object sender, EventArgs e)
        {
            SingleTable table = new SingleTable(tableService.GetTableFromInt(Convert.ToInt32(Regex.Match(((Button)sender).Name, @"[0-9]+").Value)), member);
            table.ShowDialog();
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            Lbl_ID.Text = member.Role.ToString();
            date.Text = DateTime.Today.ToShortDateString();
            List<Table> tabList = tableService.GetAllTables();
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

        private void InitializeTableStatus(List<Table> tab)
        {
            List<Button> buttons = ButtonList();
            for (int i = 0; i < tab.Count; i++)
            {
                if (tab[i].Status == Table_Status.Available)
                {
                    buttons[i].BackColor = Color.White;
                    buttons[i].ForeColor = Color.Black;
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

        private void Tmr_Refresh_Tick(object sender, EventArgs e)
        {
            List<Table> tabList = tableService.GetAllTables();
            InitializeTableStatus(tabList);
            CheckReadyServe();
        }

        private void CheckReadyServe()
        {
            List<Table> tabls = tableService.GetTablesWithOrders();

            List<Label> listlab = Controls.OfType<Label>().ToList();

            foreach (var item in listlab)
            {
                if (Regex.IsMatch(item.Name, "T[0-9]+"))
                {
                    item.Visible = false;
                    int num = Convert.ToInt32(Regex.Match(item.Name, "[0-9]+").Groups[0].Value);
                    foreach (var o in tabls)
                    {
                        if (num == o.Table_Number)
                        {
                            item.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
