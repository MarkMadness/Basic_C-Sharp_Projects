using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    public class NegativeException : Exception
    {
        public NegativeException()
            : base() { }
    }
    public class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of your age.");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What year were you born?");
                int year = Convert.ToInt32(Console.ReadLine());

                if (age == 0 || year == 0) throw new ZeroException();
                if (age < 0 || year < 0) throw new NegativeException();

                Console.WriteLine("You were born in " + year + ".");
            }
            catch(ZeroException)
            {
                Console.WriteLine("You entered a zero. You can't do that. Try again.");
                Console.ReadLine();
                return;
            }
            catch(NegativeException)
            {
                Console.WriteLine("You entered a negative input. You can't do that. Try again.");
                Console.ReadLine();
                return;
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error in your answer. Try again.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
