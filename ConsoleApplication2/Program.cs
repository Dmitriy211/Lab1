using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class student
    {
        public string firstname;
        public string lastname;
        public int age;
        public double gpa;
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();

            s.firstname = Console.ReadLine();
            s.lastname = Console.ReadLine();
            s.age = int.Parse(Console.ReadLine());
            s.gpa = int.Parse(Console.ReadLine());

            Console.WriteLine(s.firstname + ' ' + s.lastname + ' ' + s.age + ' ' + s.gpa);
        }
    }
}
