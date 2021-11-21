using System;
using System.Collections.Generic;
namespace AddressBookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSwitch to 1:AddressBook \t2:AddressBook File I/O Using .txt\t3:Address Book File I/O using .csv\tAddress Book File I/O .json");
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
                    Console.WriteLine("\nWelcome To FIle I/O Read and Write using .txt");
                    for(int i=1;i<=2;i++)
                    {
                        Console.WriteLine("\n1:File I/O Write operation\t2:File I/O Read Operation");
                        int j = Convert.ToInt32(Console.ReadLine());
                        AddressBookFileIO files = new AddressBookFileIO();
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("\nFile Io Write using .txt");
                                files.WriteUsingStreamWriter();
                                break;

                            case 2:
                                Console.WriteLine("\nFile Io Read .txt");
                                files.ReadFromStreaReader();
                                break;

                            default:
                                Console.WriteLine("\n Valid Inputs Are Over");
                                break;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("\nWelcome To FIle I/O Read and Write using ..csv");
                    for (int i = 1; i <= 2; i++)
                    {
                        Console.WriteLine("\n1:File I/O Write operation\t2:File I/O Read Operation");
                        int j = Convert.ToInt32(Console.ReadLine());
                        AddressBookFileIOCsv csv = new AddressBookFileIOCsv();
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("\nFile Io Write using .csv");
                                csv.CsvWriting();
                                break;

                            case 2:
                                Console.WriteLine("\nFile Io Read using .csv");
                                csv.CsvWriting();
                                break;

                            default:
                                Console.WriteLine("\n Valid Inputs Are Over");
                                break;
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("\nWelcome to File I/O Json Serializer");
                    AddressBookFileIOJson jsonFile = new AddressBookFileIOJson();
                    jsonFile.ReadingCsvWritingJson();
                    break;

                default:
                    Console.WriteLine("\nEnter Valid Input To Perform operation");
                    break;
            }
        }
           
    }
}
