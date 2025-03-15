using System;

class Class1
{
    public void method<S>(S[] s)
    {
        Array.Reverse(s);
        foreach(S item in s)
        {
            Console.Write($"{item.ToString()}, ");
        }
        Console.WriteLine();
    }

}

class Program
{
    static void Main()
    {
        var intArray = new int[] { 3, 5, 9, 2 };
        var stringArray = new string[] { "first", "second", "third" };
        var doubleArray = new double[] { 3.14, 2.71, 1.41, 1.61 };

        var class1 = new Class1();
        class1.method(intArray);
        class1.method(stringArray);
        class1.method(doubleArray);



    }
}
