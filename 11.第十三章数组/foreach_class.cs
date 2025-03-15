using System;

class Class1
{
    public int Item { set; get; } = 0;
}

class Program
{
    static void Main()
    {
        Class1[] classArray = new Class1[3];

        for ( int i = 0; i < 3; i++)
        {
            classArray[i] = new Class1();
            classArray[i].Item = i;

        }
        int j = 0;
        foreach(Class1 item in classArray)
        {

            item.Item += 10;
            Console.WriteLine($"classArray[{j}].Item = {item.Item}");
            j++;
        }
    }

}

