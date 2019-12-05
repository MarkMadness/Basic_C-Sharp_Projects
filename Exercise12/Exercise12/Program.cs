using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            Console.WriteLine("What number do you want to do the math operations on?");
            int input = Convert.ToInt32(Console.ReadLine());

            string ansOne = op.MathOne(input);
            string ansTwo = op.MathTwo(input);
            string ansThree = op.MathThree(input);
            
            Console.WriteLine("Your number + 1 = " + ansOne);
            Console.WriteLine("Your number - 1 = " + ansTwo);
            Console.WriteLine("Your number x 2 = " + ansThree);
            Console.ReadLine();
        }
    }
}
