using System;
using System.Threading.Tasks;

namespace ParallelForeach1
{
    class Program
    {
        static void Main()
        {
            string[] squares = new string[] { "we", "Hold", "These", "Truths", "to", "be" };

            Parallel.ForEach(squares, x => Console.WriteLine(x));
        }
    }
}