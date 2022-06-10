using System;

namespace AddressBook_Management
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContactEditor getMethod = new ContactEditor();
            Console.WriteLine(" 1 to Add Contact \n 2 to Display Contact \n 3 to Edit contact \n 4 to Remove Contact \n " +
                "5 to Add Multiple Contact \n 6 to Mutilpe Address Book\n 7 for Search Contact by City or State");
            Console.Write("Enter the Number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        getMethod.AddContacts();
                        getMethod.DisplayContacts();
                        break;
                    }
                case 2:
                    {
                        getMethod.AddContacts();
                        getMethod.DisplayContacts();
                        break;
                    }
                case 3:
                    {
                        getMethod.AddContacts();
                        getMethod.EditContacts();
                        getMethod.DisplayContacts();
                        break;
                    }
                case 4:
                    {
                        getMethod.MultipleContacts();
                        getMethod.RemoveContacts();
                        getMethod.DisplayContacts();
                        break;
                    }
                case 5:
                    {
                        getMethod.MultipleContacts();
                        getMethod.DisplayContacts();
                        break;
                    }
                case 6:
                    {
                        getMethod.MultipleBook();
                        break;
                    }
                case 7:
                    {
                        getMethod.SearchCityOrState();
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
