using System;
using System.Threading.Tasks;

namespace ExampleParallelFor
{
    class Program
    {
        static void Main()
        {
            Parallel.For( 0, 5, i  => Console.WriteLine($"The square of {i} is {i * i}"));
        }
    }
}
