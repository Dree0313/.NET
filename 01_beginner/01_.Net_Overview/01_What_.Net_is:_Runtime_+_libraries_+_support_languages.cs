__________________________________________________________________________
/* 
Beginner .NET: What .NET Is (Runtime + Libraries + Languages)
Purpose: Understand the fundamentals of .NET, how it runs apps, and what
  languages it supports */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  understand the tools you'll be using so you can build, run, and maintain
  applications effectively

Goal: Learn the building blocks of .Net to prepare for writing your first
    program */

__________________________________________________________________________
/* 
1️ What is .NET?
  What it does: Provides a platform for building and running applications
    including runtime, libraries, and language support
  Why use it: Ensures your apps can run consistently across devices and
    leverage prebuilt functionality
  Core concept: Think of .Net as a toolbox and workshop combined 
  Example: You eant to write a console app that prints "Hello World". .NET 
    handles running the program, memory, and access to librarires.*/
__________________________________________________________________________
// Code Example: (C# console app)
  Console.WriteLine("Hello World!");

/* 
Expected Result:
  Hello World! appears in the console output */

__________________________________________________________________________
/* 
2 Runtime
  What it does: The runtime executes your code, handles memory, errors, 
    and security
  Why use it: Lets developers focus on writing functionality instead of 
    low-level system details */
__________________________________________________________________________
/* 
3 Libraries
  What it does: Provides prewritten code for common tasks like file 
    handling, math operations, or text processing
  Why use it: Saves time and ensures reliability */
__________________________________________________________________________
// Example: Using a library to read a file:
      using System.IO;
      string text = File.ReadAllText("example.txt");
      Console.WriteLine(text);

/* 
Expected Result:
  Contents of example.txt are printed to the console */

__________________________________________________________________________
/* 4 Suppoeted Languages
  What it does: Allows multiple languages to compile into .NET 
    Intermediate Language (IL) and run on the runtime
  Why use it: Offers flexibility to choose a language you are comfortable
    with while using the same platform */
