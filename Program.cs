using System;

namespace Star_Trek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast antal navne der skal genereres: ");
            int antal = int.Parse(Console.ReadLine());
            string[] navn_M = new string[antal];
            string[] navn_F = new string[antal];
            int tal = 3;
            while (2 + tal != 4)
            {
                Console.WriteLine("Indtast køn på Vulcan M/F: ");
                var userinput = Console.ReadKey(true).Key;
                if (userinput == ConsoleKey.M)
                {
                    for (int i = 0; i < antal; i++)
                    {
                        navn_M[i] = navn_Male();
                    }
                    tal = 2;
                }
                else if (userinput == ConsoleKey.F)
                {
                    for (int i = 0; i < antal; i++)
                    {
                        navn_F[i] = navn_Female();
                    }
                    tal = 2;
                }
            }
        }
        static string navn_Male()
        {
            Random rnd = new Random();
            string[][] parts =
            {
            new string[]{ "S", "Sp", "Sk", "St", "T" },
            new string[]{ "a", "e", "i", "o", "u", "y" },
            new string[]{ "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" },
            new string[]{ "a", "e", "i", "o", "u", "y" },
            new string[]{ "q", "p", "k", "ck", "l" }
            };
            string navn = "";
            foreach (string[] part in parts)
            {
                navn += part[rnd.Next(0, part.Length)];
            }
            return navn;
        }
        static string navn_Female()
        {
            Random rnd = new Random();
            string[][] parts =
            {
            new string[] { "T'" },
            new string[] { "P", "K", "Q" },
            new string[] { "a", "e", "i", "o", "u", "y" },
            new string[] { "r", "j", "'p", "k", "l" }
            };

            string navn = "";
            foreach (string[] part in parts)
            {
                navn += part[rnd.Next(0, part.Length)];
            }
            return navn;
        }
        static bool lovligt(string navn)
        {



            return false;
        }
    }
}

