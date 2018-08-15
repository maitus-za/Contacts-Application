using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Contacts.Model;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Contacts
{
    public class Service1 : IService1
    {
        //  Creating a contact
        public void InsertContact(Contact contact)
        {
            ContactsContext pc = new ContactsContext();
            pc.Contacts.Add(contact);
            pc.SaveChanges();
        }

        //  Reading all the contacts
        public IEnumerable<Contact> GetContacts()
        {
            List<Contact> lc = new List<Contact>();
            ContactsContext pc = new ContactsContext();
            lc = pc.Contacts.ToList();
            return lc;
        }

        //  Update a contact
        public void UpdateContact(Contact contact)
        {
            ContactsContext pc = new ContactsContext();
            var c = (from cont in pc.Contacts
                     where cont.Id == contact.Id
                     select cont).First();

            c.FirstName = contact.FirstName;
            c.MiddleName = contact.MiddleName;
            c.LastName = contact.LastName;
            c.PhoneNumbers = contact.PhoneNumbers;
            c.Address = contact.Address;

            pc.SaveChanges();
        }

        //  Deleting the contacts
        public void DeleteContact(int id)
        {
            ContactsContext pc = new ContactsContext();
            var c = (from cont in pc.Contacts
                     where cont.Id == id
                     select cont).First();

            pc.Contacts.Remove(c);
            pc.SaveChanges();
        }
    }
}
