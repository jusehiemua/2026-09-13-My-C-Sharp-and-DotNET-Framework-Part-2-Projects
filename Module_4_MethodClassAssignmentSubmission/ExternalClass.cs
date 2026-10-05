using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_MethodClassAssignmentSubmission
{
    internal class ExternalClass
    {
        //1. Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen. 
        public void MixedOutputMethod(int number1,int number2) {
            Console.WriteLine("The square of the 1st parameter " + number1 + " = " + Math.Pow(number1, 2));
            Console.WriteLine("The 2nd parameter = " + number2);
        }
    }
}
