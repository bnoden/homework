// Author: Brandon Oden
// Course: C# Programming
// Program 2.1
// References: None
using System;
namespace UniqueYearDigits
{
    class UniqueYearDigitsBO
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a year: ");
                string year = Console.ReadLine();
                int yearInt = Convert.ToInt32(year);

                for (int i = yearInt; i < 10000; i++)
                {
                    string nextYear = Convert.ToString(i);
                    if (nextYear[0] != nextYear[1] && nextYear[0] != nextYear[2] && nextYear[0] != nextYear[3] &&
                        nextYear[1] != nextYear[2] && nextYear[1] != nextYear[3] && nextYear[2] != nextYear[3])
                        Console.WriteLine("The next distinct year: " + nextYear); break;
                }
            }

        }
    }
}