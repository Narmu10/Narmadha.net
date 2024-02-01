using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        { // implicit type
            /*int n = 30;
            double d= n; // conversion of int to double
            Console.WriteLine(d);
            float f = n; // int to float
            Console.WriteLine(f);
            long l = 4567893;
            float f2 = l; // long to float
            Console.WriteLine(f2);
            Console.ReadKey();*/

            //explicit type 

            double d = 10.5;
            int n = (int)d;
            float fl = 3.14f;
            double d2 = (double)fl;
            Console.WriteLine(d2);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
