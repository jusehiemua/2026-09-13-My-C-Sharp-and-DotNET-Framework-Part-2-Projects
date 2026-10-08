using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_7_PolymorphismAssignmentSubmission
{
    public class Employee : Person, IQuittable //3. The Employee class inherits the Person class and Interface IQuittable
    {
        //This Employee class has a property ID
        public int ID { get; set; }

        //4. The SayName() method is implemented inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Employee ID: " + ID);
            Console.WriteLine("==================");
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit.");

            //throw new NotImplementedException();
        }

    }
}
