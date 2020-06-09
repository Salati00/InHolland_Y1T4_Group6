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
    public partial class SingleTable : Form
    {
        Table CurrentTable;
        public SingleTable(Table _CurrentTable)
        {
            CurrentTable = _CurrentTable;
            InitializeComponent();
        }

        private void Btn_AddOrder_Click(object sender, EventArgs e)
        {
            Ordering OrderForm = new Ordering(CurrentTable);
            OrderForm.ShowDialog();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingleTable_Load(object sender, EventArgs e)
        {
            Lbl_TableNum.Text = CurrentTable.Table_Number.ToString();
        }
    }
}
