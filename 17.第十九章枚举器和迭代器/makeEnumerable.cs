using System;
using System.Collections.Generic;


class Colors
{

    public IEnumerator<string> GetEnumerator()
    {
        IEnumerable<string> MyEnumerable = MakeColors(); //获取可枚举类型
        return MyEnumerable.GetEnumerator();  //可枚举类型调用GetEnumerator生成枚举器
    }

    public IEnumerable<string> MakeColors()
    {
        yield return "black";
        yield return "white";
        yield return "yellow";
        yield return "red";
    }
}

class Program
{
    static void Main()
    {
        Colors colors1 = new();

        foreach (string shade in colors1)
        {
            Console.WriteLine($"{shade}");
        }

        Console.WriteLine();

        foreach (string shade in colors1.MakeColors())
        {
            Console.WriteLine($"{shade}");
        }
    }
}