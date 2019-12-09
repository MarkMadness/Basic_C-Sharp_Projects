using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();

            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());

            op.MathOp(x: input);

            Console.ReadLine();
        }
    }
}
