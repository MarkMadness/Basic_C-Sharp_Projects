using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Week week = new Week();
                Console.WriteLine("Please type the current day. Capitalize the first letter.");
                string answer = Console.ReadLine();
                Enum.Parse(typeof(DaysOfTheWeek), answer);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
