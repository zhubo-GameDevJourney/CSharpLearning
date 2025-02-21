using System;

class baseClass
{
    private int _myInt = 5;
    virtual public int MyInt
    {
        get { return _myInt; }
    }
}

class derivedClass : baseClass
{
    private int _myInt = 10;
    override public int MyInt
    {
        get { return _myInt; }
    }
}

class Program
{
    static void Main()
    {

        derivedClass derived = new derivedClass();
        baseClass mybc = (baseClass)derived;

        Console.WriteLine(derived.MyInt);
        Console.WriteLine(mybc.MyInt);
    }
}
