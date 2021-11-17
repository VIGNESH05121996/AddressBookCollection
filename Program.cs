using System;
using System.Collections.Generic;
namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Collection");

            AddressBook book = new AddressBook();
            Dictionary<AddressBook, string> addressBook = new Dictionary<AddressBook, string>();

            Console.WriteLine("1.CreateContact\t2.AddContact\t3.EditWithFirstName\t4.DeletePersonDetails\t5.AddMultipleContact\t6.SearchPersonWithCity");

            string key = "y";
            
            while(key != "n")
            {
                Console.WriteLine("\nEnter Your Choice");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        book.CreateContact();
                        book.CheckDuplicateEntry();
                        break;

                    case 2:
                        book.AddContact();
                        break;

                    case 3:
                        book.CreateContact();
                        book.EditWithFirstName();
                        break;

                    case 4:
                        book.CreateContact();
                        book.DeletePersonDetails();
                        break;

                    case 5:
                        book.AddMultipleContact();
                        book.SearchPersonWithCity();
                        break;

                    case 6:
                        book.SearchPersonWithCity();
                        break;

                    default:
                        Console.WriteLine("\nEnter a valid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue-- press y/n");
                key = Console.ReadLine();
            }
            Console.WriteLine("\nEnter Address Book Name");
            string name = Console.ReadLine(); //name of address book
            addressBook.Add(book, name); //adding address book to dictionary
            foreach (var add in addressBook)
            {
                Console.WriteLine(add.Value);
            }
        }
    }
}
