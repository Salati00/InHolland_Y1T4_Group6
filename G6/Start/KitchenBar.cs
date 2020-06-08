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
        ListView lastServed;

        public KitchenBar(Staff_Types type)//receive staff instead of type
        {
            InitializeComponent();

            this.type = type;
            
            recallpanel.Hide();
            service = new KitchenBarService();
            FillInfo();
        }
         
                                   //               149
                                   //               paswrd149
        void FillInfo()
        {
            List<OrderItem> orders = service.GetOrders();
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            if (type == Staff_Types.Bartender)
                this.Text = "Bar";

            for (int i = 0; i < 4; i++)
        //      foreach(Order order in orders)
            {
                
                ListView button = new ListView();
                button.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                button.Width  = (PanelOrders.Width / 2) - (PanelOrders.Width / 30); 
                button.Columns.Add("order 090", button.Width - (button.Width / 4));
                button.Columns.Add("08:40", -2, System.Windows.Forms.HorizontalAlignment.Center);

                OrderStyle(button);
                PanelOrders.Controls.Add(button);

                
                button.Click += new EventHandler(this.ClickOrder);
            }

        }


        public void ClickOrder(object sender, EventArgs e)
        {
            ListView button = (ListView)sender;

            if (recallpanel.Visible)
            {
                recallpanel.Hide();

                
            }
            else if (button.Items[7].Selected)
            {
                lastServed = button;
                PanelOrders.Controls.Remove(button);

                if (lastServed.Columns[0].Text[0] != 'R')
                {
                    lastServed.Columns[0].Text = "Recalled " + lastServed.Columns[0].Text;
                }

            }

        }


        public void NotifyWaiter()
        {
             
        }

        public void OrderStyle(ListView b)
        {


            //   b.Columns.Add("haha", -2, HorizontalAlignment.Right);   
            

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

            b.View = View.Details;
            b.FullRowSelect = true;
            

            b.Items[7].UseItemStyleForSubItems = false;
            b.Items[7].SubItems[1].ForeColor = System.Drawing.Color.White;
            b.Items[7].SubItems[1].BackColor = System.Drawing.Color.Black;
                
        }

       

        private void recall_Click_1(object sender, EventArgs e)
        {
            if (lastServed!=null)
            {
                if (recallpanel.Visible)
                    recallpanel.Hide();
                else
                    recallpanel.Show();

                recallpanel.Controls.Clear();
                recallpanel.Controls.Add(lastServed);
                lastServed.Location = new System.Drawing.Point(1,1);

    

                lastServed.Click += new EventHandler(this.ClickOrder);

            }


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
        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

     
    }
}
