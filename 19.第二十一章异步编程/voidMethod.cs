﻿using System;
using System.Threading;
using System.Threading.Tasks;


class Program
{

    static void Main()
    {
        DoAsyncStuff.CalculateSumAsync(5, 6);

        Thread.Sleep(1000);
        Console.WriteLine("Program Exiting");
    }

    static class DoAsyncStuff
    {
        public static async void CalculateSumAsync(int i1, int i2)
        {
            int value = await Task.Run(() => GetSum(i1, i2));
            Console.WriteLine("Value: {0}", value);
        }
    }
    private static int GetSum(int i1, int i2) { return i1 + i2; }
}
