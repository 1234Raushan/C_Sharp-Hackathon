using System;

namespace ConstructorLab1
{
    public class Program
    {
        int n1;
        string n2;
        char n3;
        bool b;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p);
            Console.WriteLine(p.n2);
            Console.WriteLine(p.n3);
            Console.WriteLine(p.b);
            Console.WriteLine("Hello World!");
        }
    }
}
