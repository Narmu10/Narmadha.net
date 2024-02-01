using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseProgram
{// to convert string to other datatypes like int, double, datetime .
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "65432";
            int num= int.Parse(str1);
            Console.WriteLine(num);

            string str2 = "89765";
            int num2 = int.Parse(str2);
            Console.WriteLine(num2);

            string str3 = " 98.760";
            double num3= double.Parse(str3);
            Console.WriteLine(num3);
            Console.ReadKey();
        }
    }
}
