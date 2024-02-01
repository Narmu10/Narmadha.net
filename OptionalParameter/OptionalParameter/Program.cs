using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            PrintMessage("Hello"); 
        }
        public static void PrintMessage(String message = "world") //default
        {
            Console.WriteLine(message); 
            Console.ReadKey();
        }
    }
    }

