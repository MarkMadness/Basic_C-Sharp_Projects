using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A second number is an optional. Would you like to type a second number?");
            Console.WriteLine("    'Yes' or 'No'");
            string response = Console.ReadLine();
            Operation op = new Operation();

            if (response == "Yes")
            {
                Console.WriteLine("Please enter the second number.");
                int inputTwo = Convert.ToInt32(Console.ReadLine());
                op.MathOp(x: inputOne, y: inputTwo);
            }
            else
            {
                op.MathOp(inputOne);
            }

            Console.ReadLine();
        }
    }
}
