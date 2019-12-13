using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee em = new Employee();
            //Employee emp = new Employee();
            //em.iD = "1234";
            //emp.iD = "2345";
            //string status = em == emp;
            //Console.WriteLine(status);

            Employee<string> strEm = new Employee<string>();
            Employee<int> strEmTwo = new Employee<int>();
            strEm.things = new List<string> { "One", "Two", "Three" };
            strEmTwo.things = new List<int> { 1, 2, 3 };

            for (int i = 0;i < 3; i++)
            {
                Console.WriteLine(strEm.things[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(strEmTwo.things[i]);
            }


            Console.ReadLine();
        }
    }
}
