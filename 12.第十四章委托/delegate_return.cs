using System;


delegate int Del();

class Class1
{
    public int Number = 5;
    public int Print1()
    {
        Number += 2;
        return Number;
    }

    public int Print2()
    {
        Number += 3;
        return Number;
    }
}

class Program
{
    
    static void Main()
    {
        Class1 class1 = new();

        Del Del1 = class1.Print1;
        Del1 += class1.Print2;
        Del1 += class1.Print1;

        Console.WriteLine($"Value : {Del1()}");
    }
}
