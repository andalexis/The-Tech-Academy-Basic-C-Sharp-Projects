﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //// iterate over the array: create a for loop
            //// starting value, for how many times, what to do after the loop runs
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Sage", "Ashton", "Echo" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Sage")
            //    //{
            //    //    Console.WriteLine(names[j]);
            //    //}

            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Alex", "Sage", "Alice", "Quinn" };

            //foreach (string name in names)
            //{
            //    //if (name == "Sage")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
