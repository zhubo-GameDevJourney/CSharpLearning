using System;
using System.Collections.Generic;


class Colors
{
    string[] theColors = { "yellow", "blue", "red", "white" };

    public IEnumerable<string> MakeColors1()
    {
    
        for(int i =0; i < theColors.Length; i++)
        {
            yield return theColors[i];
        }
    }

    public IEnumerable<string> MakeColors2()
    {
        for(int i = theColors.Length - 1; i >=0; i--)
        {
            yield return theColors[i];
        }
    }
}

class Program
{
    static void Main()
    {
        Colors colors1 = new();
        Colors colors2 = new();

        foreach (string shade in colors1.MakeColors1())
        {
            Console.WriteLine($"{shade}");
        }

        foreach (string shade in colors1.MakeColors2())
        {
            Console.WriteLine($"{shade}");
        }
    }
}
