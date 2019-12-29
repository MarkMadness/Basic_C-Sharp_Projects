using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("The time right now is: " + time);
            Console.WriteLine("Please, enter a number.");
            double num = Convert.ToDouble(Console.ReadLine());
            time = time.AddHours(num);
            Console.WriteLine("The time in " + Convert.ToString(num) + " hours will be: " + time);
            Console.ReadLine();
        }
    }
}
