using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}";
            Console.WriteLine(msg);

            // each score will be an element in our array
            string path = @"C:\Users\andal\OneDrive\Documents\Code\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            double tScore = 0.0; // total score variable

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines) {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line); // convert to double since the data comes back as a text file
                tScore += score; // each score will be added to our running total
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
