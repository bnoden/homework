// Author: Brandon Oden
// Course: C# Programming
// Program 3.2
// References: None

using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Enter country name: ");
            string country = Console.ReadLine();
            char firstChar = country[0], lastChar = country[country.Length - 1];
            string article;

            if ((country).Equals("Belize") || (country).Equals("Cambodge") || (country).Equals("Mexique") ||
                (country).Equals("Mozambique") || (country).Equals("Zimbabwe"))
                article = "le ";
            else if ((lastChar).Equals('s'))
                article = "les ";
            else if ((firstChar).Equals('A') || (firstChar).Equals('E') || (firstChar).Equals('I') ||
                (firstChar).Equals('O') || (firstChar).Equals('U'))
                article = "l'";
            else if ((lastChar).Equals('e'))
                article = "la ";
            else
                article = "le ";

            Console.WriteLine("\n" + article + country + "\n");
        }
    }
}