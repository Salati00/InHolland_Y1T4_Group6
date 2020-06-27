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
      
        private List<Order> Orders;
      //  private List<Order> AppearingOrders;
     //   private List<OrderItem> allOrderItems;

       // private Staff_Type staffType;
      //  private bool IsBar;

        private KitchenBarService service;

        private ListView lastServedList;
        private Order lastServedOrder;
      //  private int lastServedPosition;
        

        private int pageNumber = 1;
        private int ItemsAmount;
        private int pages;
   //     private List<Order> orders;




        public KitchenBar(Staff_Type type) 
        {
            InitializeComponent();

        //    this.staffType = type; //...............


            recallpanel.Hide();
            service = new KitchenBarService(type);

            if (type == Staff_Type.Bartender)
            {
                this.Text = "Chapeau Bar";
              
            }

            StartNew();
        }
         
                                   
        void StartNew()
        {
            //allOrderLists = new List<ListView>();//........
            try
            {
                Orders = service.GetOrders();
            }
            catch (Exception dbEx)
            {
                timer1.Enabled = false;
                System.Windows.MessageBox.Show(dbEx.Message);
            }


            //allOrderItems = new List<OrderItem>();
            //try
            //{
            //    totalItems = service.CountOrderItems();
            //}
            //catch (Exception dbEx)
            //{
            //    System.Windows.MessageBox.Show(dbEx.Message);
            //}

            ////////////AppearingOrders = new List<Order>();

            timee.Text = DateTime.Now.ToString("h:mm:ss tt");

            //  IsBar = false;
          //  PanelOrders.Controls.Clear();
            FillOrders();
            ItemsAmount = service.CountOrderItems();
        }

        public void FillOrders()
        {
            
            

            for (int counter = PanelOrders.Controls.Count; counter < Orders.Count; counter++)
            {

                ListView list = new ListView(); 
                list.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                list.Width = (PanelOrders.Width / 2) - (PanelOrders.Width / 50);
                list.Columns.Add($"order {Orders[counter].Order_ID:D3}", list.Width - (list.Width / 4));
                list.Columns.Add(DateTime.UtcNow.Subtract(Orders[counter].Time).ToString(@"mm\:ss"), -2, System.Windows.Forms.HorizontalAlignment.Center);

                OrderItems(list, Orders[counter]);
                if (list.Items[0].Text != "")
                {
                    PanelOrders.Controls.Add(list);
                    list.Click += new EventHandler(this.ClickOrder);
               ///     AppearingOrders.Add(order);
                }
                
                   

              ////  allOrderLists.Add(list);                             iiiiiiiiiiiiiii

            }
            PageProperties(pageNumber,false);
        }
        public void OrderItems(ListView list,Order order)
        {

            int count = -1;
            while (true) 
            {
                count++;
                try
                {
                    ItemsPrintStyle(list, order, count);
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
            //try
            //{
                ReadyButtonStyle(list/*,order*/);
            //}
            //catch
            //{ 
            //    list.Items[list.Items.Count - 1].SubItems.Add("Ready");
            //    ReadyButtonStyle(list/*,order*/);
            //}
                
        }

        public void ReadyButtonStyle(ListView list/*,Order order*/)
        {
            list.Items[list.Items.Count - 1].SubItems[0].ForeColor = System.Drawing.Color.DimGray;
            list.Items[list.Items.Count - 1].SubItems[1].ForeColor = System.Drawing.Color.White;
            list.Items[list.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Black;
            
        }

        public void ItemsPrintStyle(ListView list, Order order, int i)           // fine
        {
            
            list.Items.Add($"   {order.OrderItems[i].Quantity}x  {order.OrderItems[i].MenuItem.Name}");
            //    allOrderItems.Add(order.OrderItems[i]);

            if (order.OrderItems[i].Comment != null && (order.OrderItems[i].Comment != "")) 
            {
                list.Items[i].SubItems.Add(order.OrderItems[i].Comment);
                list.Items[i].UseItemStyleForSubItems = false;
                list.Items[i].SubItems[1].ForeColor = System.Drawing.Color.Red;
                list.Items[i].SubItems[1].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[i].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[i].SubItems[1].Font = new Font("Arial", 14);

            }


        }

        public void ClickOrder(object sender, EventArgs e)              // will be back
        {
            ListView list = (ListView)sender;

            if (recallpanel.Visible&&( list.Columns[0].Text[0] != 'R'|| list.Items[list.Items.Count - 1].Selected))
            {
                recallpanel.Hide();
                OrderIsReady(lastServedOrder, Order_Status.Ready);
            }
            else if (list.Items[list.Items.Count-1].Selected)
            {
                lastServedList = list;
          //      lastServedPosition = PanelOrders.Controls.IndexOf(list);
                try
                {
                    lastServedOrder = Orders[PanelOrders.Controls.IndexOf(list)];
                }
                catch { }
               
                OrderIsReady(lastServedOrder, Order_Status.Ready);

                Orders.Remove(lastServedOrder);
                PanelOrders.Controls.Remove(list);
                PageProperties(pageNumber,false);

                if (lastServedList.Columns[0].Text[0] != 'R')
                {    
                    lastServedList.Columns[0].Text = "Recalled " + lastServedList.Columns[0].Text;
                }
            }
        }
        

        public void OrderIsReady(Order order,Order_Status state)
        {
            foreach (OrderItem item in order.OrderItems)
            {
                if (order.OrderItems.Contains(item))
                {
                    try
                    {
                        service.StateOrderItem(item.ItemID, state);
                    }
                    catch (Exception dbEx)
                    {
                        System.Windows.MessageBox.Show(dbEx.Message);
                    }
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
                    OrderIsReady(lastServedOrder, Order_Status.Ready);
                }
                else
                {
                    lastServedList.Items[lastServedList.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Maroon;
                    recallpanel.Show();
                    OrderIsReady(lastServedOrder, Order_Status.Pending);
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
            if (pageNumber < pages)
                PageProperties(++pageNumber, true);
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
                PageProperties(--pageNumber, true);
            
        }

        public void PageProperties(int page,bool changingPage)
        {
            int pages ;
            if (PanelOrders.Controls.Count % 4 == 0)
                pages = PanelOrders.Controls.Count / 4;
            else
                pages = (PanelOrders.Controls.Count / 4) + 1;


            if (changingPage )
            {
                for (int controlNum = 0; controlNum < PanelOrders.Controls.Count; controlNum++)
                {

                    if (controlNum+1 <= (page - 1) * 4)
                        PanelOrders.Controls[controlNum].Visible = false;
                    else
                        PanelOrders.Controls[controlNum].Visible = true;

                }
            }
            pagelbl.Text = $"{this.Text} Page: {pageNumber}/{pages}";


            if (pageNumber > 1)
                left.ForeColor = System.Drawing.Color.Maroon;
            else
                left.ForeColor = System.Drawing.Color.Black;
            if (pageNumber >= pages)
                right.ForeColor = System.Drawing.Color.Black;
            else
                right.ForeColor = System.Drawing.Color.Maroon;


        }



        private void Home_Click(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ListView list in PanelOrders.Controls)
            {
                if (DateTime.UtcNow.Subtract(Orders[counter].Time).ToString(@"hh\:mm\:ss").Substring(0, 2) == "00")
                    list.Columns[1].Text = DateTime.Now.Subtract(Orders[counter].Time).ToString(@"mm\:ss");
                else
                    list.Columns[1].Text = DateTime.Now.Subtract(Orders[counter].Time).ToString(@"hh\:mm\:ss");
                counter++;
            }
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");


            try
            {
                if (ItemsAmount != service.CountOrderItems() && recallpanel.Visible == false)
                {
                    StartNew();
                    
                }
            }
            catch (Exception dbEx)
            {
                timer1.Enabled = false;
                System.Windows.MessageBox.Show("Error!", dbEx.Message);
            }

        }

        


        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
