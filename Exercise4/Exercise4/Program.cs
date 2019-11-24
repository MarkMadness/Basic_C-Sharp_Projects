using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("     What is your Hourly Rate?");
            string person1hourlyrate = Console.ReadLine();
            Console.WriteLine("     How many hours do you work per week?");
            string person1hoursworked = Console.ReadLine();
            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("     What is your Hourly Rate?");
            string person2hourlyrate = Console.ReadLine();
            Console.WriteLine("     How many hours do you work per week?");
            string person2hoursworked = Console.ReadLine();
            // Weekly Salary
            Console.WriteLine("     Weekly Salary of Person 1?");
            string person1salary = Console.ReadLine();
            Console.WriteLine("     Weekly Salary of Person 2?");
            string person2salary = Console.ReadLine();
            // Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1compare = Int32.Parse(person1salary);
            int person2compare = Int32.Parse(person2salary);
            bool Compare = person1compare > person2compare;
            Console.WriteLine(Compare);
            Console.ReadLine();
        }
    }
}
