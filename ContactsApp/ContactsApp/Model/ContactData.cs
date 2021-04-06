using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Model
{
    public static class ContactData
    {
        public static IList<object> Contacts { get; set; }

        static ContactsData()
        {
            Contacted = new List<object>();
            Contacted.Add(new object
            {
                Name = "",
                
            });
        }

        
    }
}
