using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyFirm
{
    public partial class FormClients : Form
    {
        ListJson clientList;
        int index;
        public bool IsEdit2 = true;

        public FormClients()
        {
            InitializeComponent(); 
            WriteToFile<Client>(@"E:\Andra\proiecte\clienti.txt", clients);
            clientList = ReadFromJsonFile<Client>(@"E:\Andra\proiecte\json1.json");
            LoadClients();
        }

        ListJson clients = new ListJson
        {
            Infodatagrid = new List<Client>
            {
                new Client
                {
                    Id = 1,
                    Name = "SC Meba SRL",
                    CUI = 55417788,
                    Address = new Address() { City = "Bucharest", Street = "Victoriei", Number = 11, PostCode = 010001, Country = "Romania" },
                    ContactName = "Mihaela Ciucu",
                    PhoneNumber = "00407554123"
                },
                new Client
                {
                    Id = 2,
                    Name = "SC Dinamic SRL",
                    CUI = 23359829,
                    Address = new Address() { City = "Buzau", Street = "Parcului", Number = 3, PostCode = 120036, Country = "Romania" },
                    ContactName = "Andrei Serban",
                    PhoneNumber = "00407841226"
                },
                new Client
                {
                    Id = 3,
                    Name = "Ficosa SA",
                    CUI = 84563321,
                    Address = new Address() { City = "Amiens", Street = "Industrials", Number = 6, PostCode = 80080, Country = "Paris" },
                    ContactName = "Sabine Manon",
                    PhoneNumber = "00332626398"
                },
                new Client
                {
                    Id = 4,
                    Name = "SC BTSolutions SRL",
                    CUI = 11255467,
                    Address = new Address() { City = "Vicenza", Street = " Via Medici", Number = 5, PostCode = 36100, Country = "Italy" },
                    ContactName = "Giorgio Narda",
                    PhoneNumber = "00396655488"
                }
            }
        };         

        public static void WriteToFile<Client>(string path, ListJson client, bool append = false) where Client : new()
        {

            StreamWriter writer = null;
            try
            {
                var contentToFile = Newtonsoft.Json.JsonConvert.SerializeObject(client);
                writer = new StreamWriter(path, append);
                writer.Write(contentToFile);
                using (StreamWriter stream = new StreamWriter(@"E:\Andra\proiecte\json1.json"))
                {
                    stream.Write(contentToFile);
                }
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static ListJson ReadFromJsonFile<Client>(string path) where Client : new()
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(path);
                var fileContents = reader.ReadToEnd();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<ListJson>(fileContents);
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        DataTable dt = new DataTable();
        public void LoadClients()
        {
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("CUI", typeof(long)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Street", typeof(string)));
            dt.Columns.Add(new DataColumn("Number", typeof(int)));
            dt.Columns.Add(new DataColumn("Post Code", typeof(int)));
            dt.Columns.Add(new DataColumn("Country", typeof(string)));
            dt.Columns.Add(new DataColumn("Contact Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Phone Number", typeof(int)));

            dataGridViewClients.DataSource = dt;

            foreach (Client clt in clientList.Infodatagrid)
            {
                DataRow row = dt.NewRow();
                row[0] = clt.Id;
                row[1] = clt.Name;
                row[2] = clt.CUI;
                row[3] = clt.Address.City;
                row[4] = clt.Address.Street;
                row[5] = clt.Address.Number;
                row[6] = clt.Address.PostCode;
                row[7] = clt.Address.Country;
                row[8] = clt.ContactName;
                row[9] = clt.PhoneNumber;

                dt.Rows.Add(row);
            }
            dataGridViewClients.DataSource = dt;

        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            FormNewClient newClient = new FormNewClient(this);
            IsEdit2 = false;
            newClient.Show();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FormNewClient newClient = new FormNewClient(this);

            IsEdit2 = true;

            newClient.textBox1.Text = dataGridViewClients.CurrentRow.Cells[0].Value.ToString();
            newClient.textBox2.Text = dataGridViewClients.CurrentRow.Cells[1].Value.ToString();
            newClient.textBox3.Text = dataGridViewClients.CurrentRow.Cells[2].Value.ToString();
            newClient.textBox4.Text = dataGridViewClients.CurrentRow.Cells[3].Value.ToString();
            newClient.textBox5.Text = dataGridViewClients.CurrentRow.Cells[4].Value.ToString();
            newClient.textBox6.Text = dataGridViewClients.CurrentRow.Cells[5].Value.ToString();
            newClient.textBox7.Text = dataGridViewClients.CurrentRow.Cells[6].Value.ToString();
            newClient.textBox8.Text = dataGridViewClients.CurrentRow.Cells[7].Value.ToString();
            newClient.textBox9.Text = dataGridViewClients.CurrentRow.Cells[8].Value.ToString();
            newClient.textBox10.Text = dataGridViewClients.CurrentRow.Cells[9].Value.ToString();

            newClient.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            (dataGridViewClients.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("Name like '%" + textBox1.Text + "%'");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            index = dataGridViewClients.CurrentCell.RowIndex;
            dataGridViewClients.Rows.RemoveAt(index);
            MessageBox.Show("Client deleted");
            
            SaveToJson();

        }


        public void SaveToJson()
        {
            string path = @"E:\Andra\proiecte\json1.json";
            var rootObject = new ListJson();
            rootObject.Infodatagrid = new List<Client>();

            foreach (DataGridViewRow row in dataGridViewClients.Rows)
            {
                Client item = new Client
                {
                    Id = (int)row.Cells["Id"].Value,
                    Name = row.Cells["Name"].Value.ToString(),
                    CUI = (long)row.Cells["CUI"].Value,
                    Address = new Address { City = row.Cells["City"].Value.ToString(),
                        Street = row.Cells["Street"].Value.ToString(),
                        Number = (int)row.Cells["Number"].Value,
                        PostCode = (int)row.Cells["Post Code"].Value,
                        Country = row.Cells["Country"].Value.ToString()
                    },
                    ContactName = row.Cells["Contact Name"].Value.ToString(),
                    PhoneNumber = row.Cells["Phone Number"].Value.ToString()

                };

                rootObject.Infodatagrid.Add(item);
                
            }

            var code = JsonConvert.SerializeObject(rootObject);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(code);
            }

        }
    }
}