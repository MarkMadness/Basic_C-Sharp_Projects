using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            //======first attempt==========================
            Employee em = new Employee();
            List<Employee> emList = new List<Employee>(10);
            List<Employee> joeList = new List<Employee>();
            emList.Add(new Employee { firstName = "Joe", lastName = "Sullivan", iD = 1 });
            emList.Add(new Employee { firstName = "Sara", lastName = "Jackson", iD = 2 });
            emList.Add(new Employee { firstName = "Kevin", lastName = "Smith", iD = 3 });
            emList.Add(new Employee { firstName = "Sammy", lastName = "Jeffner", iD = 4 });
            emList.Add(new Employee { firstName = "Blake", lastName = "Tarley", iD = 5 });
            emList.Add(new Employee { firstName = "Michael", lastName = "Lawson", iD = 6 });
            emList.Add(new Employee { firstName = "Jennifer", lastName = "Houston", iD = 7 });
            emList.Add(new Employee { firstName = "Harry", lastName = "Potter", iD = 8 });
            emList.Add(new Employee { firstName = "Joe", lastName = "White", iD = 9 });
            emList.Add(new Employee { firstName = "Larry", lastName = "Kingsman", iD = 10 });

            foreach (Employee employ in emList)
            {
                if (em.firstName == "Joe")
                {
                    joeList.Add(employ);
                }
            }



            Console.ReadLine();
        }
    }
}
