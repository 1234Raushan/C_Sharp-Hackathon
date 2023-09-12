using System;

namespace NamedAndSimple
{

    public class Employee
    {
        public void AddEmployeeInfo(int EmpID, String Name, bool b, String Department="CSE")
        {
            Console.WriteLine("Added Employee Info");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.AddEmployeeInfo(EmpID:1,Name:"raushan",true,"IT");
            Console.WriteLine("Hello World!");
        }
    }
}
