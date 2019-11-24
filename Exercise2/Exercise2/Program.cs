using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report: ");
            Console.WriteLine("     What Course are you working on?");
            string courseAnswer = Console.ReadLine();
            Console.WriteLine("     What page number?");
            string pageNum = Console.ReadLine();
            Console.WriteLine("     Do you need help with anything? Please answer 'true' or 'false'.");
            string boolAnswer = Console.ReadLine();
            bool helpAnswer = Convert.ToBoolean(boolAnswer);
            Console.WriteLine("     Were there any positivve experiences you'd like to share? Please give specifics.");
            string experienceAnswer = Console.ReadLine();
            Console.WriteLine("     Is there any other feedback you'd like to provide? Please be specific.");
            string feedbackAnswer = Console.ReadLine();
            Console.WriteLine("     How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
        }
    }
}
