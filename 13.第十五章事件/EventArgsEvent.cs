using System;

//创建发布者类与订阅者类，在发布者类中创建一段计数代码，从1~100，每当计数一打（12）时，触发事件并将countDozen属性计数+1
//使用扩展EventArgs 计算每次数到一打时的计数

class PublishEventArgs : EventArgs
{
    public int CountNumbers { set; get; }
}

class Publisher
{
    public event EventHandler<PublishEventArgs> CountADozen;

    PublishEventArgs args = new();
    public void DoCount()
    {
        for(int i = 1; i <= 100; i++)
        {
            if (i % 12 == 0 && CountADozen != null)
            {
                args.CountNumbers = i;
                CountADozen(this, args);
            }
        }
    }
}

class Subscriber
{
    public int DozensCount { get; private set; }

    public Subscriber(Publisher publisher1)
    {
        DozensCount = 0;
        publisher1.CountADozen += PublisherCountDozen;
    }

    void PublisherCountDozen(object source, PublishEventArgs e)
    {
        
        DozensCount++;
        Console.WriteLine($"Now the DozensCount is {DozensCount} And count Number is {e.CountNumbers}");
    }

}

class Program
{
    static void Main()
    {

        Publisher publisher1 = new();
        Subscriber subscriber1 = new(publisher1);

        publisher1.DoCount();

        Console.WriteLine($"Count 1 - 100, there are {subscriber1.DozensCount} dozens; ");
    }
}
