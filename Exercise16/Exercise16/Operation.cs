using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Operation
    {
        public static void OutProvide(out int num)
        {
            num = 2;
        }
        public void MathOp(int x)
        {
            int num;
            OutProvide(out num);
            int answer = x / num;
            int remain = x % num;
            Console.WriteLine("Your number divided by " + num + " = " + answer + " with a remainder of " + remain);
        }
    }
}
