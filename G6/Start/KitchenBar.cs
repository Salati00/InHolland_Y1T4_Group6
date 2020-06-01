using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace Start
{
    public partial class KitchenBar : Form
    {

        Staff_Types type;
        KitchenBarService service;

        public KitchenBar(Staff_Types type)//receive staff instead of type
        {
            InitializeComponent();

            this.type = type;
            service = new KitchenBarService();
            List<OrderItem> orders = service.GetOrders();
        }
         

        void FillInfo()
        {
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");
            recallpanel.Hide();

            if (type == Staff_Types.Bartender)
                this.Text = "Bar";

            for (int i = 0; i < 4; i++)
        //      foreach(Order order in orders)
            {
                
                ListView button = new ListView();
                button.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                button.Width  = (PanelOrders.Width / 2) - (PanelOrders.Width / 30); ;
                PanelOrders.Controls.Add(button);
                
                OrderText(button);
                button.Click += new EventHandler(this.ClickOrder);
            }

        }


        public void ClickOrder(object sender, EventArgs e)
        {
            ListView button = (ListView)sender;            
            PanelOrders.Controls.Remove(button);
        

        }


        public void NotifyWaiter()
        {
             
        }

        public void OrderText(ListView b)
        {




            b.Columns.Add("order 090", b.Width - (b.Width/4));
            b.Columns.Add("08:40", -2, System.Windows.Forms.HorizontalAlignment.Center);

            //b.Columns.Add("haha", -2, HorizontalAlignment.Right);


            // Place a check mark next to the item.


            for (int i = 0; i < 8; i++)
            {
                b.Items.Add(" 4x   not chichen and not not chicken");
                b.Items[i].Font = new Font("Arial", 14);
                if (i == 6)
                {
                    b.Items.Add("");
                    b.Items[7].SubItems.Add("Remove");
                    break;
                }
            }



            // Set the view to show details.
            b.View = View.Details;
            // Allow the user to edit item text.
            //     b.LabelEdit = true;
            // Allow the user to rearrange columns.
            //   b.AllowColumnReorder = true;
            // Display check boxes.

            // Select the item and subitems when selection is made.
            b.FullRowSelect = true;
            // Display grid lines.
            //  b.GridLines = true;
            // Sort the items in the list in ascending order.
            //      b.Sorting = SortOrder.Ascending;


            b.Items[7].UseItemStyleForSubItems = false;
            b.Items[7].SubItems[1].ForeColor = System.Drawing.Color.White;
            b.Items[7].SubItems[1].BackColor = System.Drawing.Color.Black;
            
           
           
            
        }

       

        private void recall_Click_1(object sender, EventArgs e)
        {
            if (recallpanel.Visible)
                recallpanel.Hide();
            else
                recallpanel.Show();
        }

        private void listViewrecall_SelectedIndexChanged(object sender, EventArgs e)
        {
             recallpanel.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            Overview.ActiveForm.Activate();
        }







      

       

      

        


        private void KitchenBar_Load(object sender, EventArgs e) 
        {
            
        }
        private void listViewrecall_MouseHover(object sender, EventArgs e)
        {

        }
        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
