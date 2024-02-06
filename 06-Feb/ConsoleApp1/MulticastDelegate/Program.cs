using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void SampleDelegate();
    internal class Program
    {
  
        static void Main(string[] args)
        {
            /*SampleDelegate del = new SampleDelegate(Samplemethod);
            del();*/
            /*SampleDelegate del1, del2, del3, del4;
            del1 =new SampleDelegate(SamplemethodOne);
            del2=new SampleDelegate(SamplemethodTwo);
            del3=new SampleDelegate(SamplemethodThree);
            del4 = del1 + del2 + del3 -del2;
            del4();*/ // multicast delegate
            SampleDelegate del = new SampleDelegate(SamplemethodOne);
            del += SamplemethodTwo;
            del += SamplemethodThree; // multicast delegate
            del();
            Console.ReadKey();
        }
        public static void SamplemethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SamplemethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SamplemethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
       
    }
} // can do with int.. if you r doing with int other than void... it takes only the lastly invoked method.
