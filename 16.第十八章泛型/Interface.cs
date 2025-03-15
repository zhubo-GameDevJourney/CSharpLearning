using System;

interface IMyIfc<S>
{
    S Print(S s);
}

class Class1 : IMyIfc<int>, IMyIfc<string>
{
    public int Print(int num)
    {
        return num;
    }
    public string Print(string s)
    {
        return s;
    }
}

class Program
{
   static void Main()
    {
        Class1 class1 = new();

        Console.WriteLine($"{class1.Print(4)}");
        Console.WriteLine($"{class1.Print("world")}");
    }
}