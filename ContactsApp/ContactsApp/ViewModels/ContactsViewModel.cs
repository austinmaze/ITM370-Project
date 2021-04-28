using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ContactsApp.Model;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    internal class ContactsViewModel : ViewModelBase
    {
        private Contact contact = new Contact();
        private static Contact selectedContact = null;
        private static Contact saveContact = new Contact();
        public ContactsViewModel()
        {
            AddContactCommand = new Command(() =>
            {
                Contacts.Add(contact);
                Contact = new Contact();
            });

            CancelContactCommand = new Command(() =>
            {
                SelectedContact.FirstName = saveContact.FirstName;
                SelectedContact.LastName = saveContact.LastName;
                SelectedContact.ContactType = saveContact.ContactType;
            });

            DeleteContactCommand = new Command(() =>
            {
                Contacts.Remove(SelectedContact);
            });
        }

        public static List<Contact> Contacts => ContactData.Contacts;

        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddContactCommand { protected set; get; }
        public ICommand CancelContactCommand { protected set; get; }
        public ICommand DeleteContactCommand { protected set; get; }

        public Contact SelectedContact
        {
            get => selectedContact;
            set
            {
                if (value != null)
                {
                    saveContact.FirstName = value.FirstName;
                    saveContact.LastName = value.LastName;
                    saveContact.ContactType = value.ContactType;
                    selectedContact = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
