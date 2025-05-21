using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool IsOdd(int x)
    {
        return x % 2 == 1;
    }
    static void Main()
    {
        int[] intArray = new int[] {3, 4, 5, 6, 7, 9};

        Func<int, bool> myDel = new Func<int, bool>(IsOdd);
        var countOdd = intArray.Count(myDel);
       
        Console.WriteLine(countOdd);
    }

}