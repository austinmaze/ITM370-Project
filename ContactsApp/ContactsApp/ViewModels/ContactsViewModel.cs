using System;
using System.Collections.Generic;
using System.Text;
using ContactsApp.Model;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    class ContactsViewModel : ViewModelBase
    {
        public IList<Contact> Contacts => ContactData.Contacts;

    }
}
