__________________________________________________________________________
/* 
Beginner .NET: Intermediate Language (IL)
Purpose: Understand what IL is, why C# complies to IL, and how it fits 
  into the .NET execution process */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  understand what happens after you write C# code but before it runs. This
  helps you understand performance, portability, and how .NET works behind
  the scenes

Goal: Learn what IL is and why all .NET languages compile to it */

__________________________________________________________________________
/* 
1️ What is IL (Intermediate Language)?
  What it does: IL is a low-level, CPU-independent language that C# (and
    other .NET languages) compile into before execution.
  Why use it: Allows .NET applications to run on different systems without 
    recompiling source code for each CPU architecture.
  Core concept: Think of IL as a "middle step" between your C# code and
    machine code.
  Example: You write C# code. The compiler converts it into IL, not 
    machine code. The CLR later turns that IL into machine code when the 
    app runs.*/
__________________________________________________________________________
// Code Example: (C# console app)
  int a = 5;
  int b = 10;
  int sum = a + b;
  Console.WriteLine(sum);

/* 
Expected Result:
  This code is NOT executed yet.
  It is compiled into IL and stored inside the .NET assembly (.exe or 
    .dll).*/

__________________________________________________________________________
/* 
2 How C# Code Becomes IL
  What it does: 
    - The C# compiler (csc) translates C# source code into IL
    - IL is stored in an assembly alang with metadata
    - No machine-specific code is generated at this stage
  Why use it: One compiled program can run on multiple platforms supported
    by .NET*/
__________________________________________________________________________
/* 
3 What Does IL Look Like?
  What it does: IL uses simple instructions like load, store, add, and 
    call
  Why use it: Keeps instructions universal and easy for the CLR to 
    analyze */
__________________________________________________________________________
// Example: Simplified IL version of the C# code above
      Idc.i4.5 // load integer 5
      Idc.i4.s 10 // load integer 10
      add // add the two values
      stloc.0 //store result in a variable
      call void [System.Console]::WriteLine(int32)

/* 
Expected Result:
  The CLR will later convert this IL into machine code using the JIT 
    compiler*/

__________________________________________________________________________
/* 
4 IL and the CLR Relationship
  What it does:
    - IL is NOT executed directly by the CPU
    - The CLR reads IL and converts it to machine code at runtime
  Why use it: Enables features like garbage collection, security checks,
    and runtime optimizations*/
__________________________________________________________________________

__________________________________________________________________________
/* 
5 Why IL Matters to Developers
  Benefits:
    - Language independence (C#, VB.NET, F# all compile to IL)
    - Platform independence
    - Runtime optimization by the CLR
   Big picture: C# Code → IL → CLR → Machine Code → Program Runs*/
__________________________________________________________________________
