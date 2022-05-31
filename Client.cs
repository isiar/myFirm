using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm
{
    public class Client : Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long CUI { get; set; }
        public Address Address { get; set; }

        public Client( )
        {
        }

    } 

    public class ListJson
    {
        public List<Client> Infodatagrid { get; set; }
    }

}
