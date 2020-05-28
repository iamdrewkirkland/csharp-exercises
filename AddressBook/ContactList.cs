using System.Collections.Generic;

namespace AddressBook
{
    class ContactList
    {
        public Dictionary<string, string> contacts = new Dictionary<string, string>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact.Email, contact.FirstName);
        }

        public GetByEmail(string email)
        {
            return contacts[email];
        }
    }
}