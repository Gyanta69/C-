// See https://aka.ms/new-console-template for more information

//call the methods of Operators.cs

using Lab4ConsoleApp;

Operators operators = new Operators();
operators.Add(10, 5);
operators.Substract(10, 5);
operators.Multiply(10, 5);
operators.Divide(10, 5);
operators.OddEvenFinder(10);
operators.OddEvenFinder(7);

//Task3: call the methods of NullOperators.cs
NullOperators nullOperators = new NullOperators();
nullOperators.PerformNullChecks();

//Task4: Ask user to input age  and using if – else – if display
// if the age is < 13 print child
// if the age is 13-19 print teenager
// if the age is >=20 print adult

//Task 4: calling the method from Conditionals.cs 
Conditionals conditionals = new Conditionals();
conditionals.CheckAge(0);
conditionals.SwitchExample(0);

//Task 5: calling the method from Loops.cs
Loops loops = new Loops();
loops.SumUpToN();
loops.WhileLoopExample();
loops.SumOfArrayElements();

//Task 6: calling the method from Exceptions.cs
Exceptions exceptions = new Exceptions();
exceptions.ConvertToInteger();
exceptions.CheckPassword();




