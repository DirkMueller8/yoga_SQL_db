# Database management with C# and ADO.NET

**********************************************
Software:		C# (v7.3)

.NET version:   4.7.2

Version:    	0.1

Date: 			Oct 25, 2020

Author:			Dirk Mueller 
**********************************************
This is an implementation adopted directly from the excellent tutorial of Tim Corey. Link to his youtube video: 

https://www.youtube.com/watch?v=Et2khGnrIqc&t=293s/ 

and to his website:

https://www.iamtimcorey.com/ 

It covers the following concepts:

1. ADO.NET to connect via C# code (in Visual Studio 2019) to a SQL database
2. Dapper as an object mapper for ADO.NET data reader (https://dapper-tutorial.net/dapper)
3. WinForm GUI
4. Utilization of stored procedures in SQL Server Management Studio to ensure a safe connection
5. Reading from a database (SELECT * FROM) by a search term for a particular column in T-SQL
6. Writing to (INSERT) the database in T-SQL

The SQL table looks like this (in SQL Server Management Studio):

![](https://github.com/DirkMueller8/yoga_SQL_db/blob/master/table_definition.png)

*Fig 1: SQL table tracking my yoga sessions (left) and table column definition (right)*

![](https://github.com/DirkMueller8/yoga_SQL_db/blob/master/screenshot.png)

*Fig 2: WinFrom snapshot of the GUI to insert search term (date) and to input a new yoga session into the SQL db.*