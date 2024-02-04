using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> mylist = new List<int>();
            for(int i = 5; i<10;i++)
            {
                mylist.Add(i * 2);

            }
            foreach(int j in mylist)
            {
              Console.WriteLine(j);
               
            }
            Console.ReadKey();*/

            List<string> list = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                list.Add(args[i]);
            }
            foreach (string s in list)
            {

            }

        }
    }
}
