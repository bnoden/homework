// Author: Brandon Oden
// Course: C# Programming
// Program 4.2
// References: None

using System;
using System.Collections.Generic;

namespace AnimalStuffBO
{
    class AnimalStuff
    {

        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Bird duck = new Bird();
            animals.Add(duck);
            duck.kind = "duck";
            duck.sound = "'quack'";

            Bird owl = new Bird();
            animals.Add(owl);
            owl.kind = "owl";
            owl.sound = "'hoo'";

            Mammal pig = new Mammal();
            animals.Add(pig);
            pig.kind = "pig";
            pig.sound = "'oink'";

            Mammal cow = new Mammal();
            animals.Add(cow);
            cow.kind = "cow";
            cow.sound = "'moo'";

            while (true)
            {
                Console.WriteLine("Enter animal: ");
                string search = Console.ReadLine();

                for (int i = 0; i < animals.Count; i++)
                {
                    string result = animals[i].kind;

                    if (search == result)
                    {
                        Console.WriteLine(animals[i]);
                    }
                }
            }

        }

public class Bird : Animal
        {
            public Bird()
            {
                kind = "";
                sound = this.Sound();
                integument = "feathers";
            }

            public override string Movement(bool fast)
            {
                if (fast == true)
                    return "I fly.";
                else
                    return "I walk on two legs.";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class Mammal : Animal
        {
            public Mammal()
            {
                kind = "";
                sound = this.Sound();
                integument = "hair";
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        public class Animal
        {
            public string integument, kind, sound;
            public bool fast;

            public virtual string Movement(bool fast)
            {
                if (fast == true)
                    return "I run on four legs.";
                else
                    return "I walk on four legs.";
            }

            public string Sound()
            {
                return sound;
            }

            public override string ToString()
            {
                return "I am a " + kind + ".\n" + "I have " + integument + ".\n" +
                    "When I go slowly, " + Movement(fast = false) + "\nWhen I go fast, " +
                    Movement(fast = true) + "\nThe sound I make is " + Sound() + ".\n";
            }
        }
    }
}
