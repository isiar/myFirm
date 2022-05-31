using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MyFirm
{
    
    internal class Global
    {
        public static DataTable orders = new DataTable();
        public static List<Products> products = new List<Products>();
        public static List<Client> clients = new List<Client>();
    }
}
