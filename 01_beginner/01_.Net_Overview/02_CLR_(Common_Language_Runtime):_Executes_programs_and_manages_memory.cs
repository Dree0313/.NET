__________________________________________________________________________
/* 
Beginner .NET: Common Language Runtime (CLR)
Purpose: Understand what the CLR is, how it executes programs, and manages
  memory */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  understand how your C# programs are executed, how memory is managed, and
  how errors are handled, so you can write reliable and efficient 
  applications.

Goal: Learn what the CLR does and why it's essential for running .NET
    programs */

__________________________________________________________________________
/* 
1️ What is the CLR?
  What it does: The Common Language Runtime is the exectution engin for
    .NET applications. It runs your programs, manages memory, handles 
    errors, and ensures security.
  Why use it: Lets developers focus on writing code rather than dealing 
    with low-level system details like memory allocation or CPU 
    instructions
  Core concept: Think of CLR as the "engine" that drives your application,
    taking your C# or other .NET language code and making it run on any
    device with .NET installed.
  Example: You write a console app to calculate a sum. The CLR executes it, 
    keeps track of variables in memory, and ensures the program doesn't 
    crash the system.*/
__________________________________________________________________________
// Code Example: (C# console app)
  int a = 5;
  int b = 10;
  int sum = a + b;
  Console.WriteLine($"Sum: {sum}");

/* 
Expected Result:
  Sum: 15 appears in the console output */

__________________________________________________________________________
/* 
2 How the CLR Executes Code
  What it does: 
    - Converts Intermediate Language (IL) code into machine code using the
      Just-In-Time (JIT) compiler
    - Loads and runs programs
    - Handles program startup and shutdown
  Why use it: Developers don't need to worry about CPU-specific 
    instructions or compiling for each platform */
__________________________________________________________________________
/* 
3 Memory Management
  What it does: 
    - Allocates memory for objects you create
    - Tracks which objects are in use and automatically cleans up unused
      ones via Garbage Collection
  Why use it: Prevents memory leaks and crashes, making programs more 
    reliable */
__________________________________________________________________________
// Example: Creating objects and letting CLR manage memory
      class Person{
        public string Name{get; set;}
      }

      Person p = new Person();
      p.Name = "Alexandria"
      Console.WriteLine(p.Name);

/* 
Expected Result:
  Alexandria appears in the console output
  CLR automatically handles memory for the Person object*/

__________________________________________________________________________
/* 
4 Error Handling and Security
  What it does:CLR monitors runtime errors (exceptions) and ensures safe
    code execution.
  Why use it: Developers can focus on handling errors in their code instead
    of worrying about crashing the system. */
__________________________________________________________________________
// Code Example: Exception handling
  try{
    int zero = 0;
    int result = 10 / zero;
  }
  catch (DivideByZeroException ex){
    Console.WriteLine("Cannot divide by zero!");
  }

/* 
Expected Result:
  Cannot divide by zero! is printed instead of crashing the program */
