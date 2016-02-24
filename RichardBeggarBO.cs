// Author: Brandon Oden
// Course: C# Programming
// Program 1.1
// References: None

using System;
namespace RichardBeggar

{
    public class MoneyKing
    {
        public static void Main()
        {
            Console.WriteLine("Day    Amount Owed");
            Console.WriteLine("---    -----------");

            for (int i = 1; i < 65; i++)    // Increments days from 1 to 64.
            {
                double pay = 0.01;  // Amount paid on first day.
                double newPay = pay * Math.Pow(2, i - 1);   // Doubles the payment amount each day.
                double totalPay = newPay * 1.5;   // Calulates total cumulative amount paid.

                Console.WriteLine("{0, 3:f0}    {1:c}", i, newPay);
            }
            // The following block determines and displays day that cumulative total reached $1 million.
            for (int j = 1; j < 65; j++)
            {
                double pay = 0.01;
                double newPay = pay * Math.Pow(2, j - 1);
                double totalPay = newPay * 1.5;

                if (totalPay >= 1000000 && totalPay < 1500000)
                    Console.WriteLine("\nOn day {0} the king paid a total of one million dollars.", j);
            }

            Console.ReadLine();

        }
    }
}