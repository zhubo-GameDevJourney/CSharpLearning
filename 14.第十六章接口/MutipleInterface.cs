using System;

interface IShowData { int GetData(); }
interface ISetData { void SetData(int x); }

class MyClass : IShowData, ISetData
{
    int Mem1;

    public int GetData()
    {
        return Mem1;
    }

    public void SetData(int x)
    {
        Mem1 = x;
    }

}

class Program
{
    static void Main()
    {
        MyClass class1 = new();
        class1.SetData(5);

        Console.WriteLine($"The value of Mem is {class1.GetData()}");
    }
}
