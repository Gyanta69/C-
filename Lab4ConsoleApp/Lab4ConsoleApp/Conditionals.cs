using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ConsoleApp
{
    internal class Conditionals
    {
        public Conditionals() { }

        public void CheckAge(int age)
        {
            Console.WriteLine("Please enter your age:");

            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age < 13)
                {
                    Console.WriteLine("Child");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("Teenager");
                }
                else if (age >= 20)
                {
                    Console.WriteLine("Adult");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }

        // Ask user to input a number (1–7) and using switch, print the day of the week: 
        public void SwitchExample(int dayNumber)
        {
            Console.WriteLine("Please enter a number (1-7) to get the corresponding day of the week:");
            if (int.TryParse(Console.ReadLine(), out dayNumber))
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }



    }
}
