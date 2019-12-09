using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Operation
    {
        public int MathOp(int one)
        {
            int answer = one + 5;
            Console.WriteLine("The answer for the first method is " + answer);
            return answer;
        }
        public decimal MathOp(decimal two)
        {
            decimal a = 23.543m;
            decimal answer = a + two;
            Console.WriteLine("The answer for the second method is " + answer);
            int ansGive = Convert.ToInt32(answer);
            return ansGive;
        }
        public string MathOp(string three)
        {
            int numThree = Convert.ToInt32(three);
            int answer = numThree + 7;
            Console.WriteLine("The answer for the third method is " + answer);
            string ansGive = Convert.ToString(answer);
            return ansGive;
        }
    }
}
