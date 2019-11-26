using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 5;
            numArray[3] = 100;
            numArray[4] = 4000;
            string[] stringArray = new string[4];
            stringArray[0] = "Mark1";
            stringArray[1] = "Mark2";
            stringArray[2] = "Mark3";
            stringArray[3] = "Mark4";
            List<string> stringList = new List<string>();
            stringList.Add("First Cell");
            stringList.Add("Second Cell");
            stringList.Add("Third Cell");
            stringList.Add("Fourth Cell");
            stringList.Add("Fifth Cell");

            Console.WriteLine("We have an array of integers, string and a list of strings.");
            Console.WriteLine("Type a number corresponding to the index of the integer array you want to see.");
            int firstArrayInput = Convert.ToInt32(Console.ReadLine());
            if (firstArrayInput > 5)
            {
                Console.WriteLine("I'm sorry. There is no index of " + firstArrayInput + " in the integer array.");
            }
            else
            {
                firstArrayInput = firstArrayInput - 1;
                Console.WriteLine(numArray[firstArrayInput]);
            }

            Console.WriteLine("\tOnto the string array.");
            Console.WriteLine("Type a number corresponding to the index of the string array you want to see.");
            int secondArrayInput = Convert.ToInt32(Console.ReadLine());
            if (secondArrayInput > 4)
            {
                Console.WriteLine("I'm sorry. There is no index of " + secondArrayInput + " in the string array.");
            }
            else
            {
                secondArrayInput = secondArrayInput - 1;
                Console.WriteLine(stringArray[secondArrayInput]);
            }

            Console.WriteLine("\tOnto the string List.");
            Console.WriteLine("Type a number corresponding to the index of the string list you want to see.");
            int listInput = Convert.ToInt32(Console.ReadLine());
            if (listInput > 4)
            {
                Console.WriteLine("I'm sorry. There is no index of " + listInput + " in the string list.");
            }
            else
            {
                listInput = listInput - 1;
                Console.WriteLine(stringList[listInput]);
            }

            Console.ReadLine();
        }
    }
}
