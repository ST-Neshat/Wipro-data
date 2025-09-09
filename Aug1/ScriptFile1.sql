use sqlpractice
Go
--Display List of tables available in current database
select * from INFORMATION_SCHEMA.TABLES
GO
--Display information about Emp Table
sp_help Emp
Go
--Display all records from Emp table
select * from Emp
Go

-- Display Empno, Name, Basic from Emp table

select Empno 'Employ No', nam 'Employ Name', basic 'Salary' from Emp
Go

--Display All records whose Basic > 50000
select * from Emp
where basic>50000
go
--Display All records whose Dept si 'DOTNET'
SELECT * FROM Emp
where dept='DOTNET' 
GO
--Display all records whose name is 'Satish'
select * from Emp
where nam ='Satish'
go

-- Between...AND : Display records from specific Range (works for numbers and date only) 

select * from Emp
where basic not between 50000 and 60000
go

--IN Clause : Used to check for multiple values of particular column

-- Display all records whose Dept is Java or Dotnet or Sql 
select * from Emp
where dept in ('Java','Dotnet','sql')
go

select * from Emp
where nam in ('Manu','Satish','Swapna','Smitha','Rushi')
go

-- LIKE operator : Used to display data w.r.t. wild cards

-- Display all records whose name starts with 'S'

select * from Emp
where nam like 's%'
go
-- Display all records whose name ends with 'A' 
select * from Emp
where nam like '%A'
go

-- Distinct : Eliminate duplicate entries at the time of display 

select Dept from Emp
go
select distinct dept from Emp
go

-- Order By : Used to display values w.r.t. Particular field(s) in ascending or descending order 

select * from Emp order by nam
go
select * from Emp order by nam desc
go
