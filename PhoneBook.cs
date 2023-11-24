using System;
using System.Linq;


namespace Program
{
    public class PhoneBook
    {
        public List<Contact> contactsList = new List<Contact>();



        public void AddContactToPhoneBook(Contact contact)
        {
            if (contact is Contact && !string.IsNullOrWhiteSpace(contact.name) && !string.IsNullOrWhiteSpace(contact.phoneNumber))
            {

                contactsList.Add(contact);
            }
            else
            {
                Console.WriteLine("You need to provide a contact to add");
            }
        }


        public void DisplayContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Contact name:  {contact.name} Contact Number: {contact.phoneNumber}");
            }
        }

        public void DisplayContactsList()
        {
            DisplayContacts(contactsList);
        }
        public void DisplayContactsByPhoneNumber(string userInput)
        {
            userInput.Trim();
            List<Contact> foundContacts = contactsList.Where(contact => contact.phoneNumber.Contains(userInput)).ToList();
            DisplayContacts(foundContacts);
        }
    }
}