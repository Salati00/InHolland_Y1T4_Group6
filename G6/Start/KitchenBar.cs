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

namespace Start                                 // 641672
{
    public partial class KitchenBar : Form
    {
        private List<ListView> allOrderLists;
        private List<Order> allOrders;
        private List<Order> AppearingOrders;
        private List<OrderItem> allOrderItems;

        private Staff_Type staffType;
        private bool IsBar;

        private KitchenBarService service;
        private ListView lastServedList;
        private Order lastServedOrder;
        private int lastServedPosition;
        
        private int pageNumber = 1;
        private int totalItems;

        public KitchenBar(Staff_Type type) 
        {
            InitializeComponent();

            this.staffType = type;


            recallpanel.Hide();
            service = new KitchenBarService();
            FillInfo();
        }
         
                                   
        void FillInfo()
        {
            allOrderLists = new List<ListView>();
            allOrders = service.GetOrders();
            allOrderItems = new List<OrderItem>();
            totalItems = service.CountOrderItems();
            AppearingOrders = new List<Order>();

            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            IsBar = false;
            if (staffType == Staff_Type.Bartender)
            {
                this.Text = "Chapeau Bar";
                IsBar = true;
            }

            PanelOrders.Controls.Clear();
            foreach (Order order in allOrders)
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
                    AppearingOrders.Add(order);
                }
 
                allOrderLists.Add(list);
                
            }
            PageProperties();
        }
        public void OrderItems(ListView list,Order order)
        {

            int count = -1;
            while (true) 
            {
                count++;
                bool noMatch;
                do
                {
                    noMatch = false;
                    try
                    {
                        if ((IsBar && order.OrderItems[count].cardID != 3) || ((!IsBar && order.OrderItems[count].cardID == 3))||order.OrderItems[count].Status>0)
                        {
                            order.OrderItems.Remove(order.OrderItems[count]);
                            noMatch = true;
                        }
                    }   catch { }
                }   while (noMatch);

                try
                {
                    ItemsStyle(list, order, count);
                }
                catch
                {
                    
                    if (count >= 7)
                    {
                        list.Items.Add($"  Table: {order.Table_ID:D2}");
                        list.Items[count].SubItems.Add("Ready");
                        break;
                    }
                    else
                    {
                        list.Items.Add("");
                    }
                    continue;
                }
                            
                list.Items[count].Font = new Font("Arial", 14);
            }
            list.View = View.Details;
            list.FullRowSelect = true;     
            list.Items[list.Items.Count - 1].UseItemStyleForSubItems = false;
            try
            {
                ReadyColors(list,order);
            }
            catch
            { 
                list.Items[list.Items.Count - 1].SubItems.Add("Ready");
                ReadyColors(list,order);
            }
                
        }

        public void ReadyColors(ListView list,Order order)
        {
            list.Items[list.Items.Count - 1].SubItems[0].ForeColor = System.Drawing.Color.DimGray;
            list.Items[list.Items.Count - 1].SubItems[1].ForeColor = System.Drawing.Color.White;
            list.Items[list.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Black;
            
        }

        public void ItemsStyle(ListView list, Order order, int i)
        {

            list.Items.Add($"   {order.OrderItems[i].Quantity}x  {order.OrderItems[i].MenuItem.Name}");
            allOrderItems.Add(order.OrderItems[i]);

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
                OrderIsReady(lastServedOrder, 2);
            }
            else if (list.Items[list.Items.Count-1].Selected)
            {
                lastServedList = list;
                lastServedPosition = PanelOrders.Controls.IndexOf(list);
                try
                {
                    lastServedOrder = AppearingOrders[PanelOrders.Controls.IndexOf(list)];
                }
                catch { }
               
                OrderIsReady(lastServedOrder, 2);

                AppearingOrders.Remove(lastServedOrder);
                PanelOrders.Controls.Remove(list);
                PageProperties();

                if (lastServedList.Columns[0].Text[0] != 'R')
                {    
                    lastServedList.Columns[0].Text = "Recalled " + lastServedList.Columns[0].Text;
                }
            }
        }
        

        public void OrderIsReady(Order order,int state)
        {
            foreach (OrderItem item in allOrderItems)
            {
                if (order.OrderItems.Contains(item))
                {
                    service.StateOrderItem(item.ItemID, state);
                }
            }
        }


        private void recall_Click_1(object sender, EventArgs e)
        {
            if (lastServedList!=null)
            {
                if (recallpanel.Visible)
                {
                    recallpanel.Hide();
                    OrderIsReady(lastServedOrder, 2);
                }
                else
                {
                    lastServedList.Items[lastServedList.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Maroon;
                    recallpanel.Show();
                    OrderIsReady(lastServedOrder, 1);
                }

                recallpanel.Controls.Clear();
                recallpanel.Controls.Add(lastServedList);
                lastServedList.Location = new System.Drawing.Point(1,1);

    

                lastServedList.Click += new EventHandler(this.ClickOrder);

            }


        }

        private void listViewrecall_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             recallpanel.Hide();

        }


        

        private void right_Click(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                if (PanelOrders.Controls[PanelOrders.Controls.Count - 5].Visible)
                {
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
                    PageProperties();
                }
            }
            catch { }

           
        }

        private void left_Click(object sender, EventArgs e)
        {
            int counter = 4;

            try
            {
                if (!PanelOrders.Controls[PanelOrders.Controls.Count - 1].Visible)                
                    counter = PanelOrders.Controls.Count % 4;
                

                for (int order = PanelOrders.Controls.Count - 1; order >= 0; order--)
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
            catch { }
            PageProperties();
            
        }

        public void PageProperties()
        {
            int pages;
            if (PanelOrders.Controls.Count % 4 == 0)
                pages = allOrderLists.Count / 4;
            else if (PanelOrders.Controls.Count > 4)
                pages = (allOrderLists.Count / 4) + 1;
            else
                pages = 1;

            pagelbl.Text = $"{this.Text} Page: {pageNumber}/{pages}";

            if (pageNumber > 1) 
            {
                left.ForeColor = System.Drawing.Color.Maroon;
            }
            else
            {
                left.ForeColor = System.Drawing.Color.Black;
            }
            if(pageNumber >= pages)
            {
                right.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                right.ForeColor = System.Drawing.Color.Maroon;
            }

        }

        

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ListView list in allOrderLists)
            {
                //if (DateTime.Now.Subtract(allOrders[counter].Time).ToString(@"hh\:mm\:ss").Substring(0, 2) == "00")
                    list.Columns[1].Text = DateTime.Now.Subtract(allOrders[counter].Time).ToString(@"mm\:ss");
                //else
                //    list.Columns[1].Text = DateTime.Now.Subtract(allOrders[counter].Time).ToString(@"hh\:mm\:ss");


                counter++;
            }
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");
            int samePage = pageNumber - 1;
            if(totalItems != service.CountOrderItems())
            {
                
                FillInfo();
                for (int page = 0; page < samePage; page++)
                {
                    right_Click(new object(),new EventArgs());
                }
            }
            

        }

        


        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
