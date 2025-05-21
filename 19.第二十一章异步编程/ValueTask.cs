using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ValueTask<int> value = DoAsyncStuff.CalculateSumAsync(3, 7);
        Console.WriteLine($"Value : {value.Result}");
        value = DoAsyncStuff.CalculateSumAsync(5, 6);
        Console.WriteLine($"Value: {value.Result}");
    }

    static class DoAsyncStuff
    {
        public static async ValueTask<int> CalculateSumAsync(int i1, int i2)
        {
            if (i1 == 0)
            {
                return i2;
            }
            int sum = await Task<int>.Run(() => GetSum(i1, i2));
            return sum;
        }
        private static int GetSum(int i1, int i2) { return i1 + i2; }
    }
}