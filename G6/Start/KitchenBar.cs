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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;

namespace Start
{
    public partial class KitchenBar : Form
    {

        Staff_Types type;
        KitchenBarService service;
        ListView lastServed;
        int pageNumber = 1;

        public KitchenBar(Staff_Types type)
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
            
            List<Order> orders = service.GetOrders();

            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            if (type == Staff_Types.Bartender)
                this.Text = "Bar";

            //  for (int i = 0; i < 11; i++)
            foreach (Order order in orders)
            {
                


                ListView list = new ListView();
                list.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                list.Width  = (PanelOrders.Width / 2) - (PanelOrders.Width / 30); 
                list.Columns.Add($"order {order.Order_ID:D3}", list.Width - (list.Width / 4));
                list.Columns.Add((TimeSpan.Parse(DateTime.Now.ToString("MM:SS")) - order.Time).ToString("MM:SS"), -2, System.Windows.Forms.HorizontalAlignment.Center);

                OrderItems(list,order);
                PanelOrders.Controls.Add(list);

                
                list.Click += new EventHandler(this.ClickOrder);
            }

        }
        public void OrderItems(ListView list,Order order)
        {
           

            for (int i = 0; i < 8; i++)
            {

                list.Items.Add($"   {order.ordersItems[i].Quantity}x  {order.ordersItems[i].menuItem.Name}");
                if (order.ordersItems[i].Comment != null)
                list.Items[i].SubItems.Add(order.ordersItems[i].Comment);

                if (i == 6)
                {
                    list.Items.Add("");
                    list.Items[i].SubItems.Add("Remove");
                    break;
                }
               
                list.Items[i].Font = new Font("Arial", 14);
                
            }

            list.View = View.Details;
            list.FullRowSelect = true;
            

            list.Items[7].UseItemStyleForSubItems = false;
            list.Items[7].SubItems[1].ForeColor = System.Drawing.Color.White;
            list.Items[7].SubItems[1].BackColor = System.Drawing.Color.Black;
                
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


        

        private void right_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Control order in PanelOrders.Controls)
            {
                if (order.Visible)
                {
                    counter++;
                    order.Hide();
                }
                if (counter == 4)
                {
                    pageNumber++;
                    break;
                }
            }
        }

        private void left_Click(object sender, EventArgs e)
        {
            int counter = 4;

            if (!PanelOrders.Controls[PanelOrders.Controls.Count - 1].Visible)
                counter = PanelOrders.Controls.Count % 4;
            
            for (int order = PanelOrders.Controls.Count-1; order >= 0; order--)
            {

                if (!PanelOrders.Controls[order].Visible)
                {
                    counter--;
                    PanelOrders.Controls[order].Show();
                }

                if (counter == 0)
                {
                    pageNumber--;
                    break;
                }
            }
        }



        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Overview.ActiveForm.Show();
            this.Show();
        }


        private void KitchenBar_Load(object sender, EventArgs e) 
        {
            
        }
        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
