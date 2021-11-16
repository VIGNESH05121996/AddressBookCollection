using System;

namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Collection");

            AddressBook book = new AddressBook();

            Console.WriteLine("1.Create Contact");

            Console.WriteLine("\nEnter Your Choice");
            int c = Convert.ToInt32(Console.ReadLine());

            string key = "y";
            
            while(key != "n")
            {
                switch(c)
                {
                    case 1:
                        book.CreateContact();
                        break;

                    case 2:
                        book.AddContact();
                        break;

                    default:
                        Console.WriteLine("\nEnter a valid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue-- press y/n");
                key = Console.ReadLine();
            }
        }
    }
}
