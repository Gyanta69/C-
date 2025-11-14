using System;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    // Loop-based Questions - split into one internal class per task

    // Write a program in C# to find the sum of the first 10 natural numbers using a for loop.
    internal class Sum
    {
        public void Execute()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of first 10 natural numbers: " + sum);
        }
    }

    // 8. Write a program in C# to display the multiplication table of a given number using a while loop
    internal class MultiplicationTable
    {
        public void Execute(int number, int upto = 10)
        {
            int i = 1;
            while (i <= upto)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            }
        }
    }

    // 9. Write a program in C# to calculate the factorial of a given number using a for loop.
    internal class Factorial
    {
        public long Execute(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.", nameof(n));

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                // Use checked to surface overflow for large n
                result = checked(result * i);
            }

            Console.WriteLine($"{n}! = {result}");
            return result;
        }
    }

    // 10. Write a program in C# to reverse a given number using a while loop.
    internal class ReverseNumber
    {
        public int Execute(int number)
        {
            int sign = number < 0 ? -1 : 1;
            long n = Math.Abs((long)number);
            long reversed = 0;

            while (n > 0)
            {
                reversed = reversed * 10 + (n % 10);
                n /= 10;
            }

            reversed *= sign;

            if (reversed < int.MinValue || reversed > int.MaxValue)
                throw new OverflowException("Reversed number overflows the range of Int32.");

            Console.WriteLine($"Reversed number: {reversed}");
            return (int)reversed;
        }
    }

    // 11. Write a program in C# to print the first 10 terms of the Fibonacci series using a loop.
    internal class Fibonacci
    {
        public void Execute(int terms = 10)
        {
            if (terms <= 0)
            {
                Console.WriteLine("Number of terms must be positive.");
                return;
            }

            long a = 0, b = 1;
            for (int i = 1; i <= terms; i++)
            {
                Console.WriteLine($"Term {i}: {a}");
                long next = a + b;
                a = b;
                b = next;
            }
        }
    }
}

