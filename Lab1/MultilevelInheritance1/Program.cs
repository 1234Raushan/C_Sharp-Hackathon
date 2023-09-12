using System;

namespace MultilevelInheritance1
{

    public class Animal
    {
        public void eating() {
            Console.WriteLine("Too hungery");
        }
    }
    public class Dog : Animal { 
    
        public void barking()
        {
            Console.WriteLine("Too naughty");
        }
    }
    public class Dog2 : Dog {
    public void sleepy() { Console.WriteLine("Too Sleepy"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog2 dog = new Dog2();  
            dog.barking();
            dog.sleepy();
            dog.eating();
            Console.WriteLine("Hello World!");
        }
    }
}
