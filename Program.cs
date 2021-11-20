using System;
using System.Collections.Generic;
namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSwitch to 1:AddressBook\t2:AddressBook File I/O");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome To Address Book Collection");

                    AddressBook book = new AddressBook();
                    Dictionary<AddressBook, string> addressBook = new Dictionary<AddressBook, string>();

                    Console.WriteLine("1.CreateContact\t2.AddContact\t3.EditWithFirstName\t4.DeletePersonDetails\t5.AddMultipleContact\t6.ViewPersonByCityOrState7.CountCityState");

                    string key = "y";

                    while (key != "n")
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
                                book.SearchPersonWithCityOrState();
                                break;

                            case 6:
                                book.ViewPersonCityOrState();
                                break;

                            case 7:
                                book.CountCityState();
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
                    break;

                case 2:
                    for(int i=1;i<=2;i++)
                    {
                        Console.WriteLine("\n1:File I/O Write operation\t2:File I/O Read Operation");
                        int j = Convert.ToInt32(Console.ReadLine());
                        AddressBookFileIO files = new AddressBookFileIO();
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("\nWelcome TO File Io Write");
                                files.WriteUsingStreamWriter();
                                break;

                            case 2:
                                Console.WriteLine("\nWelcome TO File Io Read");
                                files.ReadFromStreaReader();
                                break;

                            default:
                                Console.WriteLine("\n Valid Inputs Are Over");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("\nEnter Valid Input To Perform operation");
                    break;
            }
        }
           
    }
}
