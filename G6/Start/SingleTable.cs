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

        }

        private void SingleTable_Load(object sender, EventArgs e)
        {

        }
    }
}
