using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Management
{
    internal class ContactEditor
    {
        ContactDetails contact;
        List<ContactDetails> listOfPeople = new List<ContactDetails>();
        Dictionary<string, List<ContactDetails>> book = new Dictionary<string, List<ContactDetails>>();
        public void AddContacts()
        {
            contact = new ContactDetails();
            bool status = true;
            while (status)
            {
                Console.Write("Enter First Name: ");
                contact.firstName = Console.ReadLine();
                if (listOfPeople.Any(e => (e.firstName.Equals(contact.firstName))))
                {
                    Console.WriteLine("Name already exist in Address Book. Please Enter a New Name");
                }
                else
                {
                    status = false;
                }
            }
            Console.Write("Enter Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            contact.address = Console.ReadLine();
            Console.Write("Enter City: ");
            contact.city = Console.ReadLine();
            Console.Write("Enter State: ");
            contact.state = Console.ReadLine();
            Console.Write("Enter Zip Code: ");
            contact.zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contact.phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            contact.email = Console.ReadLine();

            listOfPeople.Add(contact);
            Console.WriteLine();
        }
        public void DisplayContacts()
        {
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
        public void EditContacts()
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
        public void RemoveContacts()
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
        public void MultipleContacts()
        {
            Console.WriteLine("Enter number of contacts you want to add:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            listOfPeople = new List<ContactDetails>();
            while(userInput > 0)
            {
                AddContacts();
                userInput--;
            }
        }
        public void MultipleBook()
        {
            //Dictionary<string, List<ContactDetails>> book = new Dictionary<string, List<ContactDetails>>();
            Console.WriteLine("Enter the number of book you want to add: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while(userInput > 0)
            {
                Console.WriteLine("Enter Group Name: ");
                string groupName = Console.ReadLine();
                MultipleContacts();
                book.Add(groupName, listOfPeople);
                userInput--;
            }

            foreach (var bookName in book)
            {
                Console.WriteLine("Group Name is :" + bookName.Key+"\n");
                foreach (var list in bookName.Value)
                {
                    Console.WriteLine("First Name: " + list.firstName + "\nLast Name: " + list.lastName + "\nAddress: "
                 + list.address + "\nCity: " + list.city + "\nState: " + list.state + "\nZip Code: "
                 + list.zip + "\nPhone Number: " + list.phone + "\nEmail: " + list.email + "\n");
                } 
            }
        }
        public void SearchCityOrState()
        {
            MultipleBook();
            Console.WriteLine("Enter 1 to Search contacts by city\n2 to Search contacts by State");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter a City Name to Search: ");
                        string searchCity = Console.ReadLine();
                        foreach (var bookName in book)
                        {
                            Console.WriteLine("Group Name is :" + bookName.Key + "\n");
                            foreach (var list in bookName.Value.FindAll(e => (e.city.Equals(searchCity))).ToList())
                            {
                                Console.WriteLine("First Name: " + list.firstName + "\nLast Name: " + list.lastName + "\nAddress: "
                                + list.address + "\nCity: " + list.city + "\nState: " + list.state + "\nZip Code: "
                                + list.zip + "\nPhone Number: " + list.phone + "\nEmail: " + list.email + "\n");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter a State Name to Search: ");
                        string searchState = Console.ReadLine();
                        foreach (var bookName in book)
                        {
                            Console.WriteLine("Group Name is :" + bookName.Key + "\n");
                            foreach (var list in bookName.Value.FindAll(e => (e.state.Equals(searchState))).ToList())
                            {
                                Console.WriteLine("First Name: " + list.firstName + "\nLast Name: " + list.lastName + "\nAddress: "
                                + list.address + "\nCity: " + list.city + "\nState: " + list.state + "\nZip Code: "
                                + list.zip + "\nPhone Number: " + list.phone + "\nEmail: " + list.email + "\n");
                            }
                        }
                        break;
                    }
            }
        }
    }
}
