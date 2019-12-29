using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userInput = Console.ReadLine();
            File.WriteAllText("C:\\Users\\TTA_DEN_01\\Desktop\\C#_Course\\Projects\\EXERCISES\\Exercise23\\log.txt", userInput);
            Console.WriteLine("Your logged number: " + File.ReadAllText("C:\\Users\\TTA_DEN_01\\Desktop\\C#_Course\\Projects\\EXERCISES\\Exercise23\\log.txt"));
            Console.ReadLine();
        }
    }
}
