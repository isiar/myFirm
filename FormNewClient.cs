using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirm
{
    public partial class FormNewClient : Form
    {
        FormClients formClients = new FormClients();
        public FormNewClient(FormClients fclients)
        {
            InitializeComponent();
            formClients = fclients;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (  formClients.IsEdit2 == true)
            {
                 formClients.dataGridViewClients.CurrentRow.Cells[0].Value = textBox1.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[1].Value = textBox2.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[2].Value = textBox3.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[3].Value = textBox4.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[4].Value = textBox5.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[5].Value = textBox6.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[6].Value = textBox7.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[7].Value = textBox8.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[8].Value = textBox9.Text;
                 formClients.dataGridViewClients.CurrentRow.Cells[9].Value = textBox10.Text;
            }

            else
            {
                DataTable dataTable = (DataTable)formClients.dataGridViewClients.DataSource;
                dataTable.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,textBox8.Text,textBox9.Text,textBox10.Text );
            }
            MessageBox.Show("Client saved");
            
            formClients.SaveToJson();

            this.Close();
        }
    }
}
