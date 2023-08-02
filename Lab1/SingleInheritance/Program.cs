using System;

namespace SingleInheritance
{
    public class Employee
    {
        public int salary = 40000;
    }
    public class Programmer:Employee
    {
        public int bonus = 4000;

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Programmer emp = new Programmer();
            Console.WriteLine("Salary of Employee is : "+emp.salary);
            Console.WriteLine(" Bonus of Programmer is : "+emp.bonus);
        }
    }
}
