using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "This is one, ";
            string two = "this is two, ";
            string three = "and this is three.";
            Console.WriteLine(one + two + three);

            string lowerc = "all uppercase now";
            string upperc = lowerc.ToUpper();
            Console.WriteLine(upperc);

            StringBuilder sb = new StringBuilder();

            sb.Append("This is sentence one for the StringBuilder.");
            sb.Append("This is sentence two for the StringBuilder.");
            sb.Append("This is sentence three for the StringBuilder.");
            sb.Append("This is sentence four for the StringBuilder.");
            sb.Append("This is sentence five for the StringBuilder.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
