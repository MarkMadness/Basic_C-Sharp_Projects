using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation(); // instantiate the class
            Console.WriteLine("Please enter a number.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            
            op.MathOp(inputOne, inputTwo); // calling the method passing the input numbers
            op.MathOp(x: inputOne); // calling the method in the class, specifying the parameters by name

            Console.ReadLine();
        }
    }
}
