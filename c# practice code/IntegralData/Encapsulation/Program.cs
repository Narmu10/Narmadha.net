using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Things{
            /*book, Pencil, paper*/
            Book=10,Pencil,Paper
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Book:"+(int)(Things.Book));
            Console.WriteLine("Pencil:{0}",(int)(Things.Pencil));
            Console.WriteLine("Paper:{0}",(int)(Things.Paper));
            Console.ReadLine();
        }
    }
}
