using System;

namespace MethodOverriding
{

    public class Animal
    {
        public virtual void eat() {
            Console.WriteLine("eating animal");
        }
    }
    public class Dog:Animal
    {
        public override void eat() {
            Console.WriteLine("eating dog");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
            Console.WriteLine("Hello World!");
        }
    }
}
