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
            int i=10;
            bool l=int.TryParse("15",out i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
