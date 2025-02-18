using System;

class Class1
{
    int id;
    string Name;

    public Class1() { id = 10; Name = "Bob"; } //构造函数0
    public Class1(int val) { id = val; Name = "Bob"; } //构造函数1
    public Class1(string name) { Name = name; } //构造函数2

    public void SoundOff()
    {
        Console.WriteLine($"Name : {Name}, id : {id}");
    }

}

class Program
{
    static void Main()
    {
        Class1 a = new Class1();  //使用构造函数0初始化
        Class1 b = new Class1(25);  //使用构造函数1初始化
        Class1 c = new Class1("Peter");  //使用构造函数2初始化

        a.SoundOff();  
        b.SoundOff();
        c.SoundOff();
    }
}