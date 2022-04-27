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

        public int InsertIntoTable(ContactDetails details)
        {
            using (sqlConnection)
                try
                {

                    SqlCommand sqlCommand = new SqlCommand("dbo.InsertingIntoAddressBook", sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@FirstName", details.FirstName);
                    sqlCommand.Parameters.AddWithValue("@SecondName", details.SecondName);
                    sqlCommand.Parameters.AddWithValue("@Address", details.Address);
                    sqlCommand.Parameters.AddWithValue("@City", details.City);
                    sqlCommand.Parameters.AddWithValue("@State", details.State);
                    sqlCommand.Parameters.AddWithValue("@Zip", details.Zip);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", details.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Email", details.Email);
                    sqlCommand.Parameters.AddWithValue("@AddressBookName", details.AddressBookName);
                    sqlCommand.Parameters.AddWithValue("@Type", details.Type);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
        public ContactDetails ReadData(ContactDetails contactDetails)
        {
            contactDetails.FirstName = "Hari";
            contactDetails.SecondName = "Bala";
            contactDetails.Address = "cross street";
            contactDetails.City = "Theni";
            contactDetails.State = "Tamil Nadu";
            contactDetails.Zip = 600024;
            contactDetails.PhoneNumber = 8796541230;
            contactDetails.Email = "hari@gmail.com";
            contactDetails.AddressBookName = "FriendName";
            contactDetails.Type = "Friend";

            return contactDetails;
        }
        public int EditContactDetail(string FirstName, long PhoneNumber)
        {
            using (sqlConnection)
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    SqlCommand sqlCommand = new SqlCommand("dbo.EditPhoneNumber", sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
        public int DeletetheRecord(string FirstName)
        {
            using (sqlConnection)
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    SqlCommand sqlCommand = new SqlCommand("dbo.DeleteRecord", sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlConnection.Open();

                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    
                    
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                        return 1;
                    else
                        return 0;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
        }
    }
}    
    


