using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBook
{
    class AddressBookManager
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service_DB;Integrated Security=SSPI";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

    }    
}

