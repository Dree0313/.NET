__________________________________________________________________________
/* Beginner .NET: What .NET Is (Runtime + Libraries + Languages)
Purpose: Understand the fundamentals of .NET, how it runs apps, and what
  languages it supports */
__________________________________________________________________________

/* Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  understand the tools you'll be using so you can build, run, and maintain
  applications effectively

  Goal: Learn the building blocks of .Net to prepare for writing your first
    program */

__________________________________________________________________________
/* 1️ What is .NET?
  What it does: Provides a platform for building and running applications
    including runtime, libraries, and language support
  Why use it: Ensures your apps can run consistently across devices and
    leverage prebuilt functionality
  Core concept: Think of .Net as a toolbox and workshop combined */
__________________________________________________________________________
/* Example: 
  You eant to write a console app that prints "Hello World". .NET handles
  running the program, memory, and access to librarires.

Code Example: (C# console app) */
  Console.WriteLine("Hello World!");

/* Expected Result:
  Hello World! appears in the console output */

__________________________________________________________________________
-- 2 Select Specific columns
-- What it does: Retrieves only the columns specified
-- Why use it: Helps focus on relevant data and reduce clutter
-- Syntax: SELECT column1, column2 FROM table_name;
__________________________________________________________________________
-- Problem:
  -- HR only wants first and last names to send birthday emails

--Solution:
SELECT first_name, last_name
FROM employees;

-- Expected Result:
  -- first_name  Alice    Bob   Carol   Dave    Eve
  -- last_name  Johnson  Smith  Davis  Wilson  Taylor

__________________________________________________________________________
-- 3 Column aliases
-- What it does: Gives a temporary name to a column for readability
-- Why use it: Makes results easier to understnad, especially for reports
-- Syntax: SELECT column AS alias_name FROM table_name;
__________________________________________________________________________
-- Problem:
  -- HR wants the columns labeled nicely in the report

-- Solution:
SELECT first_name AS "First Name", last_name AS "Last Name"
FROM employees;

-- Expected Result:
  -- First Name  Alice    Bob   Carol   Dave    Eve
  -- Last Name  Johnson  Smith  Davis  Wilson  Taylor

__________________________________________________________________________
-- 4 DISTINCT keyword
-- What it does: Returns only unique values, removing duplicates
-- Why use it: Helps identify unique entries or categories in a table
-- Syntax: SELECT DISTINCT column FROM table_name;
__________________________________________________________________________
-- Problem:
  -- HR wants a list of unique departments

-- Solution:
SELECT DISTINCT department
FROM employees;

-- Expected Result:
  -- department  HR  IT  Finance

__________________________________________________________________________
-- 5 Literals
-- What it does: Adds static text or numbers to query results
-- Why use it: Can label results or add context without changing the table
-- Syntax: SELECT column, 'Literal' AS alias FROM table_name;
__________________________________________________________________________
-- Problem:
  -- HR wants a list of employees with their roles labeled

-- Solution:
SELECT first_name, 'Employee' AS role
FROM employees;

-- Expected Result:
  -- first_name  Alice      Bob      Carol      Dave      Eve
  -- role       Employee  Employee  Employee  Employee  Employee
__________________________________________________________________________
-- 6 Concatenation (SQLite-specific)
-- What it does: Combines values from multiple columns into one
-- Why use it: Useful for full names, addresses, or other combined fields
-- Syntax: SELECT column || ' ' || column2 AS alias FROM table_name;
__________________________________________________________________________
-- Problem:
  -- HR wants full names in one column

-- Solution:
SELECT first_name || ' ' || last_name AS full_name
FROM employees;

-- Expected Result:
  -- full_name  Alice Johnson  Bob Smith  Carol Davis  Dave Wilson  Eve Taylor

