using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Operation
    {
        public string MathOne(int i)
        {
            int answer = i + 1;
            string giveAnswer = Convert.ToString(answer);
            return giveAnswer;
        }
        public string MathTwo(int i)
        {
            int answer = i - 1;
            string giveAnswer = Convert.ToString(answer);
            return giveAnswer;
        }
        public string MathThree(int i)
        {
            int answer = i * 2;
            string giveAnswer = Convert.ToString(answer);
            return giveAnswer;
        }
    }
}
