using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            string line1 = "The quick brown";
            string line2 = "fox jumped over";
            string line3 = "the lazy dog.";

            string text = line1 + " " + line2 + " " + line3;
            Console.WriteLine(text.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("I think we can all agree that movie theater snacks are overpriced.");
            sb.Append(" My friends and I wanted to go see a movie and we decided to smuggle in food and drinks.");
            sb.Append(" I wanted a sprite so I poured it into a water bottle.");
            sb.AppendLine(" My mistake was using a water bottle with one of those flip up straws...");
            sb.Append(" At the theater, a few minutes into the start of the movie, I wanted my sprite.");
            sb.Append(" I flipped up the rubber straw and a volcano of fizzy sprite spewed 6 FEET in the air, soaking everyone around me!");
            sb.AppendLine(" I ran out of the theater mortified, and now I buy my sodas AT the theater.");
            sb.Append("True story...");



            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
