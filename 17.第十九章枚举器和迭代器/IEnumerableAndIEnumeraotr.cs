using System;
using System.Collections;
using System.Collections.Generic;

//有一个数组成员的类
class Spectrum : IEnumerable
{
   public string[] Colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };

    public IEnumerator GetEnumerator()
    {
        return new ColorEnumerator(Colors);
    }
}

//实现枚举器
class ColorEnumerator : IEnumerator
{
    string[] theColors;
    int indexNum = -1;

    public ColorEnumerator(string[] array)
    {
        theColors = new string[array.Length];
        int maxnum = array.Length - 1;
        for (int i = 0; i <= maxnum; i++)
            theColors[i] = array[i];
    }
   
    //实现Current属性
    public object Current
    {
        get
        {
            if (indexNum == -1)
                throw new InvalidOperationException();
            if (indexNum >= theColors.Length)
                throw new InvalidOperationException();

            return theColors[indexNum];
        }
    }
    //实现MoveNext方法
    public bool MoveNext()
    {

        if (indexNum < theColors.Length - 1)
        {
            indexNum++;
            return true;
        }
        else
            return false;
    }
    //实现Reset
    public void Reset()
    {
        indexNum = -1;
    }
    
}

class Program
{
    static void Main()
    {
        Spectrum spectrum = new();

        foreach(string item in spectrum)  //foreach需要的是带有数组和枚举器的类
        {
            Console.WriteLine(item);
        }
    }

}