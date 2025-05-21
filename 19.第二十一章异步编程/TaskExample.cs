using System;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Task someTask = DoAsyncStuff.CalculateSumAsync(5, 6);

        someTask.Wait();
        Console.WriteLine("Async stuff is done");
    }

    static class DoAsyncStuff
    {
        public static async Task CalculateSumAsync(int i1, int i2)
        {
            int value = await Task.Run(() => GetSum(i1, i2));
            Console.WriteLine("Value : {0}", value);
        }
        private static int GetSum(int i1 ,int i2) { return i1 + i2; }
    }
}
