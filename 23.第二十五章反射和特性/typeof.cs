using System;
using System.Reflection;

class BaseClass
{
    public int baseField;
}

class DerivedClass : BaseClass
{
    public int derivedClass;
}

class Program
{
    static void Main()
    {
        Type tbc = typeof(DerivedClass);
        Console.WriteLine($"Object type : {tbc.Name}");

        FieldInfo[] fi = tbc.GetFields();
        foreach (var f in fi)
            Console.WriteLine($"   Field : {f.Name}");
    }
}
