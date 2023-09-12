using System;

namespace MethodOverloading
{
    public class Test
    {
        public void Add(int n1 , int n2) {
        Console.WriteLine("Add Result: " +n1+n2);
        }
        public void Add(String n3, int n4)
        {
            Console.WriteLine("Add Result: " + n3 +" "+ n4);
        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Add(1,2);
            test.Add("R",3);
            Console.WriteLine("Hello World!");
        }
    }
}
