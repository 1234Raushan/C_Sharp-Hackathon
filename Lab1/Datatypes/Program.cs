using System;

namespace Datatypes
{
    public class Program
    {
        static void Main(string[] args)
        {
          Test t1 = new Test();
            Console.WriteLine(t1.a + " is a integer value");
            Console.WriteLine(t1.b + " is a String");
            Console.WriteLine(t1.c + " is Char Value");
            Console.WriteLine(t1.d + " is boolean values");

        }
    }

    public class Test
    {
       public int a = 10;
       public string b = "Raushan";
       public char c = 'a';
       public bool d = false;

    }
}
