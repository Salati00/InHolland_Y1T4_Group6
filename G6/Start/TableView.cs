using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class TableView : Form
    {
        public TableView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // hides TABLEVIEW form
            this.Hide();

            // display OVERVIEW form
            Overview ov = new Overview();
            ov.ShowDialog();

            // closes TABLEVIEW form
            this.Close();
        }
    }
}
