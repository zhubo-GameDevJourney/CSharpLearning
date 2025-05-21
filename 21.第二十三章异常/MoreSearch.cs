using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        MyClass class1 = new MyClass();
        try
        { class1.Method1(); }

        catch (DivideByZeroException)
        { Console.WriteLine("catch clause in Main()"); }
        finally
        { Console.WriteLine("finally clause in Main()"); }
        Console.WriteLine("After try statement in Main.");
        Console.WriteLine("          --  keep runnning.");
    }
}

class MyClass
{
public void Method1()
    {
        try
        {
            Method2();
        }
        catch (NullReferenceException)
        { Console.WriteLine("catch clause in Method1()"); }
        finally
        {
            Console.WriteLine("finally clause in Method1()");
        }
    }

    void Method2()
    {
        int x = 10, y = 0;
        try
        { x /= y; }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("catch clause in Method2()");
        }
        finally
        { Console.WriteLine("finally clause in Method2()"); }
    }
}

