using System;
using System.Reflection.Metadata;

namespace ConstvsReadonly1
{
     class Program
    {
        const int ctToMeters = 100;
        static readonly double y;

        static Program()
        {
            y = 3.4;
        }
        static void Main(string[] args)
        {
        }
    }
}
