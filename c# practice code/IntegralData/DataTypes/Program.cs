using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b= -15;
            Console.WriteLine("sbyte = "+b);
            Console.WriteLine("Min value =  "+ sbyte.MinValue+" " + "Max value = " + sbyte.MaxValue);
            Console.WriteLine("Type of variable= "+b.GetType());
            Console.ReadKey();

            byte a = 10;
            Console.WriteLine("Byte = " + a);
            Console.WriteLine("Min value =  " + Byte.MinValue + " " + "Max value = " + Byte.MaxValue);
            Console.WriteLine("Type of variable= " + a.GetType());
            Console.ReadKey();

            char c= 'a';
            Console.WriteLine("char = " + c + " "+ "size = "+sizeof(char));
            Console.WriteLine("Min value =  " + (int)(char.MinValue) + " " + "Max value = " +(int) (char.MaxValue));
            Console.WriteLine("Type of variable= " + c.GetType());
            Console.ReadKey();

            short s = -6765;
            Console.WriteLine("short = " + s + "size = " + sizeof(short));
            Console.WriteLine("Min value =  " + short.MinValue + " " + "Max value = " + short.MaxValue);
            Console.WriteLine("Type of variable= " + s.GetType());
            Console.ReadKey();

            uint d = 143290;
            Console.WriteLine("unit = " + d +" "+ "size = " + sizeof(uint));
            Console.WriteLine("Min value =  " + uint.MinValue + " " + "Max value = " + uint.MaxValue);
            Console.WriteLine("Type of variable= " + d.GetType());
            Console.ReadKey();

            long e = -987654321;
            Console.WriteLine("long = " + e + " "+"size = " + sizeof(long));
            Console.WriteLine("Min value =  " + long.MinValue + " " + "Max value = " + long.MaxValue);
            Console.WriteLine("Type of variable= " + e.GetType());
            Console.ReadKey();

            ulong f= 987654321;
            Console.WriteLine("ulong = " + f +" "+ "size = " + sizeof(ulong));
            Console.WriteLine("Min value =  " + ulong.MinValue + " " + "Max value = " + ulong.MaxValue);
            Console.WriteLine("Type of variable= " + f.GetType());
            Console.ReadKey();

        }
    }
}
