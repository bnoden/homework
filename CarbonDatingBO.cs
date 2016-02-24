// Author: Brandon Oden
// Course: C# Programming
// Program 1.2
// References: None
using System;

namespace CarbonDating
{
    public class CarbonDating
    {
        const double carbon14 = 5730; // The half-life of Carbon-14.

        public static void Main()
        {
            Console.WriteLine("This program calculates the age of a dead sample " +
                              "based on the ratio of Carbon 14 in a dead sample.");
            Console.WriteLine("\nEnter the ratio D/P: ");
            GetAge();
            Console.ReadLine();
        }

        // Get and display age based on input.
        static void GetAge()
        {
            double ratio = Convert.ToDouble(Console.ReadLine());
            // The following equation determines the age based on the Carbon-14 ratio.
            double age = carbon14 / Math.Log(2) * Math.Log(1 + ratio);
            Console.WriteLine("\nGiven a D/P ratio of {0} for C14, the age of " +
                              "the sample is {1:f2} years.", ratio, age);
        }
    }
}