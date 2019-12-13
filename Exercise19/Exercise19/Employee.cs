using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    public class Employee: Person
    {
        public string iD { get; set; }
        public static string operator ==(Employee a, Employee b)
        {
            if (a.iD == b.iD)
            {
                string status = "The IDs are equal to each other.";
                return status;
            }
            else
            {
                string status = "The IDs are not equal to each other.";
                return status;
            }
        }
        public static string operator !=(Employee a, Employee b)
        {
            if (a.iD != b.iD)
            {
                string status = "The IDs are not equal to each other.";
                return status;
            }
            else
            {
                string status = "The IDs are equal to each other.";
                return status;
            }
        }
    }
}
