using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        AddressBookManager addressBookManager;
       
        public void SetUp()
        {
            addressBookManager = new AddressBookManager();
        }
    }

    
}