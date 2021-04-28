using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsApp.Model
{
    public static class ContactData
    {
        public static List<Contact> contacts = new List<Contact>();

        public static List<Contact> Contacts
        {
            get
            {
                contacts = new List<Contact>(contacts.OrderBy(contact => contact.LastName));
                return contacts;
            }
        }

        static ContactData()
        {
            contacts.Add(new Contact
            {
                FirstName = "Ben",
                LastName = "Hale",
                ContactType = "Class Mate"
            });
            contacts.Add(new Contact
            {
                FirstName = "Erica",
                LastName = "Darling",
                ContactType = "Personal"
            });
            contacts.Add(new Contact
            {
                FirstName = "Austin",
                LastName = "Maze",
                ContactType = "Class Mate"
            });
            contacts.Add(new Contact
            {
                FirstName = "Bridger",
                LastName = "Parker",
                ContactType = "Class Mate"
            });
        }
    }
}
