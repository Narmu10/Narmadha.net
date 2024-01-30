using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic
            int a = 10, b = 20, res;
            res = a + b;
            Console.WriteLine("Add = "+
                res);
            Console.ReadKey();
            res = b - a;
            Console.WriteLine("Sub = "+res);
            Console.ReadKey();
            res = a * b;
            Console.WriteLine("Multi = "+res);
            Console.ReadKey();
            res = b / a;
            Console.WriteLine("Div = "+res);
            Console.ReadKey();


            // Realtional
            bool result;
             result = a == b;
            Console.WriteLine("Equal "+result);
            Console.ReadKey();
            result = (b >= a);
            Console.WriteLine("Greater or equal to"+result);
            Console.ReadKey();
            result = (a != b);
            Console.WriteLine("not equal to "+result);
            Console.ReadKey();

            //Logical

            bool x= true, y= false, result1;
            result1 = x && y;
            Console.WriteLine("AND Operator: " + result1);
            Console.ReadKey();
            result1 = x || y;
            Console.WriteLine("OR Operator: " + result1);
            Console.ReadKey();
            result1 = !x;
            Console.WriteLine("NOT Operator: " + result1);
            Console.ReadKey();

            //Bitwise

            res = a & b;
            Console.WriteLine("Bitwise AND: " + res);
            Console.ReadKey();
            res = a | b;
            Console.WriteLine("Bitwise OR: " + res);
            Console.ReadKey();
            res = a ^ b;
            Console.WriteLine("Bitwise XOR: " + res);
            Console.ReadKey();
            res = ~a;
            Console.WriteLine("Bitwise Complement: " + res);
            Console.ReadKey();
            res = a << 2;
            Console.WriteLine("Bitwise Left Shift: " + res);
            Console.ReadKey();
            res = a >> 2;
            Console.WriteLine("Bitwise Right Shift: " + res);
            Console.ReadKey();

            //Assignment 

            int g= 15;
            g += 10;
            Console.WriteLine("Add Assignment: " + g);
            Console.ReadKey();
            g -= 5;
            Console.WriteLine("Subtract Assignment: " + g);
            Console.ReadKey();
            g *= 5;
            Console.WriteLine("Multiply Assignment: " + g);
            Console.ReadKey();
            g /= 5;
            Console.WriteLine("Division Assignment: " + g);
            Console.ReadKey();
            g %= 5;
            Console.WriteLine("Modulo Assignment : " + g);
            Console.ReadKey();

        }
    }
}
