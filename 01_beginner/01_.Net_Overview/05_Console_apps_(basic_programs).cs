__________________________________________________________________________
/* 
Beginner .NET: Console Applications
Purpose: Understand what console applications are, how they work, and when
  to use them */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  start with simple programs so you can focus on learning C#, program
  flow, and .NET fundamentals without worrying about user interfaces.

Goal: Learn what console applications are and how to create and run a
  basic program */

__________________________________________________________________________
/* 
1️ What is a Console Application?
  What it does: A console application is a basic program that runs in a
    command-line window and interacts with userrs through text input and
    output.
  Why use it: Console apps are simple, fast to build, and ideal for 
    learnig, testing logic, automation, and backend tasks.
  Core concept: Think of a console app as a conversation between your 
    program and the user using text only.
   Example: A program that asks for your name and prints a greeting in
     the terminal */
__________________________________________________________________________
/*
Code Example: Simple Console App */
  Console.WriteLine("What is your name?");
  string name = Console.ReadLine();
  Console.WriteLine($"Hello, {name}!");

/*
Expected Result:
  What is your name?
  user input: Alexandria
  Hello, Alexandria! */

__________________________________________________________________________
/* 
2 How Console Applications Run
  What it does: 
    - Program starrts at the entry point (Main method)
    - Code executes line by line
    - Output is written to the console window
  Why use it: Helps beginners understand program flow and execution 
    order */
__________________________________________________________________________
/* 
3 Creating a Console App with the .NET SDK
  What it does: Uses the .NET SDK to generate and run a console app
  Why use it: Saves time and ensures correct project setup
  */
__________________________________________________________________________
/* 
Example: Creating a console app
 dotnet new console
 dotnet run

Expected Result:
  A console window opens and runs the program */

__________________________________________________________________________
/* 
4 Common Uses of Console Applications
  Uses include:
    - Learning C# and .NET fundamentals
    - Writing scripts and automation tools
    - Running background or batch jobs
    - Testing business logic */
__________________________________________________________________________

__________________________________________________________________________
/* 
5 Console Apps vs Other App Types
  Console App:
    - Text-based
    - No graphical interface
    - Simple and lightweight
  GUI / Web App:
    - Visual interface
    - More setup and complexity
    - Built on top of the same .NET runtime */
__________________________________________________________________________
