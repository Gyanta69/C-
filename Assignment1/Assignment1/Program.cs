// See https://aka.ms/new-console-template for more information

using Assignment1;

// Calling Variable-based Questions
Variables vars = new Variables();
vars.DisplayInfo();

Calculator calc = new Calculator();
calc.PerformCalculations();

// Calling If-Else based Questions
IfElse ifElse = new IfElse();
ifElse.CheckEvenOdd();

LargestNumber largestNum = new LargestNumber();
largestNum.FindLargest();

VotingEligibility votingEligibility = new VotingEligibility();
votingEligibility.CheckEligibility();

StudentGrade studentGrade = new StudentGrade();
studentGrade.DisplayGrade();

// Calling Loops ()
Sum sumTask = new Sum();
sumTask.Execute();

// 8. Write a program in C# to display the multiplication table of a given number using a while loop
MultiplicationTable mt = new MultiplicationTable();
mt.Execute(5);

// 9. Write a program in C# to calculate the factorial of a given number using a for loop.
Factorial factorialTask = new Factorial();
long factorial = factorialTask.Execute(5);
Console.WriteLine($"Factorial of 5 is: {factorial}");

// 10. Write a program in C# to reverse a given number using a while loop.
ReverseNumber reverseTask = new ReverseNumber();
int reversedNumber = reverseTask.Execute(12345);
Console.WriteLine($"Reversed Number: {reversedNumber}");

// 11. Write a program in C# to generate the first 10 Fibonacci numbers using a for loop.
Fibonacci fib = new Fibonacci();
fib.Execute();





