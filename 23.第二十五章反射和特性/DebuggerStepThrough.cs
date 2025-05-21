using System;
using System.Diagnostics;

class Program
{
    int x = 1;
    int X
    {
        get { return x; }
        [DebuggerStepThrough]  //不进入set访问器
        set
        {
            x = x * 2;
            x += value;
        }
    }
    public int Y { get; set; }
    public static void Main()
    {
        Program p = new Program();
        p.IncrementFields();
        p.X = 5;
        Console.WriteLine($"X = {p.X}, Y = {p.Y}");
    }

    [DebuggerStepThrough]
    void IncrementFields()
    {
        X++;Y++;
    }
}
