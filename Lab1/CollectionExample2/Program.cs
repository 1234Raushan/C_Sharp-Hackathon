using System;
using System.Collections;

namespace CollectionExample2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",1010);
            ht.Add("Ename","Raushan");
            ht.Add("Job", "Manager");
            ht.Add("Salary",25000);
            ht.Add("Phone", 8825164575);

            Console.WriteLine(ht["Ename"]);

            foreach (object key in ht.Keys) {
                Console.WriteLine(key);
            }


        }
    }
}
