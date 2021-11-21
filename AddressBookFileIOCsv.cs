using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    class AddressBookFileIOCsv
    {
        List<ContactDetails> contactDetails=new List<ContactDetails>();
        ContactDetails contact = new ContactDetails();
        public void CsvWriting()
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

            contactDetails.Add(contact); //Adding to list

            string path = @"D:\.net\AddressBookCollection\FileIO\AddressBook.csv";
            var writer = new StreamWriter(path);
            CultureInfo cultureInfo = new CultureInfo("en-US");
            var csvWrite = new CsvWriter(writer, cultureInfo);

            csvWrite.WriteRecords(contactDetails);
            writer.Close();
        }

        public void CsvReading()
        {
            string path = @"D:\.net\AddressBookCollection\FileIO\AddressBook.csv";

            using (var reader = new StreamReader(path))
            using (var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var output = csvRead.GetRecords<ContactDetails>().ToList();
                foreach (ContactDetails details in output)
                {
                    Console.WriteLine("FirstName: {0}\tLastName: {1}\tAddress: {2}\tCity: {3}\tState: {4}\tZipCode: {5}\tPhoneNumber: {6}\tEmail: {7}", details.FirstName, details.LastName, details.Address, details.City, details.State, details.Zip, details.PhoneNumber, details.Email);
                }
            }
               

            
        }
    }
}
