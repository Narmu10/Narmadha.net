using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            object boxv = n;
            Console.WriteLine(boxv); // boxing

            int unbox = (int)boxv;
            Console.WriteLine(unbox); //unboxing

            string s1 = "Hello";
            object boxv1= s1;
            Console.WriteLine(boxv1);

            string unbox1= (string)boxv1;
            Console.WriteLine(unbox1);
            Console.ReadKey();



        }
    }
}
