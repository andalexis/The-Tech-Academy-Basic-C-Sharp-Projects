using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndLoopDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drill number 1
            string[] Array1 = new string[5];
            Array1[0] = "Grapes";
            Array1[1] = "Apple";
            Array1[2] = "Orange";
            Array1[3] = "Pinapple";
            //Array1[4] = "Peach";

            Console.WriteLine("Type a name of a fruit: ");
            string userFruit = Convert.ToString(Console.ReadLine());
            Array1[4] = userFruit;

            Console.WriteLine("\n");
            foreach (string fruit in Array1)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();

            // Drill number 2: This made the infinite loop
            //int i = 5;
            //while (i == 5) 
            //{
            //    Console.WriteLine("Repeating");
            //}
            //Console.ReadLine();

            // Drill Numbers 3 and 4: uses "<" operator 
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine("Good Loop");
                i++;
            }
            Console.ReadLine();

            // Drill number 5
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

            // Drill number 6
            List<string> alphabet = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.WriteLine("Type any letter of the alphabet: ");
            string userLetter = Console.ReadLine();
            string match = userLetter.ToLower();
            
            foreach (string letter in alphabet)
            {
                if (letter == userLetter)
                {
                    match = letter;
                    Console.WriteLine("You typed the letter " + match);
                    break; // Drill number 8: the break will stop the execution
                }
                else // Drill number 7 
                    Console.WriteLine("That's not a letter of the alphabet...");
                break;
            }
            Console.ReadLine();

            //// Drill number 9
            //List<string> weekNames = new List<string>() { "saturday", "sunday", "friday", "monday", "tuesday", "wednesday", "monday", "thursday", "friday", "saturday", "sunday" };
            //Console.WriteLine("What is your favorite day of the week?: ");
            //string day = Console.ReadLine();
            //string dayMatch = day.ToLower();

            //foreach (string name in weekNames)
            //{
            //    if (name == dayMatch)
            //        Console.WriteLine()
            //}

            // Drill number 10

            // Drill number 11
            List<string> animals = new List<string>() { "Panda", "Monkey", "Lion", "Zebra", "Hippo", "Hippo", "Penguin", "Monkey" };
            List<string> duplicate = new List<string>.Distinct().ToList();

            foreach (string animal in animals)
            {
                if (!animals.Contains(animal))
                    animals.Add(animal)

            }





        }
    }
}
