using System;

class aBaseClass
{
    public string baseMember = "baseMember";  //基类字段

    public void print(string name)  
    {
        Console.WriteLine($"The value is {name} ");  //基类打印字段的方法
    }
    public void Method1()
    {
        Console.WriteLine("aBaseClass -- Method1");   //基类方法
    }
}

class aDerivedClass : aBaseClass
{
    public string derivedMember = "derivedMember";   //派生类字段
    public void Method2()
    {
        Console.WriteLine("aDerivedClass -- Method2");  //派生类方法
    }
}

class Program
{
    static void Main()
    {
        aDerivedClass class1 = new aDerivedClass();
        class1.print(class1.baseMember);
        class1.print(class1.derivedMember);
        class1.Method1();
        class1.Method2();
        //如上可以看到，在派生类中即可使用基类的成员，也可以使用派生类的成员
    }
}
