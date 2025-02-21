using System;

abstract class AbsClass
{
    public string Name = "Tom";

    abstract public void Print();

    public void Print1(string s)
    {
        Console.WriteLine($"absClass Name : {s};");
    }

}

class derivedClass1 : AbsClass
{
    public override void Print()
    {
        Console.WriteLine($"Override Method;");
    }
}

class Program
{
    static void Main()
    {
        derivedClass1 class1 = new derivedClass1();

        class1.Print();
        class1.Print1(class1.Name); 
    }

}
