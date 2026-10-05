using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_MethodClassAssignmentSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            ExternalClass x1 = new ExternalClass();
            int a = 3;
            int b = 4;

            //3. Call the method in the class, passing in two numbers.
            x1.MixedOutputMethod(a, b);

            //4. Call the method in the class, specifying the parameters by name.

            //4. Call the method, specifying the parameters by name.
            x1.MixedOutputMethod(number1: 3, number2: 4);

        }
    }
}
