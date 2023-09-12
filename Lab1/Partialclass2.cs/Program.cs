using System;

namespace Partialclass2.cs
{
    public partial class Employee
    {
        public void Display() {
          Console.WriteLine("class2 landed");

        }
        public void EmployeeDetails() { 

           Console.WriteLine();
        }

    }

    public class program
    {
        static void main(string[] args) { 
        Employee emp = new Employee();
            emp.EmployeeDetails();
            emp.Display();
        }
    }
}
