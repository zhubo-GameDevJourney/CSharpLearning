using System;


delegate double DelType1(int x, int y);

class Program
{
    static void Main()
    {
        DelType1 del1 = (x, y) => x + y;

        Console.WriteLine($"value = {del1(1, 2)}");
    }
}

