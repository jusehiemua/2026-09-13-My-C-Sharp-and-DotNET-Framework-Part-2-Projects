using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_2_OperatorsAssignmentSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3a. Instantiate two objects (but I made it "three objects") of the Employee class and initialize the properties of these 3 objects. 

            Employee employee1 = new Employee();
            employee1.Id = 1201;
            employee1.FirstName = "Jesse";
            employee1.LastName = "Smith";
            string fullName1 = employee1.FirstName + " " + employee1.LastName;

            Employee employee2 = new Employee();
            employee2.Id = 3251;
            employee2.FirstName = "Julius";
            employee2.LastName = "Ehiemua";
            string fullName2 = employee2.FirstName + " " + employee2.LastName;


            Employee employee3 = new Employee();
            employee3.Id = 1201;
            employee3.FirstName = "Jumoke";
            employee3.LastName = "Umeh";
            string fullName3 = employee3.FirstName + " " + employee3.LastName;

            //3b. compare and display the results of each overloaded operators comparison.
            Console.WriteLine(fullName1 + " == " + fullName2 + ": " + (employee1 == employee2));
            Console.WriteLine(fullName1 + " != " + fullName2 + ": " + (employee1 != employee2));
            Console.WriteLine(fullName1 + " == " + fullName3 + ": " + (employee1 == employee3));
            Console.WriteLine(fullName1 + " != " + fullName3 + ": " + (employee1 != employee3));
            Console.WriteLine(fullName2 + " == " + fullName3 + ": " + (employee2 == employee3));
            Console.WriteLine(fullName2 + " != " + fullName3 + ": " + (employee2 != employee3));
        }
    }
}
