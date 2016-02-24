// Author: Brandon Oden
// Course: C# Programming
// Program 5_1
// References: None
using System;
using System.Collections.Generic;
using System.IO;

public class CostOfChristmasBO
{
    public static void Main(string[] args)
    {
        int day = 0;
        double cost = 0.00, total = 0.00;

        Console.WriteLine("Enter the file name: ");
        string filename = Console.ReadLine();
        List<string> list = new List<string>(); // List of days of christmas contents.
        CreatePriceIndexFile(filename, list);

        Console.WriteLine("Enter the day of Christmas: ");

        while (day.Equals(0))
        {
            string d = Console.ReadLine();
            switch (d.ToLower())
            {
                case "1": case "one": case "first": case "1st": day = 1; break;
                case "2": case "two": case "second": case "2nd": day = 2; break;
                case "3": case "three": case "third": case "3rd": day = 3; break;
                case "4": case "four": case "fourth": case "4th": day = 4; break;
                case "5": case "five": case "fifth": case "5th": day = 5; break;
                case "6": case "six": case "sixth": case "6th": day = 6; break;
                case "7": case "seven": case "seventh": case "7th": day = 7; break;
                case "8": case "eight": case "eighth": case "8th": day = 8; break;
                case "9": case "nine": case "ninth": case "9th": day = 9; break;
                case "10": case "ten": case "tenth": case "10th": day = 10; break;
                case "11": case "eleven": case "eleventh": case "11th": day = 11; break;
                case "12": case "twelve": case "twelfth": case "12th": day = 12; break;
                default: day = 0;
                    Console.WriteLine("There are 12 days of Christmas. Enter a number " +
                        "from 1 to 12: "); break;
            }
        }

        Console.WriteLine("The gifts for day {0} are: ", day);

        for (int i = 0; i < day; i++)
        {
            cost = Convert.ToDouble(list[i].Split(',')[2]); 
            total += cost;                                  
            Console.WriteLine(list[i].Split(',')[0] + " " +
                list[i].Split(',')[1]);
        }

        Console.WriteLine("Cost for day {0}: ${1:c}", day, cost);
        Console.WriteLine("Total cost for first {0} days: ${1:c}", day, total);

        Console.ReadKey();
    }

    public static void CreatePriceIndexFile(string filename, List<string> list)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(PriceIndex());
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
        }
    }

    public static string PriceIndex()
    {
        return "1,partridge in a pear tree,207.88\n" +
               "2,turtle doves,125.00\n" +
               "3,French hens,181.50\n" +
               "4,calling birds,599.60\n" +
               "5,golden rings,750.00\n" +
               "6,geese,360.00\n" +
               "7,swans,7000.00\n" +
               "8,maids,58.00\n" +
               "9,ladies,7552.84\n" +
               "10,lords,5348.24\n" +
               "11,pipers,2635.20\n" +
               "12,drummers,2854.80\n";
    }
}
