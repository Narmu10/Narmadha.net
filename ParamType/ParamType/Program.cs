using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParamType
{
    internal class Program
    {
        public static int Sub(params int[] Numbers)
        {
            int total=0;
            foreach(int i in Numbers){
                total -= i;
            }
            return total;
        }

        public static int Add(params int[] Numbers)
        {
            int total=0;
            foreach(int j in Numbers)
            {
                total += j;
            }
            return total;
        }
        static void Main(string[] args)
        {
            int i = Sub(9, 7, 5, 3, 1);
            int j = Add(22, 44);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
