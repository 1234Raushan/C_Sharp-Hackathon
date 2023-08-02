using System;

namespace SingleInheritance2
{

    public class Animal
    {
        public void eat() {
            Console.WriteLine("Eating");
        }
    }

    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
            dog.bark();
            Console.WriteLine("Hello World!");

        }
    }
}
