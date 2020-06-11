using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Overview overview;
        Staff_Types staffType;
        KitchenBarService service;
        ListView lastServed;
        int pageNumber = 1;
        List<ListView> allOrderLists;
        List<Order> orders;
        bool IsBar;

        public KitchenBar(Staff_Types type, Overview overview) 
        {
            InitializeComponent();

            this.staffType = type;
            this.overview = overview;


            recallpanel.Hide();
            service = new KitchenBarService();
            FillInfo();
        }
         
                                   //               149
                                   //               paswrd149
        void FillInfo()
        {
            allOrderLists = new List<ListView>();
            orders = service.GetOrders();

            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            IsBar = false;
            if (staffType == Staff_Types.Bartender)
            {
                this.Text = "Bar";
                IsBar = true;

            }

            PanelOrders.Controls.Clear();
            foreach (Order order in orders)
            {
                


                ListView list = new ListView();
                list.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                list.Width  = (PanelOrders.Width / 2) - (PanelOrders.Width / 30); 
                list.Columns.Add($"order {order.Order_ID:D3}", list.Width - (list.Width / 4));
                list.Columns.Add(DateTime.Now.Subtract(order.Time).ToString(@"mm\:ss"), -2, System.Windows.Forms.HorizontalAlignment.Center);

                OrderItems(list,order);
                if (list.Items[0].Text != "")
                {
                    PanelOrders.Controls.Add(list);
                    list.Click += new EventHandler(this.ClickOrder);
                }
                allOrderLists.Add(list);
                
            }

        }
        public void OrderItems(ListView list,Order order)
        {
            
           
            for (int i = 0; i < 8; i++)
            {
                bool noMatch;
                do
                {
                    noMatch = false;
                    try
                    {
                        if ((IsBar && order.OrderItems[i].cardID != 3) || ((!IsBar && order.OrderItems[i].cardID == 3))||order.OrderItems[i].Status>0)
                        {
                            order.OrderItems.Remove(order.OrderItems[i]);
                            noMatch = true;
                        }
                    }
                    catch { }
                }
                while (noMatch);

                try
                {
                    ItemsStyle(list, order, i);
                }
                catch
                {
                    list.Items.Add("");
                    if (i >= 7)
                    {
                        
                        list.Items[i].SubItems.Add("Remove");
                        break;
                    }
                    continue;
                }
                            
                list.Items[i].Font = new Font("Arial", 14);
            }

            list.View = View.Details;
            list.FullRowSelect = true;
            //  list.GridLines = true;

            list.Items[list.Items.Count - 1].UseItemStyleForSubItems = false;
            list.Items[list.Items.Count - 1].SubItems[1].ForeColor = System.Drawing.Color.White;
            list.Items[list.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Black;
                
        }

        public void ItemsStyle(ListView list, Order order, int i)
        {

            list.Items.Add($"   {order.OrderItems[i].Quantity}x  {order.OrderItems[i].MenuItem.Name}");
         //   list.Items[i].Tag = order.OrderItems[i].ItemID;

            if (order.OrderItems[i].Comment != null)
            {
                list.Items[i].SubItems.Add(order.OrderItems[i].Comment);
                list.Items[i].UseItemStyleForSubItems = false;
                list.Items[i].SubItems[1].ForeColor = System.Drawing.Color.Red;
                list.Items[i].SubItems[1].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[i].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[i].SubItems[1].Font = new Font("Arial", 14);

            }


        }

        public void ClickOrder(object sender, EventArgs e)
        {
            ListView list = (ListView)sender;

            if (recallpanel.Visible&&( list.Columns[0].Text[0] != 'R'|| list.Items[list.Items.Count - 1].Selected))
            {
                recallpanel.Hide();
              //  service.StateOrderItem(, 2);
            }
            else if (list.Items[list.Items.Count-1].Selected)
            {
                lastServed = list;
                PanelOrders.Controls.Remove(list);

                if (lastServed.Columns[0].Text[0] != 'R')
                {
                    lastServed.Columns[0].Text = "Recalled " + lastServed.Columns[0].Text;
                }
               // service.StateOrderItem(, 2);
            }


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
             
            overview.ShowDialog();
            this.Close();
        }


        private void KitchenBar_Load(object sender, EventArgs e) 
        {
            
        }
        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (ListView list in allOrderLists)
            {
                list.Columns[1].Text = DateTime.Now.Subtract(orders[i].Time).ToString(@"mm\:ss");

                i++;
            }
            i = 0;
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            //List<Order> ForCount = service.GetOrders();
            //if (orders.Count != ForCount.Count)
            //{
            //    FillInfo();
            //}
            
            
           
            
        }

        



    }
}
