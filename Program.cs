using System;
using System.Linq;

namespace Program
{
    public static class Program
    {
        // Functions
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome in Contact List App");
            Console.WriteLine("Press 1 = To Display All of your Contact");
            Console.WriteLine("Press 2 = To Find Your Contact By Phone Number");
            Console.WriteLine("Press 3 = To Add New Contact");
            Console.WriteLine("Press X = To Quit");
            var userInput = Console.ReadLine();
            PhoneBook allContacts = new PhoneBook();


            while (userInput != null)
            {
                switch (userInput)
                {
                    case "1":
                        {
                            allContacts.DisplayContactsList();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("Enter Phone Number");
                            var phoneNumber = Console.ReadLine();

                            if (phoneNumber != null && phoneNumber.Length > 0)
                            {
                                allContacts.DisplayContactsByPhoneNumber(phoneNumber);
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.Write("Insert a ContactName To add ");
                            var contactName = Console.ReadLine();
                            Console.Write("Insert a Contact Number To add ");
                            var contactNumber = Console.ReadLine();
                            if (contactName != null && contactNumber != null)
                            {
                                Contact newContact = new Contact(contactName, contactNumber);
                                allContacts.AddContactToPhoneBook(newContact);
                            }
                            break;
                        }
                    case "x":
                        {
                            return;
                        }
                }
                Console.WriteLine("Select Option");
                userInput = Console.ReadLine();
            }
        }
    }
}