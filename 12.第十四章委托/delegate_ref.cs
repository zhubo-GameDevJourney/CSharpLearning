using System;

delegate void Del(ref int x);

class Class1
{
    public void Add1(ref int x) { x += 2; }
    public void Add2(ref int x) { x += 3; }
 }
class Program
{
    
    static void Main()
    {
        Class1 class1 = new();
        
        Del Del1 = class1.Add1;
        Del1 += class1.Add2;
        Del1 += class1.Add1;
       
        int x = 5;
        Del1(ref x);
        Console.WriteLine($"Value : {x}");
    }
}
