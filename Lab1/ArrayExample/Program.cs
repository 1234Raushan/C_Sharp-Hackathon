using System;
using System.Collections;
namespace ArrayExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList(5);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(100);
            arrayList.Add(200);
            arrayList.Add(300);
            arrayList.Add(400);
            arrayList.Add(500);
            arrayList.Add(600);
            Console.WriteLine(arrayList.Capacity);

            foreach (Object obj in arrayList) { 
            
                Console.Write(obj + " ");
            }
            arrayList.Insert(3, 350);
            arrayList.Remove(200);
            Console.WriteLine("");
            
            foreach (Object obj in arrayList)
            {

                Console.Write(obj + " ");
            }
            Console.ReadKey();


        }
    }
}
