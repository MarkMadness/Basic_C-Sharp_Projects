using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            List<string> text = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Type a word.");
                text.Add(Console.ReadLine());
            }
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine(text[y]);
            }
            Console.ReadLine();
            // #2 & #3 & #4
            bool runloop = true;
            while (runloop == true)
            {
                for (int z = 0; z < 10; z++)
                {
                    Console.WriteLine("infinite loop time!!!");
                }
                runloop = false;
            }
            // #5
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("i = " + i);
            }
            // #6 & #7 & #8
            List<string> names = new List<string>() { "Jerry", "James", "Michael", "Henry" };
            Console.WriteLine("The names available are: Jerry, James, Michael, and Henry");
            Console.WriteLine("Which name do you choose?");
            string answer = Console.ReadLine();
            for (int j = 0; j < 4; j++)
            {
                if (answer == names[0])
                {
                    Console.WriteLine("You chose the name that was in index 0.");
                    break;
                }
                if (answer == names[1])
                {
                    Console.WriteLine("You chose the name that was in index 1.");
                    break;
                }
                if (answer == names[2])
                {
                    Console.WriteLine("You chose the name that was in index 2.");
                    break;
                }
                if (answer == names[3])
                {
                    Console.WriteLine("You chose the name that was in index 3.");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does not match a name in the list.");
                    break;
                }
            }
            // #9 & #10
            List<string> namesTwo = new List<string>() { "Zack", "James", "Michael", "Henry", "Zack" };
            Console.WriteLine("The names available are: Zack, James, Michael, Henry, and Zack");
            Console.WriteLine("Which name do you choose?");
            string answerTwo = Console.ReadLine();
            for (int j = 0; j < 5; j++)
            {
                if (answerTwo == namesTwo[0])
                {
                    Console.WriteLine("You chose the name that was in index 0 and 4.");
                    break;
                }
                if (answerTwo == namesTwo[1])
                {
                    Console.WriteLine("You chose the name that was in index 1.");
                    break;
                }
                if (answerTwo == namesTwo[2])
                {
                    Console.WriteLine("You chose the name that was in index 2.");
                    break;
                }
                if (answerTwo == namesTwo[3])
                {
                    Console.WriteLine("You chose the name that was in index 3.");
                    break;
                }
                else
                {
                    Console.WriteLine("Your input does not match a name in the list.");
                    break;
                }
            }
            // #11
            List<string> namesThree = new List<string>() { "Jon", "Harry", "Gordon", "Gordon", "Aaron" };
            int x = 0;
            foreach (string name in namesThree)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (namesThree[x] == namesThree[k])
                    {
                        if (x == k)
                        {
                            Console.WriteLine("Same.");
                        }
                        else
                        {
                            Console.WriteLine(name + " already exists in the list.");
                            break;
                        }
                    }
                }
                x++;
            }
            Console.ReadLine();
        }
    }
}