using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyFirm
{
    public partial class FormProducts : Form
    {
        int index;
        public bool IsEdit = true;


        public FormProducts()
        {
            InitializeComponent();

            LoadProducts();
            RunLoop();


        }

        DataTable table = new DataTable();

        
        public void LoadProducts()
        {      
            table.Columns.Add(new DataColumn("Name", typeof(string)));
            table.Columns.Add(new DataColumn("Description", typeof(string)));
            table.Columns.Add(new DataColumn("Price", typeof(double)));
            table.Columns.Add(new DataColumn("Stock", typeof(string)));

            dataGridViewProducts.DataSource = table;

            using (StreamReader file = new StreamReader(@"E:\Andra\proiecte\products.txt"))
            {
             string row;
                while ((row = file.ReadLine()) != null)
                {
                    DataRow dr = table.NewRow();
                    string[] values = row.Split('|');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    table.Rows.Add(dr);
                }
            }

            dataGridViewProducts.DataSource = table;


        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            FormNewProduct newProduct = new FormNewProduct(this);
            IsEdit = false;
            newProduct.Show();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dataGridViewProducts.CurrentCell.RowIndex;
            dataGridViewProducts.Rows.RemoveAt(index);
            MessageBox.Show("Product deleted");

            WriteToFile();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FormNewProduct newProduct = new FormNewProduct(this);

            IsEdit = true;

            newProduct.textBox1.Text = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
            newProduct.textBox2.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            newProduct.textBox3.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            newProduct.textBox4.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();

            newProduct.ShowDialog();

  
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            (dataGridViewProducts.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("Name like '%" + textBox1.Text + "%'");
        }

        public void RunLoop()
        {
            foreach(Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.BackColor = Color.LightGray;
                }
                if(x is Label)
                {
                    x.ForeColor = Color.Black;
                }
            }
        }

        public void WriteToFile()
        {
            string path = @"E:\Andra\proiecte\products.txt"; 
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < dataGridViewProducts.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewProducts.Columns.Count; j++)
                    {
                        if(j == dataGridViewProducts.Columns.Count - 1)
                        {
                            sw.Write( dataGridViewProducts.Rows[i].Cells[j].Value.ToString());
                        }

                        else
                        {
                            sw.Write(dataGridViewProducts.Rows[i].Cells[j].Value.ToString() + " | ");
                        }
                       
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
