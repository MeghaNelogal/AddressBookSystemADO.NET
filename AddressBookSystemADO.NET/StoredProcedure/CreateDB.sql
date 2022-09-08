create database AddressBookDB

use AddressBookDB;

----Create table AddressBookSystem
Create table AddressBookSystem(
FirstName varchar(50),
LastName varchar(50),
Address varchar(50),
City varchar(50), 
State varchar(50),
Zip varchar(10),
PhoneNumber varchar(20),
EmailId varchar(50),
AddressBookType varchar(50),
AddressBookName varchar(50) 
);
select * from AddressBookSystem;

--UC2
--insert record into table
insert into AddressBookSystem values('Megha','Nelogal','vijay nagar','Banglore','Karnataka','778899','9009088976','megha@gmail.com','Family','FamilyBook');
select * from AddressBookSystem;

--UC3
Create procedure dbo.AddressBookSystemProcedure
	@FirstName varchar(150),		
	@LastName varchar(150),	
	@Address varchar(150),		
	@City varchar(150),	
	@State varchar(150),	
	@Zip varchar(6),
    @PhoneNumber varchar(50),
	@EmailId varchar(150),	
	@AddressBookType varchar(150),
	@AddressBookName varchar(150)
as begin
	Insert into AddressBookSystem values(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@EmailId,@AddressBookType,@AddressBookName)
End