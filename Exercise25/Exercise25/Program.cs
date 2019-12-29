using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    public class Sentence
    {
        public string firstPart;
        public string secondPart;
        public Sentence(string firstPart) : this(firstPart, "Mark")
        {

        }
        public Sentence(string first, string second)
        {
            firstPart = first;
            secondPart = second;
        }
        public void PrintName()
        {
            Console.WriteLine(firstPart + secondPart);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            const string first = "My name is ";
            var second = "Mark";
            Sentence sen = new Sentence(first, second);
            sen.PrintName();
            Console.ReadLine();
        }
    }
}
