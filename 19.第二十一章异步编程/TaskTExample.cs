using System;
using System.Numerics;
using System.Threading.Tasks;

class Program
{
    static class DoAsyncStuff
    {
        public static async Task<int> CalculateSumAsync(int i1, int i2)
        {
            int sum = await Task.Run(() => GetSum(i1, i2));
            return sum;
        }

        private static int GetSum(int i1, int i2) { return i1 + i2; }
    }

    static void Main()
    {
        Task<int> value = DoAsyncStuff.CalculateSumAsync(3, 7);

        Console.WriteLine($"value : {value.Result}");
    }
}
