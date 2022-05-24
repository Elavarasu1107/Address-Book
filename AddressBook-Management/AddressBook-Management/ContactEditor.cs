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
                Console.WriteLine("First Name: " + details.firstName + "\nLast Name: " + details.lastName + "\nAddress: " + details.address
                + "\nCity: " + details.city + "\nCity: " + details.city + "\nZip Code: " + details.zip + "\nPhone Number: " + details.phone + "\nEmail: " + details.email); ;
            }
        }
    }
}
