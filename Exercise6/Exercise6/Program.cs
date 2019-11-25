using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("     What is the weight of your package in pounds?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight >= 50)
            {
                Console.WriteLine("Your package is too heavy. You'll need to start again.");
            }
            else
            {
                Console.WriteLine("What is the width of your package in inches?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of your package in inches?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package in inches?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int measureSum = packageHeight + packageLength + packageWidth;
                if (measureSum > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("");
                    int Total = (measureSum * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Convert.ToString(Total));
                }
            }
            Console.ReadLine();
        }
    }
}
