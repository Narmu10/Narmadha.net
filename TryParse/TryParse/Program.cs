using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            bool l=int.TryParse("15",out i);
            Console.WriteLine(l);
            

            double d = 0;
            bool l1 = double.TryParse("89.345", out d);
            Console.WriteLine(l1);
            Console.ReadKey();


/*       cannot convert it  to string
            string s;
            bool l2=string.TryParse("Hello",out s);
            Console.WriteLine(l2);
            Console.ReadKey();*/
        }
    }
}
