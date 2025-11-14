using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Variables
    {
        //Variable-based Questions
        // 1. Write a program in C# to declare variables for name, age, and address. Display them

        private string name = "Pragyan Khadka";
        private int age = 19;
        private string address = "Kathmandu, Nepal";

        public void DisplayInfo()
        {
            Console.WriteLine("Displaying Personal Information");
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }


    }
    // 2. Write a program in C# to input two numbers and display their sum, difference, product, and quotient.
    internal class Calculator
    {
        public void PerformCalculations()
        {
            Console.WriteLine("Calculator for Two Numbers");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient = num1 / num2;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}");
        }
    }
}
