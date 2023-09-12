using System;

namespace NamedParameterDemo2
{
    public class Employee
    {
        public void AddEmployeeInfo(int EmpID, string Name, bool b, String Department)
        {
            Console.WriteLine("information Added");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.AddEmployeeInfo(Name:"Raushan", EmpID:1, b:true,Department:"IT");
            Console.WriteLine("Hello World!");
        }
    }
}
