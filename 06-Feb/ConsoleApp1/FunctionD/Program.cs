using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionD
{
    internal class Program
    {
        static int Add(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> addFunc = Add;
            int result = addFunc(5, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
