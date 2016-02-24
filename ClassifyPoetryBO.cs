// Author: Brandon Oden
// Course: C# Programming
// Program 5_2
// References: None
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ClassifyPoetryBO
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the file name: ");
            string filename = Console.ReadLine();
            List<string> list = new List<string>(); // List of lines from poem.
            CreatePoemFile(filename, list); // Create file with random poem, named by user input.

            Console.WriteLine(Poems()); // Print poem from file.
            Console.WriteLine(PoetryForm(list)); // Determine and print poetry form.
            Console.WriteLine();
            
        }
    }
    // Determine and print poetry form.
    public static string PoetryForm(List<string> list) 
    {
        string[] lastWord = new string[list.Count]; // List of last word of each line in poem.

        for (int i = 0; i < lastWord.Length; i++) 
        {
            lastWord[i] = list[i].Split(' ').Last();
        }

        List<string> lastSyllable = new List<string>(); // List of last syllables, beginning with last vowel.

        for (int i = 0; i < lastWord.Length; i++)
        {
            for (int j = lastWord[i].Length - 1; j >= 0; j--)
            {
                switch (lastWord[i][j])
                {
                    case 'a': lastSyllable.Add("a" + lastWord[i].Split('a').Last()); break;
                    case 'e': lastSyllable.Add("e" + lastWord[i].Split('e').Last()); break;
                    case 'i': lastSyllable.Add("i" + lastWord[i].Split('i').Last()); break;
                    case 'o': lastSyllable.Add("o" + lastWord[i].Split('o').Last()); break;
                    case 'u': lastSyllable.Add("u" + lastWord[i].Split('u').Last()); break;
                }
            }
        }

        string a = lastSyllable[0], b = lastSyllable[1], c = lastSyllable[2], d = lastSyllable[3];
        // Determine poetry form based on last syllable of each line.
        // The rhyme pattern for each form:
        // AAAA = perfect AABB = even ABAB = cross ABBA = shell Anything else = free
        if (a == b && b == c && c == d)
            return "perfect rhyme";
        else if (a != c && a == b && c == d)
            return "even rhyme";
        else if (a != b && a == c && b == d)
            return "cross rhyme";
        else if (a != b && a == d && b == c)
            return "shell rhyme";
        else
            return "free rhyme";
    }
    // Create file with random poem, named by user input.
    public static void CreatePoemFile(string filename, List<string> list) 
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(Poems()); // Write poem to list randomly.
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
    // Write poem to list randomly.
    public static string Poems() 
    {
        List<string> verses = new List<string>();
        verses.Add("C Sharp is the best\nForget about the rest\nIf you don't pass the test\nYou are under arrest\n");
        verses.Add("Tigers are cats\nLipids are fats\nSome people like Python\nSome people like nylon\n");
        verses.Add("One plus one is small\none hundred plus one is not\nyou might be very tall\nbut summer is not\n");
        verses.Add("Turn on the lamp\nTurn off the fan\nOpen the can\nTighten the clamp\n");
        verses.Add("Yards have feet\nHighways have shoulders\nRoofs have shingles\nI have all three\n");

        Random r = new Random();

        return verses[r.Next(0, verses.Count)];
    }
}