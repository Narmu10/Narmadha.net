using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        static async Task Main (string[] args)
        {
            Console.WriteLine("Moving to office");
            await BusArrives();
            Console.WriteLine("Step into office");
            Console.WriteLine("Meeting");
            await MOM();
            Console.ReadLine();


        }
        static async Task BusArrives()
        {
            await Task.Delay(5000);
        }
        static async Task MOM()
        {
            await Task.Delay (1000);
        }
    }
}
