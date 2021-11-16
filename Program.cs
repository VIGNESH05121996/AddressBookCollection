using System;

namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Collection");

            AddressBook book = new AddressBook();

            Console.WriteLine("1.CreateContact\t2.AddContact\t3.EditWithFirstName\t4.DeletePersonDetails\t5.AddMultipleContact");

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
