Create Procedure InsertingIntoAddressBook
(
  @FirstName varchar(200),
  @SecondName varchar(200),
  @Address varchar(200),
  @City varchar(100),
  @State varchar(100),
  @Zip bigint,
  @PhoneNumber bigint,
  @Email varchar(100),
  @AddressBookName varchar(100),
  @Type  varchar(100)
)
  As
  Begin
select * from Address_Book_Table
 insert into Address_Book_Table(FirstName,SecondName,Address,City,State,zip,PhoneNumber,Email,AddressBookName,Type)values(@FirstName,@SecondName,@Address,@city,@State, @zip,@PhoneNumber, @Email, @AddressBookName, @Type)
  End
  