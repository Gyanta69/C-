// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ConsoleApp
{
    public class Circle
    {
        const double PI = 3.14;

        public static double GetArea(double radius)
        {
            return PI * radius * radius;
        }

        public static double GetCircumference(double radius)
        {
            return 2 * PI * radius;
        }

    }

}