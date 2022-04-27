create or Alter Procedure EditPhoneNumber
(

@FirstName varchar(50),
@PhoneNumber bigint
)
as
begin
update Address_Book_Table set PhoneNumber=9100000000 where  FirstName ='Ankita'
end
select * from Address_Book_Table