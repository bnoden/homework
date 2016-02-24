// Author: Brandon Oden
// Course: C# Programming
// Program 5_3
// References: None
using System;
using System.Linq;

public class LINQShortWordsBO
{
    public static void Main(string[] args)
    {
        string[] wordIndex = ShortWords().Split(' ');
        int validInput = 0;

        while (true)
        {
            Console.WriteLine("\nEnter character range: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out validInput))
            {
                Console.WriteLine("Input invalid. Please enter integer.");
                continue;
            }

            int range = Convert.ToInt32(input);

            var words = from word in wordIndex
                        where word.Length < range
                        select word;

            while (!wordIndex.Any(word => word.Length < range))
            {
                Console.WriteLine("There are no results within the specified range.");
                Console.WriteLine("\nEnter character range: ");
                range = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Continue? y/n");
            if (Console.ReadLine().ToLower().Equals("n"))
            {
                break;
            }
        }
    }

    public static string ShortWords()
    {
        return "antelope bear cat dolphin elephant frog giraffe " +
            "hippopotamus iguana jaguar koala llama moose newt okapi";
    }
}