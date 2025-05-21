using System;


class Program
{
    [Obsolete("Use method superPrintOut")]
    static void PrintOut(string str)
    {
        Console.WriteLine(str);
    }

    static void Main(string[] args)
    {
        PrintOut("Start of Main");
    }
}

