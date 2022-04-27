using System;

namespace AdvanceAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book db");
            AddressBookManager addressBookManager = new AddressBookManager();
            ContactDetails contactDetails = new ContactDetails();
            addressBookManager.ReadData(contactDetails);
            addressBookManager.InsertIntoTable(contactDetails);
            addressBookManager.EditContactDetail(contactDetails.FirstName, contactDetails.PhoneNumber);



        }
    }
}