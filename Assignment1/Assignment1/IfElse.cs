using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class IfElse
    {
        //If-Else based Questions
        //3. Write a program in C# to input a number and check whether it is even or odd
        public void CheckEvenOdd()
        {
            Console.WriteLine("Check Even or Odd");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

    }
    // 4. Write a program in C# to input three numbers and find the largest among them using if-else.
    internal class LargestNumber
    {
        public void FindLargest()
        {
            Console.WriteLine("Find the Largest Number among Three Numbers");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largest;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
    // 5. Write a program in C# that asks the user to enter their age and checks voting eligibility.
    internal class VotingEligibility
    {
        public void CheckEligibility()
        {
            Console.WriteLine("Check Voting Eligibility");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
    }
    //6. Write a program in C# to input marks of a student and display grade (A, B, C, Fail).
    internal class StudentGrade
    {
        public void DisplayGrade()
        {
            Console.WriteLine("Display Student Grade");
            Console.Write("Enter marks obtained: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            char grade;
            if (marks >= 90)
            {
                grade = 'A';
            }
            else if (marks >= 75)
            {
                grade = 'B';
            }
            else if (marks >= 60)
            {
                grade = 'C';
            }
            else
            {
                grade = 'F'; // Fail
            }
            Console.WriteLine($"The grade is: {grade}");
        }
    }
}
