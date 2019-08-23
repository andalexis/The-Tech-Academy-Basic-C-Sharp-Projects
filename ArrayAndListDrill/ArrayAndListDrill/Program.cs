using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListDrill
{
    class Program
    {
        static void Main()
        {
            
            
            string[] flowerArray = new string[5];
            flowerArray[0] = "Daisy";
            flowerArray[1] = "Tulip";
            flowerArray[2] = "Rose";
            flowerArray[3] = "Orchid";
            flowerArray[4] = "Sunflower";

            Console.WriteLine("Select an index of the Array (0-4): ");
            int indexPick = Convert.ToInt16(Console.ReadLine());
            switch (indexPick)
            {
                case 0:
                    Console.WriteLine("Index 0 in this array is: " + flowerArray[0]);
                    break;
                case 1:
                    Console.WriteLine("Index 1 in this array is: " + flowerArray[1]);
                    break;
                case 2:
                    Console.WriteLine("Index 2 in this array is: " + flowerArray[2]);
                    break;
                case 3:
                    Console.WriteLine("Index 3 in this array is: " + flowerArray[3]);
                    break;
                case 4:
                    Console.WriteLine("Index 4 in this array is: " + flowerArray[4]);
                    break;
                default:
                    Console.WriteLine("That index doesn't exist! Moving on...");
                    break;
            }
            //Console.WriteLine(indexPick);
            Console.ReadLine();

            int[] numArray = new int[] { 2, 4, 6, 8, 10 };
            Console.WriteLine("Choose an index of this array (0-4): ");
            int numPick = Convert.ToInt16(Console.ReadLine());
            switch (numPick)
            {
                case 0:
                    Console.WriteLine("Index 0 in this array is: " + numArray[0]);
                    break;
                case 1:
                    Console.WriteLine("Index 1 in this array is: " + numArray[1]);
                    break;
                case 2:
                    Console.WriteLine("Index 2 in this array is: " + numArray[2]);
                    break;
                case 3:
                    Console.WriteLine("Index 3 in this array is: " + numArray[3]);
                    break;
                case 4:
                    Console.WriteLine("Index 4 in this array is: " + numArray[4]);
                    break;
                default:
                    Console.WriteLine("That index doesn't exist! Moving on... ");
                    break;
            }
            Console.ReadLine();

            List<int> numList = new List<int>();
            numList.Add(88);
            numList.Add(99);
            numList.Add(22);
            numList.Add(44);
            numList.Add(33);

            Console.WriteLine("Choose an index of this list (0-4): ");
            int listPick = Convert.ToInt32(Console.ReadLine());
            switch (listPick)
            {
                case 0:
                    Console.WriteLine("Index 0 in this list is: " + numList[0]);
                    break;
                case 1:
                    Console.WriteLine("Index 1 in this list is: " + numList[1]);
                    break;
                case 2:
                    Console.WriteLine("Index 2 in this list is: " + numList[2]);
                    break;
                case 3:
                    Console.WriteLine("Index 3 in this list is: " + numList[3]);
                    break;
                case 4:
                    Console.WriteLine("Index 4 in this list is: " + numList[4]);
                    break;
                default:
                    Console.WriteLine("That index doesn't exist in this list. Moving on...");
                    break;
            }
            Console.ReadLine();

        }
    }
}
