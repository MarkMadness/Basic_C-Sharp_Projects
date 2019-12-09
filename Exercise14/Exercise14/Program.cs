using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 5;
            decimal two = 34.5647m;
            string three = "2";

            Operation op = new Operation();

            op.MathOp(one);
            op.MathOp(two: two);
            op.MathOp(three: three);

            Console.ReadLine();
        }
    }
}
