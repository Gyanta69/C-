using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4ConsoleApp
{
    internal class Exceptions
    {
        //Write a program that accepts a number from the user and converts it to an integer.
        //If user enters invalid input (e.g., letters), catch the exception and show:"Invalid number format".
        //Display "Program Executed" in finally block.
        public void ConvertToInteger()
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(userInput);
                Console.WriteLine($"You entered the number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }
        //Write a program that asks for a password.
        //If password length is less than 6 characters, use throw to raise exception: "Password must be at least 6 characters."    
        //Otherwise, print "Password satisfied the requirement". 
        public void CheckPassword()
        {
            Console.WriteLine("Please enter a password:");
            string password = Console.ReadLine();
            try
            {
                if (password.Length < 6)
                {
                    throw new ArgumentException("Password must be at least 6 characters.");
                }
                else
                {
                    Console.WriteLine("Password satisfied the requirement");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

}


