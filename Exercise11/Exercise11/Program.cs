using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>() { 23, 345, 34, 95, 104, 57 };
            try
            {
                Console.WriteLine("We have a list of numbers. Type a number that you wish to divide all the listed numbers by.");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 6; i++)
                {
                    int answer = numbersList[i] / input;
                    Console.WriteLine(numbersList[i] + " divided by " + input + " equals " + answer);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by Zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The try/catch operation is done! Congratulations, you can go back to watching YouTube videos.");
            }
            Console.ReadLine();
        }
    }
}
