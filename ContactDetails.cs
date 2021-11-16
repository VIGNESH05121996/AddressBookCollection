using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    public class ContactDetails
    {
        //automatic property get and set for Contact Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    class AddressBook
    {
        public List<ContactDetails> contactDetails = new List<ContactDetails>(); //created empty list of contactDetails of class ContactDetails every time when run code
        public void CreateContact()
        {

            ContactDetails contact = new ContactDetails(); //creating instance of class

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

            Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email); //disolaying details
        }
    }
}
