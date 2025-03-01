using System;

enum Sample
{
    green,
    red,
    yellow
}

class Program
{
    static void Main()
    {
        Sample t1 = Sample.green;
        Sample t2 = Sample.red;
        Sample t3 = t2;

        Console.WriteLine($"t1 : {t1}");
        Console.WriteLine($"t2 : {t2}");
        Console.WriteLine($"t3 : {t3}");
    }
}
