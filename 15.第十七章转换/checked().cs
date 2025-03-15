using System;

class Class1
{
    int x = 5;
}
class Program
{
    static void Main()
    {
        int v = 10;
        Object o = null;

        o = v;

        o = 15;

        Console.WriteLine($"o : {o};\nv : {v};");
    }
}

