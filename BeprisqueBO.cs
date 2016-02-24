// Author: Brandon Oden
// Course: C# Programming
// Program 1.3
// References: None
using System;

namespace Beprisque
{
    public class Beprisque
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(num);
            int numMinus = num - 1, numPlus = num + 1;
            int minusSqrt = (int)Math.Sqrt(numMinus), plusSqrt = (int)Math.Sqrt(numPlus);
            string isBeprisque = num + " is a beprisque number";
            string notBeprisque = num + " is not a beprisque number";
            for (int i = 3, j = 2; i < 1001 && j < 10; i++, j++)
            {
                if ((numMinus % i != 0) && (numPlus == plusSqrt * plusSqrt))
                {
                    Console.WriteLine(isBeprisque);
                    break;
                }
                else if ((numPlus % i != 0) && (numMinus == minusSqrt * minusSqrt))
                {
                    Console.WriteLine(isBeprisque);
                    break;
                }
                else if ((numMinus % j != 0) && (numPlus == plusSqrt * plusSqrt))
                {
                    Console.WriteLine(isBeprisque);
                    break;
                }
                else if ((numPlus % j != 0) && (numMinus == minusSqrt * minusSqrt))
                {
                    Console.WriteLine(isBeprisque);
                    break;
                }
                else
                    Console.WriteLine(notBeprisque);
                break;
            }
            Console.ReadLine();
        }
    }
}