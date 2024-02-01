using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionComment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 30,sum =0,product=0;
            #region Parameter

             sum = num1 + num2;
             product = num1 * num2;

            #endregion

            #region Output
            Console.WriteLine(product);
            Console.WriteLine(sum);
            Console.ReadKey();


            #endregion


        }
    }
}
