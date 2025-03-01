using System;
using System.Net.Http.Headers;

class self_plus
{
   public int Num { get; set; }

    public static self_plus operator ++ ( self_plus x)
    {
        x.Num++;
        return x;

    }

}


class Program
{
    static void Show(string message,self_plus x)
    {
        Console.WriteLine($"{message} {x.Num}");
    }

    static void Main()
    {
        self_plus class1 = new self_plus();
        Show("Before  :", class1);
        Show("returned :", class1++);
        Show("After  :", class1);


         
    }
}
