using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionD
{
    internal class Program
    {
        static void Message(string message)
    {
        Console.WriteLine(message);
    }
    
        static void Main(string[] args)
        {
            Action<string> Action = Message;
            Action("Hello");
            Console.ReadKey();
        }
    }
}
