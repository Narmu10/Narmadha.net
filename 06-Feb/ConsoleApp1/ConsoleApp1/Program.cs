using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate void HellofromFunction(string Message);

        static void Main(string[] args)
        {
            HellofromFunction del = new HellofromFunction(Hello);
            /*Console.WriteLine(del);*/
            del("Hello from Function");
            Console.ReadKey();
        }
        public static void Hello(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
