using System;

interface IMyIf1
{
    void Print(string s);
}

class Class1 : IMyIf1
{
    public string Name = "Bob";

    public void Print(string s)
    {
        Console.WriteLine($"The string is {s}");
    }
}

class Program
{
    static void Main()
    {
        Class1 class1 = new();
        class1.Print(class1.Name);
    }
}
