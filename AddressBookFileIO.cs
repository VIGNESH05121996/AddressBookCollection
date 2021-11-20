using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AddressBookCollection
{
    class AddressBookFileIO
    {
        ContactDetails contact = new ContactDetails();
        public void WriteUsingStreamWriter()
        {
            //creating contact details with instance of class
            contact.FirstName = "Vignesh";
            contact.LastName = "Marimuthu";
            contact.Address = "HAPP";
            contact.City = "Trichy";
            contact.State = "Tamil Nadu";
            contact.Zip = "620025";
            contact.PhoneNumber = "123456789";
            contact.Email = "abc@gmail.com";

            String path = @"D:\.net\AddressBookCollection\FileIO\AddressBook.txt"; //defining the path

            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("First Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email);
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public void ReadFromStreaReader()
        {
            String path = @"D:\.net\AddressBookCollection\FileIO\AddressBook.txt"; //defining the path

            using(StreamReader sr = File.OpenText(path))
            {
                String s = " ";
                while((s= sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        
    }
}
