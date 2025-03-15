using System;

interface IItf1 { void Print(string s); }
interface IItf2 { void Print(string t); }

class Class1 : IItf1, IItf2
{
    void IItf1.Print(string s) 
    { Console.WriteLine($"{s}"); }

    void IItf2.Print(string t)
    {
        Console.WriteLine($"{t}");
           }
}

class Program
{
    static void Main()
    {
        Class1 class1 = new();

        IItf1 itf1 = (IItf1)class1;
        IItf2 itf2 = (IItf2)class1;

        itf1.Print("itf1.print");
        itf2.Print("itf2.print");
    }
}
