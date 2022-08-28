# C_Sharp
Let's learn deeply C# language and their frameworks together...
## Object–Relational mapping 
Object-Relational Mapping or ORM is a technique for converting data between C# objects and relational databases.
ORM converts data between two incompatible type systems (C# and MySQL), such that each model class becomes a table in our database and each instance a row of the table.
</br>

Entity Framework is an open source object–relational mapping framework for ADO.NET. It was originally shipped as an integral part of .NET Framework. Starting with Entity Framework version 6, it has been delivered separately from the .NET Framework.
<!--// ADO1.sql-->

## CodeFirst_Sample
**CRUD OPERATIONS**

- CodeFirst1.sln
- sql.txt
<!--Images-->


## CodeFirst_ORM_GUI
- ORM_WinForms1.sln
- sql.txt
<!--Images-->
### ORM_WinForms1
1. Create Employee
2. Main Menu
3. Update Employee
4. Delete Employee
5. Display Employee Details

## DBFirst_Sample
**CRUD OPERATIONS**
- DBFirst.sln
- sql.txt
<!--Images-->


## DBFirst_Form_ORM_GUI
- DBFirst_Form.sln
- sql.txt
<!--Images-->
### DBFirst_Form
1. CRUD OPERATIONS

## Notes:
### CodeFirst:
1. Add all Dependecies
1. CREATE MODEL CLASS AND IT MUST HAVE A PRIMARY KEY/ Entity Class
2. CREATE dbCONTEXT CLASS/ DBConnection file/ persistence.xml

3. Create database

	**Tools>>NuGet Package Manager>>Package Manager Console**

	PM> add-migration newDatabaseName

	PM>update-newDatabaseName –verbose

	*Automatically created Migration package, It means connection establish in C# & Sql.*

### Dependencies:
	microsoft.entityframeworkcore.sqlserver
	Microsoft.EntityFrameworkCore.Tools
	microsoft.entityframeworkcore.design
	microsoft.entityframeworkcore

### DBFirst:
1. CREATE Database first
2. Add all dependecies
2. Create Models package
2. Connect our project to Database

    **For C# Project:**
    
	Scaffold-DbContext "Server=...;Database=...;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

	**For DotNet Project:**

	dotnet ef dbcontext scaffold "Server=...;Database=...;Integrated security=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models

	DBContext class/ persistence file & Model/ Entity class are created


3. Create database(Not Compulsory)

	Tools>>NuGet Package Manager>>Package Manager Console

	PM> add-migration newDatabaseName

	PM>update-newDatabaseName –verbose

	*Automatically created Migration package, It means connection establish in C# & Sql.*

### Dependencies:
	 ENTITRYFRAMEWORK
	 ENTITYFRAMEWORK SQLSERVER
	 ENTITY FRAMEWORK TOOL 
	 Microsoft.EntityFrameworkCore.Design




