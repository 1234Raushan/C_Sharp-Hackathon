using System;

namespace EvenOdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer");
            int n = int.Parse(Console.ReadLine());
            if(n%2== 0 & n!=0)
            {
                Console.WriteLine("Entered number is even");
                Console.Read();
            }
            else if (n==0)
            {
                Console.WriteLine("Entered number is zero");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
                Console.Read();
            }

        }
    }

}
