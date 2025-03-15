using System;
using System.Runtime.CompilerServices;

delegate R Mydelegate<R, T>(T t);

class Class1
{
    public static string ReturnString(string s)
    {
        return s;
    }

    public static void PrintString(string s)
    {
        Console.WriteLine($"String is {s}");
    }
}

class Program
{
    static void Main()
    {
        Mydelegate<void, string> Del1 = new Mydelegate<void, string>(Class1.PrintString);
        Mydelegate<string, string> Del2 = new Mydelegate<string, string>(Class1.ReturnString);

        Del1("hello");
        Console.Write($"Del2 = {Del2("world")}");
    }
}