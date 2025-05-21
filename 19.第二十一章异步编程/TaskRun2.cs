using System;
using System.Threading.Tasks;

static class MyClass
{
    public static async Task DoWorkAsync()
    {
        await Task.Run(() => Console.WriteLine(5.ToString())); //Action

        Console.WriteLine((await Task.Run( () => 6)).ToString()); // TResult Func() 返回的是一个类型值

        await Task.Run(() => Task.Run(() => Console.WriteLine("7"))); //Task Func(),返回的是一个Task

        int value = await Task.Run(() => Task.Run(() => 8)); // Task<TResult> Func(),返回的是Task<TResult>

        Console.WriteLine(value.ToString());

    }

}

class Program
{
    static void Main()
    {
        Task t = MyClass.DoWorkAsync();
        t.Wait();
        Console.WriteLine("Press Any ke to exit");
        Console.Read();
    }
}
