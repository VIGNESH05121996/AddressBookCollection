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
        public Dictionary<string, List<ContactDetails>> addressBookCity = new Dictionary<string, List<ContactDetails>>(); //to store address based on city name
        public Dictionary<string, List<ContactDetails>> addressBookState = new Dictionary<string, List<ContactDetails>>(); //to store address book based on state name

        ContactDetails contact = new ContactDetails(); //creating instance of class
        public void CreateContact()
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

            Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email); //disolaying details
        }

        public void AddContact()
        {
            //Getting detatils from user for new contact details
            Console.WriteLine("\nEnter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

            contactDetails.Add(contact); //Adding to list

            Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email); //disolaying details
        }

        public void EditWithFirstName() //To edit Contact Details based on first name
        {
            Console.WriteLine("\nEnter Name To Edit");
            string name = Convert.ToString(Console.ReadLine()); //getting the name input from user
            if (name == contact.FirstName) //checking if name is equal to First Name
            {
                AddContact();
            }
        }

        public void DeletePersonDetails() //deleting person based on First Name
        {
            Console.WriteLine("\nEnter Name To Delete");
            string name = Convert.ToString(Console.ReadLine());
            if (name == contact.FirstName)
            {
                Console.WriteLine("Are You Sure Want To Delete- Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    contactDetails.Remove(contact);
                    Console.WriteLine("\nContact Deleted");
                }
            }
            else
            {
                Console.WriteLine("\nEnter a valid First Name");
            }
        }

        public void AddMultipleContact() //for adding multiple contact
        {
            Console.WriteLine("\nEnter How Many Contacts Want To Add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                AddContact();
            }
        }

        public void CheckDuplicateEntry()
        {
            Console.WriteLine("\nEnter person First Name");
            string firName = Console.ReadLine();
            var person = contactDetails.Find(person => person.FirstName.Equals(firName)); //Lambda expression to find contact is exists
            if(person != null)
            {
                Console.WriteLine("\nContact Already Exists");
            }
            else
            {
                Console.WriteLine("\nContact Not Exists ");
            }
        }

        public void SearchPersonWithCityOrState()
        {
            Console.WriteLine("\nEnter 1.Search Person With City\t2.Search Person With State");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("\nEnter City Name to search person with city");
                    string cityName = Console.ReadLine();
                    var person = contactDetails.Find(person => person.City.Equals(cityName)); //Lambda expression to find person with city name
                    Console.WriteLine("{0} person is in city{1} ", contact.FirstName, cityName);
                    break;

                case 2:
                    Console.WriteLine("\nEnter State Name to search person with city");
                    string stateName = Console.ReadLine();
                    var person1 = contactDetails.Find(person1 => person1.State.Equals(stateName)); //Lambda expression to find person with state name
                    Console.WriteLine("{0} person is in state{1} ", contact.FirstName, stateName);
                    break;

                default:
                    Console.WriteLine("\nEnter a valid choice");
                    break;
            }
        }

        public void ViewPersonCityOrState()
        {
            AddMultipleContact();
            Console.WriteLine("\n1.View Person By City Name\t2.View Person By State Name");
            int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter City Name");
                        string cityName = Console.ReadLine();
                        var city = contactDetails.Find(city => city.City.Equals(cityName));
                        foreach (var details in cityName)
                        {
                            if (details != null)
                            {
                                Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email); //disolaying details
                            }
                        }
                        addressBookCity.Add(cityName, contactDetails);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter State Name");
                        string stateName = Console.ReadLine();
                        var state = contactDetails.Find(state => state.City.Equals(stateName));
                        foreach (var details in stateName)
                        {
                            if (details != null)
                            {
                                Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip: " + contact.Zip + "\nPhone No: " + contact.PhoneNumber + "\nEmail: " + contact.Email); //disolaying details
                            }
                        }
                        addressBookCity.Add(stateName, contactDetails);
                        break;
                }
        }

        public void CountCityState()
        {
            AddMultipleContact();
            Console.WriteLine("\nEnter City name");
            string city = Console.ReadLine();

            Console.WriteLine("\nEnter Sate Name");
            string state = Console.ReadLine();

            var cityCount = contactDetails.FindAll(cityCount=>cityCount.City == city).Count;
            Console.WriteLine("\nCount by city: " + cityCount);

            
            var stateCount = contactDetails.FindAll(stateCount=>stateCount.State == state).Count;
            Console.WriteLine("\nCount by state: " + stateCount);
        }
    }
}
