using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("This is the Person Class - Method SayName(). This is the name {0} {1}", firstName, lastName);
        }
    }
}
