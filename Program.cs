using System;

namespace Star_Trek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Tast \"1\" for at åbne Name_Generator");
                Console.WriteLine("Tast \"2\" for at afprøve navn");
                var userinput = Console.ReadKey(true).Key;
                if (userinput == ConsoleKey.D1)
                {
                    Name_Generator();
                }
                else if (userinput == ConsoleKey.D2)
                {
                    Console.WriteLine("M/F?");
                    Console.WriteLine();
                    userinput = Console.ReadKey(true).Key;
                    if (userinput == ConsoleKey.M)
                    {
                        Console.Write("Indtast navn: ");
                        string navn = Console.ReadLine();
                        if (Lovligt_Male(navn) == true)
                        {
                            Console.WriteLine("Gyldigt");
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt");
                        }
                    }
                    else if (userinput == ConsoleKey.F)
                    {
                        Console.Write("Indtast navn: ");
                        string navn = Console.ReadLine();
                        if (Lovligt_Female(navn) == true)
                        {
                            Console.WriteLine("Gyldigt");
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt");
                        }
                    }
                Console.WriteLine("");


                }
            }
        }
        static string Navn_Male()
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
        static string Navn_Female()
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
        static bool Lovligt_Male(string navn)
        {
            int antal_Syntaks = 5;

            if (navn.Length >= 5 && navn.Length <= 7)
            {
                string b = navn.Substring(0, 2);
                for (int i = 0; i < antal_Syntaks; i++)
                {
                    string a = navn.Substring(0, 1);
                    if (navn.Length >= 2)
                    {
                        b = navn.Substring(0, 2);
                    }
                    if (i == 0)
                    {
                        if (b == "Sp" || b == "Sk" || b == "St")
                        {
                            navn = navn.Remove(0, 2);
                            b = navn.Substring(0, 2);

                        }
                        else if (a == "S" || a == "T")
                        {
                            navn = navn.Remove(0, 1);
                            a = navn.Substring(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 1 || i == 3)
                    {
                        if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u" || a == "y")
                        {
                            navn = navn.Remove(0, 1);
                            a = navn.Substring(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (a == "r" || a == "t" || a == "p" || a == "d" || a == "f" || a == "j" || a == "k" || a == "l" || a == "v" || a == "b" || a == "n" || a == "m")
                        {
                            navn = navn.Remove(0, 1);
                            a = navn.Substring(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 4)
                    {
                        if (b == "ck")
                        {
                            navn = navn.Remove(0, 2);
                        }
                        else if (a == "q" || a == "p" || a == "k" || a == "l")
                        {
                            navn = navn.Remove(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        static bool Lovligt_Female(string navn)
        {
            int antal_Syntaks = 4;

            if (navn.Length >= antal_Syntaks && navn.Length <= antal_Syntaks + 2)
            {
                string b = navn.Substring(0, 2);
                for (int i = 0; i < antal_Syntaks; i++)
                {
                    string a = navn.Substring(0, 1);
                    if (navn.Length >= 2)
                    {
                        b = navn.Substring(0, 2);
                    }
                    if (i == 0)
                    {
                        if (b == "T'")
                        {
                            navn = navn.Remove(0, 2);
                            b = navn.Substring(0, 2);

                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 1)
                    {
                        if (a == "P" || a == "K" || a == "Q")
                        {
                            navn = navn.Remove(0, 1);
                            a = navn.Substring(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u" || a == "y")
                        {
                            navn = navn.Remove(0, 1);
                            a = navn.Substring(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (i == 3)
                    {
                        if (b == "'p")
                        {
                            navn = navn.Remove(0, 2);
                        }
                        else if (a == "r" || a == "j" || a == "k" || a == "l")
                        {
                            navn = navn.Remove(0, 1);
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        static void Name_Generator()
        {
            Console.Write("Indtast antal navne der skal genereres: ");
            int antal = int.Parse(Console.ReadLine());
            string[] navn_M = new string[antal];
            string[] navn_F = new string[antal];
            int tal = 3;
            while (2 + tal != 4)
            {
                Console.WriteLine("Indtast køn på de genererede navne (M/F): ");
                var userinput = Console.ReadKey(true).Key;
                if (userinput == ConsoleKey.M)
                {
                    for (int i = 0; i < antal; i++)
                    {
                        navn_M[i] = Navn_Male();
                        Console.Write($"{i + 1} ");
                        Console.WriteLine(navn_M[i]);
                    }
                    tal = 2;
                }
                else if (userinput == ConsoleKey.F)
                {
                    for (int i = 0; i < antal; i++)
                    {
                        navn_F[i] = Navn_Female();
                        Console.Write($"{i + 1} ");
                        Console.WriteLine(navn_F[i]);
                    }
                    tal = 2;
                }
            }
        }

    }
}

