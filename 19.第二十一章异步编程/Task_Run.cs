﻿using System;
using System.Threading.Tasks;

class Myclass
{
    public int Get10()
    {
        return 10;
    }

    public async Task DoWorkAsync()
    {
        Func<int> ten = new Func<int>(Get10);
        int a = await Task.Run(ten);

        int b = await Task.Run(new Func<int>(Get10));

        int c = await Task.Run(() => { return 10; });

        Console.WriteLine($"{a} {b} {c}");  
    }
}

class Program
{
    static void Main()
    {
        Task t =(new Myclass()).DoWorkAsync();
        t.Wait();
    }
}