using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Model
{
    public static class ContactData
    {
        public static IList<Contact> Contacts { get; set; }

        static ContactData()
        {
            Contacts = new List<Contact>();

            Contacts.Add(new Contact
            {
                FirstName = "Ben",
                LastName = "Hale",
                ContactType = "Personal"
            });
        }
    }
}
