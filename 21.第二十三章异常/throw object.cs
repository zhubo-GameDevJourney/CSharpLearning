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
        MyClass.PrintArg("Hi there!")
        
    }
}

class MyClass
{
    public static void PrintArg(string arg)
    {
        try
        {
            if(arg == null)
            {
                throw new ArgumentNullException("arg");
            }
            Console.WriteLine(arg);
        }
        catch(ArgumentNullException e)
        {
            Console.WriteLine($"Message : {e.Message}");
        }
    }
}
