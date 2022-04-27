create or alter procedure DeleteRecord
(
@FirstName Varchar(100)
)
as
begin
delete from Address_Book_Table where  FirstName ='Hari'
end
select *from  Address_Book_Table