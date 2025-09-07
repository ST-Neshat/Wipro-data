Create Database SampleDB1
use SampleDB1;

Create Table Accounts(
Id int ,
Name Varchar(255),
Code int );

Insert into Accounts values (1,'Neshat',10);

select * from Accounts

Insert into Accounts values(2,'Rahul',13);
select*from Accounts

Delete from Accounts
where Id=1;

select * from Accounts

Insert into Accounts values(3,'Raj',15);
Insert into Accounts values(4,'Kausar',16);
Insert into Accounts values(5,'Mohammad',5);
Insert into Accounts values(6,'Naseem',2);

select * from Accounts

Update Accounts
set code = 12
where Id=3;
select * from Accounts


