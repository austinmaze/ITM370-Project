using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Model
{
    public class Contact
    {
        public Contact() { }

        public Contact(string firstName, string lastName, string contactType)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactType = contactType;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactType { get; set; }
        public string FullName => FirstName + " " + LastName;
    }
}
