using System;

namespace AddressBook_Management
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContactEditor getMethod = new ContactEditor();
            Console.WriteLine(" 1 to Add Contact \n 2 to Display Contact \n 3 to Edit contact \n 4 to Remove Contact \n " +
                "5 to Add Multiple Contact \n 6 to Mutilpe Address Book");
            Console.Write("Enter the Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        getMethod.addContacts();
                        getMethod.displayContacts();
                        break;
                    }
                case 2:
                    {
                        getMethod.displayContacts();
                        break;
                    }
                case 3:
                    {
                        getMethod.addContacts();
                        getMethod.editContacts();
                        getMethod.displayContacts();
                        break;
                    }
                case 4:
                    {
                        getMethod.multipleContacts();
                        getMethod.removeContacts();
                        getMethod.displayContacts();
                        break;
                    }
                case 5:
                    {
                        getMethod.multipleContacts();
                        getMethod.displayContacts();
                        break;
                    }
                case 6:
                    {
                        getMethod.multipleBook();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a Valid Number");
                        break;
                    }
            }
        }
    }
}
