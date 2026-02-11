__________________________________________________________________________
/* 
Beginner .NET: Variables
Purpose: Understand how to declare and use different types of variables in
  C# (int, string, bool, etc.) and how to store and manipulate data */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to
  store and manipulate data in your programs, like numbers, text, or
  true / false values.

Goal: Learn how to declare variables, assign values, and use them in C# */

__________________________________________________________________________
/* 
1️ What is a Variable?
  What it does: A variable is a named storage location in memory that 
    holds data of a specific type.
  Why use it: Allows your program to store, retrieve, and manipulate data
  Core concept: Think of a variable as a labeled box where you can keep
    values that your program needs.
  Example: Storing a user's age, name, or login status in your program */
__________________________________________________________________________
/*
Code Example: Class in a Class Library */
  public class Greeting Service
  {
    public string GetGreeting(string name)
    (
      return $"Hello, {name}!";
    }
  }

/*
Expected Result:
 This code does not run by itself
  It must be referenced by anotherr application (console, web, etc.) */

__________________________________________________________________________
/* 
2 How Class Libraries Are Used
  What it does: 
    - Stores shared Logic
    - Exposes methods and classes
    - Is referenced by other .NET projects
  Why use it: Keeps applications small and focused while sharing common
      functionality */
__________________________________________________________________________
/* 
3 Creating a Class Library with the .NET SDK
  What it does: Uses the .NET SDK to generate a class library project
  Why use it: Ensures proper structure and compatibility
  */
__________________________________________________________________________
/* 
Example: Creating a class library
 dotnet new classlib

Expected Result:
  A class library project is created with a default Class1.cs file */

__________________________________________________________________________
/* 
4 Using a Class library in a Console App
  What it does: Adds a reference to the class library so its code can be
    used in an application
  Why use it: Separates business logic from application logic */
__________________________________________________________________________
/* 
Example: Using the class library in a console app */
  GreetingService service = new GreetingService();
  Console.WriteLine(service.GetGreeting("Alexandria"));

/* Expected Results:
  Hello, Alexandria is printed to the console */
      
__________________________________________________________________________
/* 
5 Common Uses of Class Libraries
  Uses include:
    - Business logic
    - Utility functions
    - Data access code
    - Shared validation rules */
__________________________________________________________________________

__________________________________________________________________________
/* 
6 Class Libraries vs Console Applications
  Class Library:
    - No Main method
    - Cannot run on its own
    - Designed for reuse
    
  Console App:
    - Has an entry point (Main)
    - Runs independently
    - Consumes class libraries */
__________________________________________________________________________
