using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirm
{
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
            LoadOrders();
        }



        private void btn_viewProducts_Click(object sender, EventArgs e)
        {
            FormProducts products = new FormProducts();
            products.Show();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            FormNewOrder newOrder = new FormNewOrder();
            newOrder.Show();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.Show();

        }


        public void LoadOrders()
        {
            Global.orders.Columns.Add(new DataColumn("Order No.", typeof(int)));
            Global.orders.Columns.Add(new DataColumn("Client", typeof(string)));
            Global.orders.Columns.Add(new DataColumn("Product", typeof(string)));
            Global.orders.Columns.Add(new DataColumn("Description", typeof(string)));
            Global.orders.Columns.Add(new DataColumn("Quantity", typeof(int)));
            Global.orders.Columns.Add(new DataColumn("Due date", typeof(DateTime)));
            Global.orders.Columns.Add(new DataColumn("Price", typeof(string)));
            Global.orders.Columns.Add(new DataColumn("Total price", typeof(string)));


            dataGridViewOrders.DataSource = Global.orders;


        }
    }
}
