using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4ConsoleApp
{
    internal class Loops
    {
    //Ask the user to input a number N.
    //Using a for loop, calculate and print the sum from 1 to N.
    //Example: Input: 5 → Output: 15
        public void SumUpToN()
        {
            Console.WriteLine("Please enter a number N:");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                int sum = 0;
                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum from 1 to {N} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        //Print numbers from 1 to 20 using while loop:
        //Skip(continue) multiples of 4
        //Stop(break) when number is 15
        public void WhileLoopExample()
        {
            int number = 1;
            while (number <= 20)
            {
                if (number % 4 == 0)
                {
                    number++;
                    continue; // Skip multiples of 4
                }
                if (number == 15)
                {
                    break; // Stop when number is 15
                }
                Console.WriteLine(number);
                number++;
            }
        }


        // Write a program to find the sum of all elements in an array using a foreach loop.
        public void SumOfArrayElements()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num; // Add each element to sum
            }
            Console.WriteLine($"The sum of all elements in the array is: {sum}");
        }

    }
}
