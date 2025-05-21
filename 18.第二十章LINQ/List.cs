using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{

    static void Main()
    {

        List<string> Names = ["Bob", "Sam", "Jay"];
                            //等效于new List<string> { "Bob", "Sam", "Jay" }; 

        foreach (var name in Names)
        {
            Console.WriteLine($"{name}");
        }

        Names.Remove("Bob");
        Names.Add("David");

        Console.WriteLine();

        for(int index = 0; index < Names.Count; index++ )

        {
            Console.WriteLine($"{Names[index]}");
        }

        Names.RemoveAt(0);
    }
}