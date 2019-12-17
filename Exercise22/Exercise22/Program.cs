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
                if (employ.firstName == "Joe")
                {
                    joeList.Add(employ);
                }
            }

            List<string> joeListTwo = emList.Where(x => x.firstName == "Joe").ToList();
            //List<string> joeListTwo = em.firstName.FindAll("Joe").ToList();

            //List<int> emListId5 = emListId.Where(x => x > 5).ToList();

            ////======Second attempt=======================
            //Employee em = new Employee();
            //List<string> emListFirst = new List<string>() { "Joe", "Sara", "Kevin", "Sammy", "Blake", "Michael", "Jennifer", "Harry", "Joe", "Larry" };
            //List<string> emListSecond = new List<string>() { "Sullivan", "Jackson", "Smith", "Jeffner", "Tarley", "Lawson", "Houston", "Potter", "White", "Kingsman"};
            //List<int> emListId = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<string> joeList = new List<string>();

            //foreach (string employ in emListFirst)
            //{
            //    if (employ == "Joe")
            //    {
            //        joeList.Add(employ);
            //    }
            //}

            //List<string> joeListTwo = emListFirst.Where(x => x == "Joe").ToList();

            //List<int> emListId5 = emListId.Where(x => x > 5).ToList();

            Console.ReadLine();
        }
    }
}
