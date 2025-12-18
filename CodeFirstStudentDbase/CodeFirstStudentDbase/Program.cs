using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDbase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                Console.WriteLine("Enter Student Full Name: ");
                string name = Console.ReadLine();
                var student = new Student() { StudentName = name };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("\nStudent Successfully Added...\nPress enter to exit.");
            Console.ReadKey();
        }
    }
}
