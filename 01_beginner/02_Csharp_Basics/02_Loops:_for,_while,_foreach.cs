__________________________________________________________________________
/* 
Beginner .NET: Loops
Purpose: Understand how to repeat code using for, while, and foreach loops 
  in C# */
__________________________________________________________________________

/* 
Scenerio:
  You are a junior developer at a company. Your manager wants you to
  process multiple items, repeat tasks, and automate repetitive logic
  instead of writing the same code mulitple times.

Goal: Learn how to use loops to repeat code efficiently in C# */

__________________________________________________________________________
/* 
1️ What is a Loop?
  What it does: A loop repeats a block of code multiple times.
  Why use it: Prevents duplication and allows programs to process large
    amounts of data efficiently
  Core concept: Think of a loop as telling your program, "Keep doing this
    until a condition changes."
  Example: Printing numbers 1 through 5 automatically */
__________________________________________________________________________
/*
Code Example: Basic for Loop */
  for (int i = 1; i <= 5; i++)
  {
    Console.WriteLine(i);
  }
/*
Expected Result:
  1
  2
  3
  4
  5*/

__________________________________________________________________________
/* 
2 for Loop
  What it does: Repeats code a specific number of times
  Why use it: Best when you know exactly how many times to repeat
  Structure: for (initializaiton; condiiton; increment) */
__________________________________________________________________________
/* 
Example: */
  for (int count = 0; count < 3; count++)
  {
    Console.WriteLine("Learning loops!");

/*
Expected Result:
  Leaning loops!
  Leaning loops!
  Leaning loops! */

__________________________________________________________________________
/* 
3 while Loop
  What it does: Repeats code as long as a condition remains true.
  Why use it: Useful when you do not know how many times the loop should
    run before hand.
  */
__________________________________________________________________________
/* 
Example: */
  int number = 1;
    
  while (number <= 3)
  {
    Console.WriteLine(number);
    number++;
  }

/*
Expected Result:
  1
  2
  3 */

__________________________________________________________________________
/* 
4 foreach Loop
  What it does: Iterates through each item in a collection (like an array
    or list).
  Whhy use it: Simplest way to process all iteams in a collection */
__________________________________________________________________________
/* 
Example: */
  string[] names = {"Alexandria", "Jordan", "Taylor"};

  foreach (string name in names)
  {
    Console.WriteLine(name);
  }

/* Expected Results:
  Alexandria
  Jordan
  Taylor */
      
__________________________________________________________________________
/* 
5 When to Use Each Loop
  for Loop:
    - When you know how many times to repeat
    - When you need an index number

  while Loop:
    - When repeating until a condiiton changes
    - When count is not predetermined

  foreach Loop:
    - When working with collections
    - When you do not need an index */

__________________________________________________________________________
/* 
6 Best Practices for Variables
  - Ensure the condition eventually becomes false
  - Avoid infinite loops
  - Keep loop logic simple and readable
  - Use foreach when possible for cleaner code */
__________________________________________________________________________
