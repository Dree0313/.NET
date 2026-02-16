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
Code Example: Declaring and Using Variables */
  int age = 25;
  string name = "Alexandria";
  bool isStudent = true;
  Console.WriteLine($"Name: {name}, Age: {age}, Student: {isStudent}");

/*
Expected Result:
  Name: Alexandria, Age: 25, Student: true */

__________________________________________________________________________
/* 
2 Common Variable Types in C#
  int - Whole numbers (e.g., 10, -5)
  double - Decimal numbers (e.g., 3.14, 0.5)
  string - Text (e.g., "Hello World")
  bool - True / False values (e.g., true, false)
  char - Single characters (e.g., 'A', 'z')
  var - Compiler infers type from assigned value */
__________________________________________________________________________
/* 
3 Declaring Variables
  Why use it: Gives the compiler information about what kind of data will
    be stored
  Syntax: <type> <name> = <value>;
  */
__________________________________________________________________________
/* 
Example: */
  int score = 100;
  string message = "Hello";

/*
Expected Result:
  score is set to an integer value of 100 and message is set to a string
  value of Hello */

__________________________________________________________________________
/* 
4 Using Variables in Expressions
  What it does: You can perform operations using variables like addition,
    concatenation, or logical checks. */
__________________________________________________________________________
/* 
Example: */
  int x = 10;
  int y = 5;
  int sum = x + y;
  Console.WriteLine($"Sum: {sum}");

  bool isGreater = x > y;
  Console.WriteLine($"Is x greater than y? {isGreater}");

/* Expected Results:
  Sum: 15
  Is x greater than y? True */
      
__________________________________________________________________________
/* 
5 Variable Scope
  What it does: Variables exist only in the context where they are 
    declared
  Why use it: Helps prevent naming conflicts and unexpected behavior */
__________________________________________________________________________
/*
Example:
  - Local variables: Inside a method
  - Class variables (fields): Available to all methods in a class */

__________________________________________________________________________
/* 
6 Best Practices for Variables
  - Use meaningful names (e.g., userName, totalScore)
  - Declare variables close to where they are used
  - Initialize variables before use
  - Keep scope as small as possible */
__________________________________________________________________________
