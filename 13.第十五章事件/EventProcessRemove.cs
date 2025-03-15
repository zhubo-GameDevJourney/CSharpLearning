using System;


class Publisher
{
    public event EventHandler Event1;

    public void DoEvent()
    {
        Event1(this, null);
    }
}

class Subscriber
{
    public void Method1(Object source, EventArgs e)
    {
        Console.WriteLine($"Subscriber.Method1");
    }

    public void Method2(Object source, EventArgs e)
    {
        Console.WriteLine($"Subscriber.Method2");
    }

    }

class Program
{
    static void Main()
    {
        Publisher publisher1 = new();
        Subscriber subscriber1 = new();

        publisher1.Event1 += subscriber1.Method1;
        publisher1.Event1 += subscriber1.Method2;

        publisher1.DoEvent();

        publisher1.Event1 -= subscriber1.Method2;

        publisher1.DoEvent();

    }
}
