using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateType
{
    internal class Program
    {
        public delegate void multinum(int a,int b);
        public delegate void addnum(int a,int b);

        public void num1(int a,int b)
        {
            Console.WriteLine("(20*2) = {0}",a*b);
            Console.ReadKey();
        }
        public void num2(int a, int b)
        {
            Console.WriteLine("(20+2) = {0}", a+b);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program obj=new Program();
            multinum del_obj1 = new multinum(obj.num1);
            addnum del_obj2 = new addnum(obj.num2);
            del_obj1(20, 2);
            del_obj2(20,2);

        }
    }
}
