using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5_7_PolymorphismAssignmentSubmission
{
    public abstract class Person
    {
        //1. Create an abstract class called Person with two properties: string firstName and string lastName.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //2. Give it the method SayName(), which has to be abstract since instruction 4 says this method should be implemented in Class Employee.
        public abstract void SayName();

    }
}
