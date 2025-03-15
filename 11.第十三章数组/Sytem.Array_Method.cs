using System;

class Program
{
    public static void PrintArray(int[] a)
    {
        foreach(int var in a)
        {
            Console.Write($" {var} ");
        }

        Console.WriteLine("");
    }


    static void Main()
    {
        int[] arr = new int[] { 15, 20, 5, 6, 10 };
        PrintArray(arr);

        Array.Sort(arr);
        PrintArray(arr);

        Array.Reverse(arr);
        PrintArray(arr);

        Console.WriteLine("");
        Console.WriteLine($"Rank = {arr.Rank}   Length = {arr.Length}");
        Console.WriteLine($"GetLength(0) = {arr.GetLength(0)}");
        Console.WriteLine($"GetType() = {arr.GetType()}");
    }
}
