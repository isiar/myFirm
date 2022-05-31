using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirm
{
    public partial class FormNewProduct : Form
    {
        FormProducts formProd = new FormProducts();
    

        public FormNewProduct(FormProducts fprod)
        {
             
            InitializeComponent();
            this.formProd = fprod;
          
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
         
            if (formProd.IsEdit == true)
            {

                formProd.dataGridViewProducts.CurrentRow.Cells[0].Value = textBox1.Text;
                formProd.dataGridViewProducts.CurrentRow.Cells[1].Value = textBox2.Text;
                formProd.dataGridViewProducts.CurrentRow.Cells[2].Value = textBox3.Text;
                formProd.dataGridViewProducts.CurrentRow.Cells[3].Value = textBox4.Text;

            }

            else
            {
               
                DataTable dataTable = (DataTable)formProd.dataGridViewProducts.DataSource;
                dataTable.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            }
            
            MessageBox.Show("Product saved");
            this.Close();

            formProd.WriteToFile();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
