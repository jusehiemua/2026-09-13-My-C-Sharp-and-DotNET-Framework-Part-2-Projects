using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_7_PolymorphismAssignmentSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5a. The Employee object is instantiated and initialized with ID = a value, firstName “Sample” and lastName “Student”.
            Employee employee = new Employee() { ID = 1038, FirstName = "Sample", LastName = "Student" };
            //5b. Call the SayName() method on the object.
            employee.SayName();
            Console.WriteLine();
            Console.WriteLine();

            //Polymorphism in action:
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface:
            //IQuittable quittableEmployee = new Employee() { ID = 1038, FirstName = "Sample", LastName = "Student" };
            //OR:
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();
        }
    }
}
