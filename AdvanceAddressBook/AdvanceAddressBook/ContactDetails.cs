using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBook
{
    class ContactDetails
    {
        public int personId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public long Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AddressBookName { get; set; }
        public string Type { get; set; }

    }
}