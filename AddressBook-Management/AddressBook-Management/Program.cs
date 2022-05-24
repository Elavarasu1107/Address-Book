using System;

namespace AddressBook_Management
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            ContactEditor getMethod = new ContactEditor();
            getMethod.addContacts();
            getMethod.displayContacts();
            getMethod.editContacts();
        }
    }
}
