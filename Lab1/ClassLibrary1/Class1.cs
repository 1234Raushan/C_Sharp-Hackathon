using System;

namespace ClassLibrary1
{
    public class Program
    {
        public void Test1()
        {

            Console.WriteLine("Public method");
        }
        private void Test2()
        {

            Console.WriteLine("private method");
        }
        protected void Test3()
        {

            Console.WriteLine("protected method");
        }
        internal void Test4()
        {

            Console.WriteLine("internal method");
        }
        protected internal void Test5()
        {

            Console.WriteLine("protected internal method");
        }
        //static void Main(string[] args)
        //{

        //    Program program = new Program();
        //    program.Test1();
        //    program.Test2();
        //    program.Test3();
        //    program.Test4();
        //    program.Test5();
        //    Console.ReadLine();
        //}
    }

    }
