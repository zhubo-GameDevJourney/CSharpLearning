using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("运行主线程:...");
        DoAsyncWork();
        Console.WriteLine("继续运行主线程:...");

        Console.ReadLine();

    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine("异步任务开始..");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                await Task.Yield();
            }

            Console.WriteLine($"   {i} of 5 Steps in Main Program.");
            Thread.Sleep(1000);

        }
        
    }

}
