using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Operation
    {
        public int MathOp(int x, int y = 5)
        {
            int answer = x + y;
            Console.WriteLine("Your first number is " + Convert.ToString(x) + ". The second number is " + 
                Convert.ToString(y) + ". \n   (If you didn't input a second number, the default if 5)");
            Console.WriteLine("The two numbers added together are " + Convert.ToString(answer) + ".");
            return answer;
        }
    }
}
