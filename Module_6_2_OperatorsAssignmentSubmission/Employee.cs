using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_2_OperatorsAssignmentSubmission
{
    internal class Employee
    {
        //1 Create an Employee class with Id, FirstName and LastName properties. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //2a. overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee a, Employee b)
        {
            if (a is null && b is null)
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            return a.Id == b.Id;
        }

        //2b. overload the “!=” operator becuase comparison operators must be overloaded in pairs.
        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return Id == other.Id;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}