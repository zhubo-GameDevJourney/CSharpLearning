using System;
using System.Collections.Generic;

class Colors
{
    string[] theColors = { "black", "white", "yellow", "red" };

    public IEnumerator<string> GetEnumerator()
    {
        return GetColors;
    }

    public IEnumerator<string> GetColors
    {
        get
        {
            foreach(string shade in theColors)
                yield return shade;
        }
    }


  }

class Program
{
    static void Main()
    {
        Colors colors1 = new();

        foreach (string shade in colors1)
        {
            Console.WriteLine($"{shade}");
        }
    }
}
