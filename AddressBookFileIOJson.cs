using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    //Reading csv file and witing using Json
    class AddressBookFileIOJson
    {
        public void ReadingCsvWritingJson()
        {
            string path = @"D:\.net\AddressBookCollection\FileIO\AddressBook.csv";

            var reader = new StreamReader(path);
            var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture);
                var output = csvRead.GetRecords<ContactDetails>().ToList();
                foreach (ContactDetails details in output)
                {
                    Console.WriteLine("FirstName: {0}\tLastName: {1}\tAddress: {2}\tCity: {3}\tState: {4}\tZipCode: {5}\tPhoneNumber: {6}\tEmail: {7}", details.FirstName, details.LastName, details.Address, details.City, details.State, details.Zip, details.PhoneNumber, details.Email);
                }

            string jsonPath= @"D:\.net\AddressBookCollection\FileIO\AddressBook.json";
            JsonSerializer serializer = new JsonSerializer();
            using(StreamWriter sw=new StreamWriter(jsonPath))
            using(JsonWriter writer=new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, output);
            }
        }
    }
}
