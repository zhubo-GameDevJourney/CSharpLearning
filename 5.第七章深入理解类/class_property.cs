using System;

class D
    {
    private int _theRealValue = 5;  //后备字段

    public int TheRealValue
    {
        set
        {
            _theRealValue = value;
        }

        get
        {
            return _theRealValue;
        }
    }

    }

class Program
{
    static void Main()
    {
        D d1 = new D();
        Console.WriteLine("TheRealValue : {0}", d1.TheRealValue); //读取set返回值

        d1.TheRealValue = 10; //set隐式使用，给value设置值

        Console.WriteLine($"_theRealValue : {d1.TheRealValue}");  //隐式使用set，获取_theRealValue值


    }
}
