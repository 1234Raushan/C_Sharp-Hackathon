using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class AbsChild : Program
    {
        public override void Div(int x, int y)
        {
            Console.WriteLine(" Division: "+ x/y);
        }
        public override void Mul(int x, int y)
        {
            Console.WriteLine(" Multiplication: " + x / y);
        }
        static void Main(string[] args)
        {
          AbsChild child = new AbsChild();
            child.Add(1,2);
            child.Sub(1, 2);
            child.Mul(5, 2);    
            child.Div(10, 2);
        }
    }
}
