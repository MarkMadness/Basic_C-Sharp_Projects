using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you Jerry? Type 'true' or 'false'");
            bool name = Convert.ToBoolean(Console.ReadLine());
            bool Correct = name = true;

            do
            {
                switch (name)
                {
                    case true:
                        Console.WriteLine("Hello Jerry! Welcome!");
                        Correct = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, non-Jerry's are not welcome here! Try again when you're Jerry.");
                        name = Convert.ToBoolean(Console.ReadLine());
                        break;
                }
            }

            while (!name);

            // Next operation

            int X = 0;
            Console.WriteLine("Enter an number between 1 and 10");
            int num = Convert.ToInt32(Console.ReadLine());

            while (X < 50)
            {
                switch (num)
                {
                    default:
                        X = X + num;
                        Console.WriteLine("Do it again!");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine("Too many numbers! OVERLOAD! SYSTEM SHUTTING DOWN...... :(");
            Console.ReadLine();
        }
    }
}
