using System;
using System.Collections.Generic;

namespace Exercise1
{
    public class Phonebook
    {
        private List<Contact> _contacts;

        public Phonebook()
        {
            _contacts = new List<Contact>();
        }

        public void Add(String name, String phone, String email)
        {
            Contact contact = new Contact(name, phone, email);

            _contacts.Add(contact);
        }

        public Contact Find(String name)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Name.Equals(name))
                {
                    return contact;
                }
            }

            return null;
        }

        public Contact Delete(String name)
        {
            foreach (var contact1 in _contacts)
            {
                if (contact1.Name.Equals(name))
                {
                    _contacts.Remove(contact1);
                    return contact1;
                }
            }

            return null;
        }
    }
}