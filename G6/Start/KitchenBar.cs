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
        private KitchenBarService service;            

        private ListView lastServedList;              //    the recalled order 
        private Order lastServedOrder;                //    

        private int pageNumber;
        private int ItemsAmount;
        private int pages;


        public KitchenBar(Staff_Type type) 
        {
            InitializeComponent();


                                          
            recallpanel.Hide();
            service = new KitchenBarService(type);

            if (type == Staff_Type.Bartender)            
                this.Text = "Chapeau Bar";

            pageNumber = 1;
            StartNew();
        }
        
                                   
        void StartNew()    
        {
                                       // getting orders from db
            try
            {
                Orders = service.GetOrders();
            }
            catch (Exception dbEx)
            {
                timer1.Enabled = false;
                System.Windows.MessageBox.Show(dbEx.Message);
            }

            timeLable.Text = DateTime.Now.ToString("h:mm:ss tt");

            FillOrders();
            ItemsAmount = service.CountOrderItems();            // counting items to compare it and know if there is new items added to db
        }

        public void FillOrders()
        {

            PanelOrders.Controls.Clear();

            for (int counter = 0; counter < Orders.Count; counter++)     // printing the order's listviews 
            {
              
                ListView list = new ListView(); 
                list.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                list.Width = (PanelOrders.Width / 2) - (PanelOrders.Width / 50);
                list.Columns.Add($"order {(Orders[counter].Order_ID % 1000):D3}", list.Width - (list.Width / 4));
                list.Columns.Add(DateTime.UtcNow.Subtract(Orders[counter].Time).ToString(@"mm\:ss"), -2, System.Windows.Forms.HorizontalAlignment.Center);

                OrderItems(list, Orders[counter]);
        
                PanelOrders.Controls.Add(list);
                list.Click += new EventHandler(this.ClickOrder);
                
                

            }
            PageProperties(pageNumber,true);
        }
        public void OrderItems(ListView list,Order order)              //filling the lists with order items
        {

            int count = -1;
            while (true) 
            {
                count++;
                try
                {

                    ItemsPrintStyle(list, order, count);               //printing the items with style
                }
                catch
                {                    
                    if (count >= 7)
                    {
                                                         // puting the table number and ready button in the last field of the list(usualy field 7)
                        list.Items.Add($"  Table: {order.Table_ID:D2}");          
                        list.Items[count].SubItems.Add("Ready");
                        break;
                    }
                    else
                    {
                        list.Items.Add("");                // filling empty fields with blank
                    }
                    continue;
                }
                            
                list.Items[count].Font = new Font("Arial", 14);
            }
            list.View = View.Details;
            list.FullRowSelect = true;     
            list.Items[list.Items.Count - 1].UseItemStyleForSubItems = false;
        
            ReadyButtonStyle(list);         
            
        }

        public void ReadyButtonStyle(ListView list)           // giving colors to the ready button
        {
            list.Items[list.Items.Count - 1].SubItems[0].ForeColor = System.Drawing.Color.DimGray;
            list.Items[list.Items.Count - 1].SubItems[1].ForeColor = System.Drawing.Color.White;
            list.Items[list.Items.Count - 1].SubItems[1].BackColor = System.Drawing.Color.Black;
            
        }

        public void ItemsPrintStyle(ListView list, Order order, int numOfOrderItem)            //printing the orderitem with style
        {
            
            list.Items.Add($"   {order.OrderItems[numOfOrderItem].Quantity}x  {order.OrderItems[numOfOrderItem].MenuItem.Name}");
    
            
            if (order.OrderItems[numOfOrderItem].Comment != null && (order.OrderItems[numOfOrderItem].Comment != "")) 
            {
                list.Items[numOfOrderItem].SubItems.Add(order.OrderItems[numOfOrderItem].Comment);
                list.Items[numOfOrderItem].UseItemStyleForSubItems = false;
                list.Items[numOfOrderItem].SubItems[1].ForeColor = System.Drawing.Color.Red;
                list.Items[numOfOrderItem].SubItems[1].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[numOfOrderItem].BackColor = System.Drawing.Color.WhiteSmoke;
                list.Items[numOfOrderItem].SubItems[1].Font = new Font("Arial", 14);

            }


        }

        public void ClickOrder(object sender, EventArgs e)              // will be back
        {
            ListView list = (ListView)sender;

                                                      // recalled order is clicked or another order while recalled order is visible
            if (recallpanel.Visible && (list.Columns[0].Text[0] != 'R' || list.Items[list.Items.Count - 1].Selected))
            {
                recallpanel.Hide();
                OrderIsReady(lastServedOrder, Order_Status.Ready);
            }
            else if (list.Items[list.Items.Count-1].Selected)                 // Ready button clicked
            {
                lastServedList = list;
  
                try
                {
                    lastServedOrder = Orders[PanelOrders.Controls.IndexOf(list)];
                }
                catch { }
               
                OrderIsReady(lastServedOrder, Order_Status.Ready);              //marking order as ready 

                Orders.Remove(lastServedOrder);                                 
                PanelOrders.Controls.Remove(list);
                PageProperties(pageNumber,false);

                if (lastServedList.Columns[0].Text[0] != 'R')                  // adding the word "Recalled" next to the recalled order id
                    lastServedList.Columns[0].Text = "Recalled " + lastServedList.Columns[0].Text;
                
            }
        }
        

        public void OrderIsReady(Order order,Order_Status state)               //marking order as ready or pending
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


        private void recall_Click_1(object sender, EventArgs e)         // clicking recall button
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
                                                // refreshing the recalled order pannel/lisview
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


        

        private void right_Click(object sender, EventArgs e)           //click the (next page(>)) button
        {
            if (pageNumber < pages)
                PageProperties(++pageNumber, true);
        }

        private void left_Click(object sender, EventArgs e)            //click the (previous page(<)) button
        {
            if (pageNumber > 1)
                PageProperties(--pageNumber, true);
            
        }

        public void PageProperties(int page,bool changingPage)
        {
                                                        // setting current page
            if (PanelOrders.Controls.Count % 4 == 0)
                pages = PanelOrders.Controls.Count / 4;
            else
                pages = (PanelOrders.Controls.Count / 4) + 1;


            if (changingPage)                                   // go to another page
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

                                                               // if there is a previous page left button will be red  
            if (pageNumber > 1)                                // if there is a next page right button will be red
                left.ForeColor = System.Drawing.Color.Maroon;
            else
                left.ForeColor = System.Drawing.Color.Black;
            if (pageNumber >= pages)
                right.ForeColor = System.Drawing.Color.Black;
            else
                right.ForeColor = System.Drawing.Color.Maroon;


        }



        private void Home_Click(object sender, EventArgs e)          // going to the home page
        { 
            timer1.Enabled = false;
            this.Close();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ListView list in PanelOrders.Controls)                     // refreshin the time of each orderlist
            {
                if (DateTime.UtcNow.Subtract(Orders[counter].Time).ToString(@"hh\:mm\:ss").Substring(0, 2) == "00")
                    list.Columns[1].Text = DateTime.Now.Subtract(Orders[counter].Time).ToString(@"mm\:ss");
                else
                    list.Columns[1].Text = DateTime.Now.Subtract(Orders[counter].Time).ToString(@"hh\:mm\:ss");
                counter++;
            }
            timeLable.Text = DateTime.Now.ToString("h:mm:ss tt");             // refreshing time


            try
            {                                 // checking if there is new order items in the db and, add them with the other orders
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
