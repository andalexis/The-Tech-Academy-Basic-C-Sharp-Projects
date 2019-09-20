using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            List<string> alphabet = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "a", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.WriteLine("Type any letter of the alphabet: ");
            string userinput = Console.ReadLine();
            string userLetter = userinput.ToLower();

            // Console.WriteLine(userLetter); // prints lowercase letter
            // Console.ReadLine();

            bool match = false;
            foreach (string letter in alphabet)
            {
                if (userLetter == letter)
                {
                    Console.WriteLine("You typed the letter " + letter);
                    // Console.ReadLine();
                    match = true;
                    //break; // Drill 8: the break will exit the loop
                }

            }
            if (match != true)
            {
                Console.WriteLine("You didn't type a legit letter of the alphabet..."); //Drill 7
            }
            Console.ReadLine();

            // Drill number 9 
            List<string> weekNames = new List<string> { "monday", "tuesday", "monday", "wednesday", "thursday", "tuesday", "friday", "satuday", "sunday" };
            Console.WriteLine("What is your favorite day of the week?: ");
            string day = Console.ReadLine();
            string dayMatch = day.ToLower();
            // Console.WriteLine(dayMatch);
            Console.ReadLine();

            bool instance = false;
            int n = 0;
            //bool instance = false;
            foreach (string d in weekNames)
            {
                if (dayMatch == d)
                {
                    Console.WriteLine("You said " + d + " which is at Index: " + n);
                    instance = true;
                }
                n++;
            }
            if (instance != true)
            {
                Console.WriteLine("Oops, that wasn't a day of the week!"); //Drill number 10
            }

            Console.ReadLine();

            // Drill number 11
            List<string> dogBreeds = new List<string> { "Bulldog", "Poodle", "Golden Retriever", "German Shepard", "Bulldog", "Poodle" };
            List<string> myDistinct = new List<string> ();
            
            foreach (string one in dogBreeds)
            {
                Console.WriteLine(one);
            }

            Console.WriteLine("");
            foreach (string breed in dogBreeds)
            {
                if (myDistinct.Contains(breed))
                {
                    Console.WriteLine("The breed " + breed + " has made two apperances so far");
                }
                else
                {
                    Console.WriteLine("The breed " + breed + " has made one apperances so far");
                    myDistinct.Add(breed);
                    
                }

            }
            Console.ReadLine();

        }     
    }
}