using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{

    class AccountManager
    {
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }

        public void Total(int amount)
        { 
            Balance += amount;
            Console.WriteLine(Balance);
            if (Balance <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }
            if (Balance <= 1000)
            {
                Console.WriteLine("Maintain sufficient balance");
            }
            else
            {
                Console.WriteLine("Sufficient balance");
            }
            Console.ReadKey();
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            AccountManager account = new AccountManager
            {
                AccountHolderName = "Narmadha",
                BankName = "hdfc",
                Balance = 1000
            };
            account.Total(500);
            
        }
    }
}
