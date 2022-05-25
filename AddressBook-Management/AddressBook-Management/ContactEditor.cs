using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Management
{
    internal class ContactEditor
    {
        List<ContactDetails> listOfPeople = new List<ContactDetails>();
        ContactDetails Contact;
        public void addContacts()
        {
            Contact = new ContactDetails();
            Console.Write("Enter First Name: ");
            Contact.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            Contact.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            Contact.address = Console.ReadLine();
            Console.Write("Enter City: ");
            Contact.city = Console.ReadLine();
            Console.Write("Enter State: ");
            Contact.state = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            Contact.zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Contact.phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            Contact.email = Console.ReadLine();

            listOfPeople.Add(Contact);
            Console.WriteLine();
        }
        public void displayContacts()
        {
            //Console.WriteLine();
            foreach (var details in listOfPeople)
            {
                Console.WriteLine("First Name: " + details.firstName + "\nLast Name: " + details.lastName + "\nAddress: " 
                + details.address + "\nCity: " + details.city + "\nCity: " + details.city + "\nZip Code: " 
                + details.zip + "\nPhone Number: " + details.phone + "\nEmail: " + details.email+ "\n"); 
            }
            if(listOfPeople.Count == 0)
            {
                Console.WriteLine("Address Book is Empty");
            }
        }
        public void editContacts()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a Name to edit the contact:");
            string fName = Console.ReadLine();
            ContactDetails editContact = listOfPeople.FirstOrDefault(x => x.firstName == fName);
            if (editContact != null)
            {
                Console.WriteLine("To Edit the contact Details Press:\n 1 for First Name\n 2 for Last Name\n 3 for Address\n" +
                    " 4 for City\n 5 for State \n 6 for Zip Code\n 7 for Phone Number\n 8 for Email");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter new First Name");
                            editContact.firstName = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter new Last Name");
                            editContact.lastName = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter new Address");
                            editContact.address = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter new City Name");
                            editContact.city = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter new State Name");
                            editContact.state = Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter new Zip Code");
                            editContact.zip = Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter new Phone Number");
                            editContact.phone = Console.ReadLine();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter new Email");
                            editContact.email = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry...There is no such Data");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Sorry...Contact not found!");
            }
        }
        public void removeContacts()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Name to remove the Contact:");
            string fName = Console.ReadLine();
            
            foreach(var details in listOfPeople.ToList())
            {
                if(details.firstName == fName)
                {
                   listOfPeople.Remove(details);
                   Console.WriteLine("Contact removed from list");
                }
            }
        }
        public void multipleContacts()
        {
            Console.WriteLine("Enter number of contacts you want to add:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput > 0)
            {
                addContacts();
                userInput--;
            }
        }
    }
}
