using System;
using System.Collections.Generic;

class Colors
{
    public IEnumerator<string> GetEnumerator()
    {
        return MakeColors();
    }

    public IEnumerator<string> MakeColors()
    {
        yield return "black";
        yield return "white";
        yield return "yellow";
        yield return "red";
    }
}

class Program
{
    static void Main()
    {
        Colors colors1 = new();

        foreach(string shade in colors1)
        {
            Console.WriteLine($"{shade}");
        }

    }
}
