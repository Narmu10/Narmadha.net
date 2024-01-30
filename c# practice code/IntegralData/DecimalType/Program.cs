using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num = 7654.321m;
            Console.WriteLine("decimal = " + num + " " + "size = " + sizeof(decimal));
            Console.WriteLine("Min value =  " + decimal.MinValue + " " + "Max value = " + decimal.MaxValue);
            Console.WriteLine("Type of variable= " + num.GetType());
            Console.ReadKey();

            float f = 12345.7896f;
            Console.WriteLine("Float = " + f + " " + "size = " + sizeof(float));
            Console.WriteLine("Min value =  " + float.MinValue + " " + "Max value = " + float.MaxValue);
            Console.WriteLine("Type of variable= " + f.GetType());
            Console.ReadKey();

            double d = 12345.6789;
            Console.WriteLine("double = " + d + " " + "size = " + sizeof(double));
            Console.WriteLine("Min value =  " + double.MinValue + " " + "Max value = " + double.MaxValue);
            Console.WriteLine("Type of variable= " + d.GetType());
            Console.ReadKey();

        }
    }
}
