using System;
using System.Reflection;

class BaseCalss
{
    public int BaseField = 0;
}

class DerivedClass : BaseCalss
{
    public int DerivedField = 0;
}

class Program
{
    static void Main()
    {
        var bc = new BaseCalss();
        var dc = new DerivedClass();

        BaseCalss[] bca = new BaseCalss[] { bc, dc };


        foreach(var v in bca)
        {
            Type t = v.GetType();
            Console.WriteLine($"Object type : {t.Name}");

            FieldInfo[] fi = t.GetFields();
            foreach(var f in fi)
            {
                Console.WriteLine($" Field : {f.Name}");
            }
            Console.WriteLine();
        }
    }
}

