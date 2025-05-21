using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Dictionary<string, int> NameAge = new Dictionary<string,int>() {
            { "Bob", 23 },
            { "Alice", 25 },
            {"Sam", 32 }
        };
        NameAge.Add("Jim", 33);
        NameAge.Remove("Bob");

        NameAge["Alice"] = 35;

        foreach(string key in NameAge.Keys)
        {
            Console.WriteLine($"key = {key}");

        }
        Console.WriteLine();

        foreach(int value in NameAge.Values)
        {
            Console.WriteLine($"key = {value}");
        }

        Console.WriteLine($"If Contains Alice = {NameAge.ContainsKey("Alice")}");
    }
}