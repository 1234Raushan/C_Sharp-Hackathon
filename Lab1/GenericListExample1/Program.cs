using System;
using System.Collections.Generic;

namespace GenericListExample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            foreach (int i in list) {
                Console.Write(i +" ");
            }

            Console.WriteLine("\n"+"Using for loop : ");
            list.Insert(0, 1);
            list.Remove(0);
            for(int i  = 0; i < list.Count; i++)
            {
                Console.Write(list[i] +" ");
            }
            
        }
    }
}
