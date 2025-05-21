using System;
using MyCrop.SuperLib;
class Program
{
static void Main()
    {
        MyCrop.SuperLib.SquareWidet sq = new MyCrop.SuperLib.SquareWidet();
        sq.SideLength = 2.0f;
        Console.WriteLine($"{sq.Area}");
    }
}