using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Tasks;

namespace Timers
{
    class Program
    {
        int TimesCalled = 0;
        void Display(object state)
        {
            Console.WriteLine($"{(string)state} {++TimesCalled}");
        }

        static void Main()
        {
            Program p = new Program();
            TimerCallback timerCallback = new TimerCallback(p.Display);
            Timer myTimer = new Timer(timerCallback, "Processing timer event", 2000, 1000);

            Console.WriteLine("Timer Started.");

            Console.ReadLine();
        }
    }
}