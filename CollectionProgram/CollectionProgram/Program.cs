using ImplementationProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProgram
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
            myList.Add(5);
            Console.WriteLine("Count: " + myList.Count);
            myList.push(10);
            Console.WriteLine("Count: " + myList.Count);
            myList.PrintList();
            myList.Remove(10);
            myList.DisplayList();
            myList.push(8);
            myList.DisplayList();
            /*
            myList.DeleteNode(8);*/
            Console.WriteLine("Count: " + myList.Count);
            Console.ReadLine();
        }
    }
}
