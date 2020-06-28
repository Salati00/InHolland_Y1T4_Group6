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
        Dictionary<int, Label> PendingLabels;
        Dictionary<int, Label> ReadyLabels;

        public TableView(Staff member)
        {
            PendingLabels = new Dictionary<int, Label>();
            ReadyLabels = new Dictionary<int, Label>();
            InitializeComponent();
            tableService = new TableService();
            this.member = member;
            Tmr_Refresh.Enabled = true;
            LoadLabels("RT[0-9]+", ReadyLabels);
            LoadLabels("PT[0-9]+", PendingLabels);
            CheckReadyServe();
        }

        private void LoadLabels(string pattern, Dictionary<int, Label> Dic)
        {
            foreach (var item in Controls.OfType<Label>().ToList().Where(x => Regex.IsMatch(x.Name, pattern)).ToList())
            {
                int number = Convert.ToInt32(item.Tag);
                Dic.Add(number, item);
            }
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
                new login_form().ShowDialog();
            }
            this.Close();
        }

        private void Table_Click_Handler(object sender, EventArgs e)
        {
            SingleTable table = new SingleTable(tableService.GetTableFromInt(Convert.ToInt32(Regex.Match(((Button)sender).Name, @"[0-9]+").Value)), member);
            table.ShowDialog();
            /*
            List<Table> tabs = tableService.GetAllTables();
            ChangeTableStatus(tabs[1]);
            */
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            Lbl_ID.Text = $"{member.Name}, you are signed in as a {member.Role}";
            date.Text = DateTime.Today.ToShortDateString();
            List<Table> tabList = tableService.GetAllTables();
            InitializeTableStatus(tabList);
            UpdateReadyLabels();
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

        private void ChangeTableStatus(Table table)
        {
            SingleTable sTable = new SingleTable(table);
            DialogResult result = sTable.ShowDialog();

            if (result == DialogResult.OK) // reserved
            {
                try
                {
                    tableService.ChangeTableStatus(table, Table_Status.Reserved);
                    MessageBox.Show("This table has been reserved");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed - " + ex.Message);
                }
            }
            else if (result == DialogResult.No) // cancel
            {
                try
                {
                    tableService.ChangeTableStatus(table, Table_Status.Available);
                    MessageBox.Show("This table has been canceled");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed - " + ex.Message);
                }
            }
            else if (result == DialogResult.Yes) // occupied
            {
                try
                {
                    tableService.ChangeTableStatus(table, Table_Status.Occupied);
                    MessageBox.Show("This table is occupied");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed - " + ex.Message);
                }
            }
            List<Table> tabList = tableService.GetAllTables();
            InitializeTableStatus(tabList);
        }

        private void Tmr_Refresh_Tick(object sender, EventArgs e)
        {
            UpdateReadyLabels();
        }

        private void UpdateReadyLabels()
        {
            List<Table> tabList = tableService.GetAllTables();
            InitializeTableStatus(tabList);
            ResetLabels();
            CheckReadyServe();
            CheckPending();
        }

        private void ResetLabels()
        {
            this.Controls.OfType<Label>().ToList().Where(x => Regex.IsMatch(x.Name, "T[0-9]+")).ToList().ForEach(x => x.Visible = false);
        }

        private void CheckReadyServe()
        {
            List<Table> tabls = tableService.GetTablesWithState(Order_Status.Ready);

            foreach (var item in tabls)
            {
                (ReadyLabels[item.Table_Number]).Visible = true;
            }
        }

        private void CheckPending()
        {
            List<Table> tabls = tableService.GetTablesWithState(Order_Status.Pending);

            foreach (var item in tabls)
            {
                (PendingLabels[item.Table_Number]).Visible = true;
            }
        }
    }
}
