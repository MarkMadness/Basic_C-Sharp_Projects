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
            
            Employee em = new Employee();
            Employee emp = new Employee();
            em.iD = "1234";
            emp.iD = "2345";

            string status = em == emp;

            Console.WriteLine(status);
            Console.ReadLine();
        }
    }
}
