using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_12_Final_CodeFirstStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                Student student = new Student();
                student.StudentName = "Bill";

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student saved: " + student.StudentName);
            }
        }
    }
}
