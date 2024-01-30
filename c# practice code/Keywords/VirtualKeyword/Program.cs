using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualKeyword;

namespace VirtualKeyword
{
    class Program
    {
        public virtual void show()
        {
            Console.WriteLine("Base");
            Console.ReadKey();
        }
    }
    class derived : Program
    {
        public override void show()
        {
            Console.WriteLine("Derived");
            Console.ReadKey();

        }
    }
    class Virtual
    {
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.show();
            obj = new derived();
            obj.show();



        }
    }
}



