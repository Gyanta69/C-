using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Create the following methods inside the Operators class:
//Add(int a, int b) — prints the sum of two numbers
//Subtract(int a, int b) — prints the difference
//Multiply(int a, int b) — prints the product
//Divide(int a, int b) — prints the result of division
namespace Lab4ConsoleApp
{
    internal class Operators
    {
        public Operators() { }
        // Method to add two integers and print the result
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        }
        // Method to subtract two integers and print the result
        public void Substract(int a, int b)
        {
            Console.WriteLine($"The difference of {a} and {b} is: {a - b}");
        }
        // Method to multiply two integers and print the result
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"The product of {a} and {b} is: {a * b}");
        }
        // Method to divide two integers and print the result
        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"The result of division of {a} by {b} is: {a / b}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }

        //Create another method inside the same class:

        //OddEvenFinder(int number) — determines whether the given number is Odd or Even using the Ternary Operator(? :)
        //and prints the message "Even Number" or "Odd Number".
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine($"{number} is an {result}");
        }

    }
}
