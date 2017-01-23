using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class student
    {
        public string firstname;
        public string lastname;
        public int age;
        public double gpa;

        public student()
        {
            firstname = "Dmitriy";
            lastname = "Tuchashvili";
            age = 18;
            gpa = 4;
        }

        public override string ToString()
        {
            return firstname + ' ' + lastname + ' ' + age + ' ' + gpa;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();

            Console.WriteLine("Do you want to add a new student?");
            string a = Console.ReadLine();

            if (a == "yes" || a=="Yes" || a=="+" || a=="y")
            {
                Console.WriteLine("\nName:");
                s.firstname = Console.ReadLine();
                Console.WriteLine("\nSurname:");
                s.lastname = Console.ReadLine();
                Console.WriteLine("\nAge:");
                s.age = int.Parse(Console.ReadLine());
                Console.WriteLine("\nGPA:");
                s.gpa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n"+s.ToString());
        }
    }
}
