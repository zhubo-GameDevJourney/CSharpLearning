using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hi there.");
        Console.WriteLine($"{sb.ToString()}");

        sb.Replace("Hi", "Hello");
        Console.WriteLine($"{sb.ToString()}");
    }
}
