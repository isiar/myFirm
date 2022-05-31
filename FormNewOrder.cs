using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;

namespace MyFirm
{
    public partial class FormNewOrder : Form
    {

        public FormNewOrder()
        {
            InitializeComponent();
         
        }

        private void FormNewOrder_Load(object sender, EventArgs e)
        {
            StreamReader reader = null;
            ListJson clientList = new ListJson();
            try
            {
                reader = new StreamReader(@"E:\Andra\proiecte\json1.json");
                var fileContents = reader.ReadToEnd();
                clientList = JsonConvert.DeserializeObject<ListJson>(fileContents);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }

            foreach (Client clt in clientList.Infodatagrid)
            {
                Global.clients.Add(clt);
                comboBox_client.Items.Add(clt.Name);
            }

            using (StreamReader file = new StreamReader(@"E:\Andra\proiecte\products.txt"))
            {            
                string row;
                while ((row = file.ReadLine()) != null)
                {
                    Products pr = new Products();
                    
                    string[] values = row.Split('|');
                    pr.Name = values[0];
                    pr.Description = values[1];
                    pr.Price = double.Parse(values[2]);
                    Global.products.Add(pr);
                }
            }

            foreach (var pr in Global.products)
            {
                comboBox_ProdName.Items.Add(pr.Name);
            }
        }

        private void comboBox_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = Global.products.FirstOrDefault(x => x.Name == comboBox_ProdName.SelectedItem.ToString());
            txtBox_Description.Text = product.Description;
            txtBox_Price.Text = product.Price.ToString();
        }

        private void comboBox_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = Global.clients.FirstOrDefault(x => x.Name == comboBox_client.SelectedItem.ToString());
            richTxtBox_address.Text = client.Address.ToString();
            txt_cui.Text = client.CUI.ToString();
            txt_id.Text = client.Id.ToString();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBox_qty_TextChanged(object sender, EventArgs e)
        {
            txtBox_totalPrice.Text = GetTotalPrice().ToString();
        }

        private void txtBox_Price_TextChanged(object sender, EventArgs e)
        {
            txtBox_totalPrice.Text = GetTotalPrice().ToString();
        }
        
        private double GetTotalPrice()
        {
            double total = 0;
            total = double.Parse(txtBox_qty.Text) * double.Parse(txtBox_Price.Text);

            return total;
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {

            DataRow row = Global.orders.NewRow();
            row[0] = txtBox_orderNo.Text;
            row[1] = comboBox_client.Text;
            row[2] = comboBox_ProdName.Text;
            row[3] = txtBox_Description.Text;
            row[4] = txtBox_qty.Text;
            row[5] = DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");  
            row[6] = txtBox_Price.Text;
            row[7] = txtBox_totalPrice.Text;
            Global.orders.Rows.Add(row);
        }

        
    }
}
