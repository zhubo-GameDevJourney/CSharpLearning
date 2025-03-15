using System;

delegate void Del();

class Class1
{
    public void Print1() { Console.WriteLine("Print Print1"); }
    public void Print2() { Console.WriteLine("Print Print2"); }
}

class Program
{
    static void Main()
    {
        Del Del1 = delegate { Console.WriteLine("Print anonymous method"); };

        Class1 class1 = new();

        Del1 += class1.Print1;
        Del1 += class1.Print2;

        Del1();
    }
}
