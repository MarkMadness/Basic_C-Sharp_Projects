using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Write 'true' or 'false'.");
            string DUIanswer = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            // Casting
            int ageNum = Int32.Parse(age);
            bool DUIbool = Convert.ToBoolean(DUIanswer);
            int ticketsNum = Int32.Parse(tickets);
            if (ageNum >= 15 && DUIbool != true && ticketsNum < 4)
                Console.WriteLine("You are Qualified for car insurance!");
            else
                Console.WriteLine("You are not qualified for car insurance. Sorry. :(");
            Console.ReadLine();

        }
    }
}
