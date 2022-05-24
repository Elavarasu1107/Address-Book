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
        ContactDetails Contact = new ContactDetails();
        public void addContacts()
        {
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
            Contact.zip = int.Parse(Console.ReadLine());
            Console.Write("Enter Phone Number: ");
            Contact.phone = long.Parse(Console.ReadLine());
            Console.Write("Enter Email: ");
            Contact.email = Console.ReadLine();

            listOfPeople.Add(Contact);
        }
        public void displayContacts()
        {
            Console.WriteLine();
            foreach (var details in listOfPeople)
            {
                Console.WriteLine("First Name: " + details.firstName + "\nLast Name: " + details.lastName + "\nAddress: " 
                + details.address + "\nCity: " + details.city + "\nCity: " + details.city + "\nZip Code: " 
                + details.zip + "\nPhone Number: " + details.phone + "\nEmail: " + details.email); 
            }
        }
        public void editContacts()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a Name to edit the contact:");
            string fName = Console.ReadLine();
            if(fName == Contact.firstName)
            {
                Console.WriteLine("To Edit the contact Details Press:\n 1 for First Name\n 2 for Last Name\n 3 for Address\n" +
                    " 4 for City\n 5 for State \n 6 for Zip Code\n 7 for Phone Number\n 8 for Email");
                int userInput = int.Parse(Console.ReadLine());

                switch(userInput)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter new First Name");
                            Contact.firstName = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter new Last Name");
                            Contact.lastName = Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter new Address");
                            Contact.address = Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter new City Name");
                            Contact.city = Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter new State Name");
                            Contact.state = Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter new Zip Code");
                            Contact.zip = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter new Phone Number");
                            Contact.phone = long.Parse(Console.ReadLine());
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter new Email");
                            Contact.email = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry...There is no such Data");
                            break;
                        }
                }
                Console.WriteLine("First Name: " + Contact.firstName + "\nLast Name: " + Contact.lastName + "\nAddress: " + Contact.address
                + "\nCity: " + Contact.city + "\nCity: " + Contact.city + "\nZip Code: " + Contact.zip + "\nPhone Number: " + Contact.phone + "\nEmail: " + Contact.email);
            }
            else
            {
                Console.WriteLine("Invalid..Name not found!");
            }
        }
        public void removeContacts()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the Name to remove the Contact:");
            string fName = Console.ReadLine();
            
            foreach(var details in listOfPeople.ToList())
            {
                if(fName == Contact.firstName)
                {
                   listOfPeople.Remove(details);
                   Console.WriteLine("Contact removed from list");
                }
            }
            if (listOfPeople == null)
            {
                Console.WriteLine("Contact removed from list");
            }
        }
    }
}
