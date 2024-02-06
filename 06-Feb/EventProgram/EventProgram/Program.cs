using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProgram
{
    class Button
    {
        public event EventHandler click;
        public void OnClick()
        {
            click?.Invoke(this, EventArgs.Empty);
        }
    }
    internal class Program { 
        static void Main(string[] args)
        {
            Button button = new Button();
            button.click += (sender, e) => //lambda 
            {
                Console.WriteLine("Clicked");
                Console.ReadKey();
            };
            button.OnClick();
        }
    }
}
