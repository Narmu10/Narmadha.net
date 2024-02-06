using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictionD
{
    public delegate bool IsTeen(int age);
    internal class Program
    {
        static bool CheckTeen(int age)
        {
            return age >= 13 && age <= 19;
        }
        static void Main(string[] args)
        {
            IsTeen isTeen = CheckTeen;
            int age = 30;
            bool result = isTeen(age);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
