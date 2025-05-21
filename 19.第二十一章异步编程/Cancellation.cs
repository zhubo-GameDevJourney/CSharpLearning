using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        Myclass myclass = new Myclass();
        Task t = myclass.RunAsync(token);

        Thread.Sleep(3000);
        cts.Cancel();

        t.Wait();

        Console.WriteLine($"Was Cancaleed: {token.IsCancellationRequested}");   


    }
}

class Myclass
{
    public async Task RunAsync(CancellationToken ct)
    {
        if (ct.IsCancellationRequested) return; 

        await Task.Run(()  => CycleMethod(ct), ct);
    }

    void CycleMethod(CancellationToken ct)
    {
        Console.WriteLine("Start CycleMethod");
        const int max = 5;
        for (int i = 1; i <= max; i++)
        {
            if(ct.IsCancellationRequested) return;

            Thread.Sleep(1000);

            Console.WriteLine($" {i} of {max} iterations completed");
        }
    }
}
