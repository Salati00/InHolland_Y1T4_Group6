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
using System.Windows.Forms;
using System.Windows.Media;

namespace Start
{
    public partial class KitchenBar : Form
    {

      //  List<Button> buttons;
        KitchenBarService service;

        public KitchenBar(string type)//receive staff instead of type
        {
            InitializeComponent();
            //  buttons = new List<Button>();
            service = new KitchenBarService();
            List<OrderItem> orders = service.GetOrders();
            timee.Text = DateTime.Now.ToString("h:mm:ss tt");
            recallpanel.Hide();


            for (int i = 0; i < 4; i++)
        //      foreach(Order order in orders)
            {
                Button button = new Button();
                button.Height = (PanelOrders.Height / 2) - (PanelOrders.Height / 30);
                button.Width  = (PanelOrders.Width / 2) - (PanelOrders.Width / 30); ;
                PanelOrders.Controls.Add(button);
                //     buttons.Add(button);
                OrderText(button);
                button.Click += new EventHandler(this.ClickOrder);
            }
        }


        public void ClickOrder(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PanelOrders.Controls.Remove(button);
        //    buttons.Remove(button);

        }


        public void NotifyWaiter()
        {

        }

        public void OrderText(Button b)
        {
            RichTextBox box = new RichTextBox();
            box.Location = b.Location;
            
            box.BackColor = System.Drawing.Color.Red;
            box.Text="order 012    vnldgnreinf";
            //b.Text += "gaafrs";
            box.Select(0, 7);
            box.SelectionFont = new Font(box.Font, FontStyle.Bold);



        }

        private void KitchenBar_Load(object sender, EventArgs e)
        {
            
        }

        private void recall_Click(object sender, EventArgs e)
        {
            recallpanel.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Start.Overview.ActiveForm.Activate();

        }

        private void recalled_Click(object sender, EventArgs e)
        {
            recallpanel.Hide();
        }
    }
}
