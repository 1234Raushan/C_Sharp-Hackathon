using System;

namespace NamedParameter
{

    public class Employee
    {
        public void AddEmployeeInfo(int EmpID, String Name, bool b, String Department) {

            Console.WriteLine("Employee info added");
        }   
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.AddEmployeeInfo(1,"Raushan",true,"IT");
            Console.ReadKey();
        }
    }
}
