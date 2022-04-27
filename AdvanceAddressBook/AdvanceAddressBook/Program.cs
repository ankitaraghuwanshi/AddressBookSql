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
            Console.WriteLine("Contact inserted");
            addressBookManager.EditContactDetail(contactDetails.FirstName, contactDetails.PhoneNumber);
            Console.WriteLine("Contact Updated");
            addressBookManager.DeletetheRecord(contactDetails.FirstName);
            Console.WriteLine("Contact deleted");



        }
    }
}