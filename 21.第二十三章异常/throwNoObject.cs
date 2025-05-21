using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string s = null;
        MyClass.PrintArg(s);
        MyClass.PrintArg("Hi there!");

    }
}

class MyClass
{
    public static void PrintArg(string arg)
    {
        try
        {
            try
            {
                if (arg == null)
                {
                     
                    throw new ArgumentNullException("arg"); //这里由throw主动抛出异常
                }
                Console.WriteLine(arg);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Message : {e.Message}");
                throw;
            }
        }
        catch
        {
            Console.WriteLine("Outer Catch: Handling an Exception.");
        }
    }
}

