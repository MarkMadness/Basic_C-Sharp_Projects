using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a whole number between 1 and 100.");
            string userInputOne = Console.ReadLine();
            int userInputOneconvert = Int32.Parse(userInputOne);
            int EquationOne = userInputOneconvert * 50;
            Console.WriteLine("You number multiplied by 50 = " + EquationOne);
            Console.ReadLine();

            Console.WriteLine("Do it again! Another number!");
            string userInputTwo = Console.ReadLine();
            int userInputTwoconvert = Int32.Parse(userInputTwo);
            int EquationTwo = userInputTwoconvert + 25;
            Console.WriteLine("Your number added to 25 = " + EquationTwo);
            Console.ReadLine();

            Console.WriteLine("Do it again! Another number!");
            string userInputThree = Console.ReadLine();
            int userInputThreeconvert = Int32.Parse(userInputThree);
            double EquationThree = userInputThreeconvert / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + EquationThree);
            Console.ReadLine();

            Console.WriteLine("Do it again! Another number!");
            string userInputFour = Console.ReadLine();
            int userInputFourconvert = Int32.Parse(userInputFour);
            bool EquationFour = userInputFourconvert > 50;
            Console.WriteLine("Is your number greater than 50? :" + EquationFour.ToString());
            Console.ReadLine();

            Console.WriteLine("Do it again! Another number!");
            string userInputFive = Console.ReadLine();
            int userInputFiveconvert = Int32.Parse(userInputThree);
            int EquationFive = userInputFiveconvert % 7;
            Console.WriteLine("The remainder of your number divided by 7 = " + EquationFive);
            Console.ReadLine();
        }
    }
}
