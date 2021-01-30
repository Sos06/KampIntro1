--select 

Select * from Customers

Select Contactname,CompanyName,City from Customers

Select * from Customers where City= 'London' 

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by ProductName

select * from Products where CategoryID = 1 order by UnitPrice desc

select count(*) from Products where CategoryID = 2

select CategoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 


select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryId
where Products.UnitPrice>10 

select * from Products inner join [Order Details]
on Products.ProductID = [Order Details].ProductID

select * from Products left join [Order Details]
on Products.ProductID = [Order Details].ProductID


select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID 
where o.CustomerID is null --Burada Soldaki Tabloda Olup Sağdaki tabloda Olmayanı Getirdik. 









