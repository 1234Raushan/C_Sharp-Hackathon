using System;

namespace Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            test t1 = new test();
            t1.d1 = 1;
            t1.b = true;
            t1.c = 'R';
            t1.f = 1.2f;
            Console.WriteLine(t1.d1 +" "+ t1.f +" "+ t1.c);
        }
    }
    public class test
    {
        public double d1;
        public float f ;
        public decimal d;
        public Boolean b;
        public int i;
        public char c;
        public byte[] a;
        public short s;
        public long l;

        public Nullable<int> n;
    }
}
