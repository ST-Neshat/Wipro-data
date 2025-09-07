select * from Agent
go
select AgentID, FirstName, LastName, City, MaritalStatus
from Agent
go

--Write a query ensure, if MaritalStatus is 0 THEN 'Unmarried' if MaritalStatus is '1' then Married

select AgentID, FirstName, LastName, City, MaritalStatus, 
CASE MaritalStatus 
when 0 then 'Unmarried'
when 1 then 'Married'
end as Marital_Status
from Agent
go

select PolicyID, AppNumber,AppDate, AnnualPremium,PayMentModelID,
case PayMentModelID
when 1 then 'Yearly'
when 2 then 'Half Yearly'
When 3 then 'Quarterly'
end 'Payment Mode'
from Policy
go