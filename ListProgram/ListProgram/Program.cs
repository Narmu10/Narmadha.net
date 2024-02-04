using ImplementationProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                NarmadhaList<int> myList = new NarmadhaList<int>();

                myList.Add(1);
                myList.Add(2);
                myList.Add(3);
                myList.Add(4);
                Console.WriteLine("Count: " + myList.Count);
                myList.PrintList();
            /* myList.Remove(3);*/
            myList.push(10);
            myList.PrintList();
                Console.ReadKey();
            }
        }

    }
 
