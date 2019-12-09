using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Operation
    {
        public void MathOp(int x, int y)
        {
            int answer = x + 1;
            Console.WriteLine("Your second input was " + Convert.ToString(y));
        }

        public void MathOp(int x)
        {
            Console.WriteLine("This is an overloaded method.");
        }
    }
}
