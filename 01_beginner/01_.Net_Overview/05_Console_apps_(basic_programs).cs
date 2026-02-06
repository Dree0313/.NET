__________________________________________________________________________
/* 
Beginner .NET: SDK vs Runtime
Purpose: Understand the difference between the .NET SDK and the .NET 
  Runtime, what each does, and when you need them */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to 
  understand what tools you need to build .NET applications versus what
  is required to run them in production environments

Goal: Learn the difference between the .NET SDK and .NET Runtime and when
  each one is needed */

__________________________________________________________________________
/* 
1️ What is the .NET SDK?
  What it does: The Software Developmnet Kit (SDK) includes everything
    needed to build, test, and package .NET applications
  Why use it: Deveolopers need the SDK to write code, compile it, and 
    create executable programs.
  Core concept: Think of the SDK as a workshop with all the tools to 
    create an application.
  Includes:
    - Compilers (C# compiler)
    - dotnet CLI (build, run, test, publish)
    - Project templates
    - Build tools */
__________________________________________________________________________
/* Example: Using the SDK to create and run a project
  dotnet new console
  dotnet build
  dotnet run

 
Expected Result:
  A new console applicaiton is created, compiled into IL, and executed.*/

__________________________________________________________________________
/* 
2 What is the .NET Runtime?
  What it does: The Runtime provides the components required to run .Net
    applications that have already been built.
  Why use it: Machines running .NET apps (servers, user PCs) do not need
    development tools, only the ability to execute the program. 
  Core concept: Think of the Runtime as the engine that runs the 
    application, but cannot build it.
  Includes:
    - Common Language Runtime (CLR)
    - Garbage Collector
    - Base Class Libraries required at runtime */
__________________________________________________________________________
/* 
3 SDK vs Runtime Comparison */
__________________________________________________________________________
/* 
SDK:
  - Build applications
  - Compile C# into IL
  - Create Projects
  - Used by developters

Runtime:
  - Run applications
  - Execute IL via the CLR
  - Manage memory and execcution
  - Used on production machines */

__________________________________________________________________________
/* 
4 When Do You Need Each One?
  Development machine: SDK required 
  Production server: Runtime only
  End-user computer: Runtime only */
__________________________________________________________________________

__________________________________________________________________________
/* 
5 How SDK and Runtime Work Together
  Flow:
    Write C# Code
    ↓
    SDK compiles code into IL
    ↓
    Application is packed as an assembly (.exe / .dll)
    ↓
    Runtime executes IL using CLR and JIT */
__________________________________________________________________________
