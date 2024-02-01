using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 40; 
            Multiplyref(num1,ref num2);
            Console.WriteLine("ref:" + num2);
            Console.ReadLine();
        }
        static void Multiplyref(int x,ref int y)
        {
            x *= y;
        }*/

        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 20;
            int result;
            MultiplyOut(num1,num2, out result);
            Console.WriteLine(result);  
            Console.ReadKey();
        }
        static void MultiplyOut(int num1, int num2, out int result)
        {
            result=num1*num2;
        }

    }
}
