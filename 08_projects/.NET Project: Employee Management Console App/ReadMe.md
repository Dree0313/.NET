🖥 .NET Project: Employee Management Console App

Purpose:
Build a simple console application that allows you to manage employees and departments. This will help you practice .NET foundations, C# basics, OOP, and simple data handling — exactly the skills UAB expects.

1️⃣ Project Setup

Create a Console App in Visual Studio or VS Code using C#.

Organize the project with folders:

Models → for your classes (Employee, Department)

Services → for operations (AddEmployee, RemoveEmployee, UpdateSalary)

Program.cs → main program logic

2️⃣ Models (OOP)

Employee Class

Properties: Id, FirstName, LastName, DepartmentId, Salary, IsActive

Methods: PrintDetails()

Department Class

Properties: Id, Name

Methods: PrintDetails()

Optional: Enum for DepartmentType (HR, IT, Finance, etc.)

3️⃣ Core Features / Functionality

Level 1 – Beginner

Print all employees to the console

Print all departments

Add a new employee

Update an employee’s salary

Remove an employee

Simple console menu navigation (while loop + switch/case)

Level 2 – Junior Developer

Filter employees by department

Show only active employees (IsActive == true)

Sort employees by salary (ascending / descending)

Calculate total payroll per department (SUM)

Calculate average salary per department (AVG)

Search employees by name or ID

4️⃣ Advanced Console Interactions (Optional Level 2 Skills)

Validate input to prevent invalid IDs or salaries

Exception handling when parsing user input

Use methods in the Services folder to separate logic from Program.cs

Persist data temporarily using lists (List<Employee>)

5️⃣ Mini Challenges / Exercises

Print employees whose salary > $70,000

Count how many employees are in each department

Find the employee with the highest salary

Update a department name and see changes reflected in employee reports

Deactivate an employee (IsActive = false)

Add a sub-menu for department management (add/remove/rename)

6️⃣ Expected Learning Outcomes

After completing this project, you should be able to:

Understand .NET runtime + libraries + C# basics

Use classes, objects, and methods effectively

Perform basic data operations and filtering

Write a console application with structured menus

Handle input validation and exceptions

Practice OOP principles applied to real-world data

Deliverables
1️⃣ Source Code

Program.cs → main console application logic

Models/Employee.cs → Employee class definition

Models/Department.cs → Department class definition

Services/EmployeeService.cs → methods for adding, updating, deleting, filtering employees

Services/DepartmentService.cs → methods for adding, updating, deleting departments

2️⃣ Project Structure

Organized folders: Models, Services, Program.cs

Proper naming conventions for classes and methods

Solution file (.sln) if using Visual Studio

3️⃣ Functionality Demonstration

Console app menu that allows:

Viewing all employees

Viewing all departments

Adding/updating/removing employees

Filtering/sorting employees by salary, department, or active status

Calculating payroll totals or averages

Optional: Department management menu

4️⃣ Documentation

A README file including:

Project purpose

How to run the app

Features implemented

Any known issues or limitations

Inline comments in code explaining:

Methods

Important logic or calculations

Class purpose and relationships

5️⃣ Sample Data

Predefined list of employees and departments for testing

Examples to demonstrate:

Adding a new employee

Updating salary

Filtering by department

Aggregations (total/average salaries)

6️⃣ Optional Extra (Shows Initiative)

Exception handling (invalid input, negative salaries)

Input validation

Sub-menu for department management

Highlight use of OOP principles in code structure
