using ExtensionMethods;
using System;

namespace ExtensionMethods
{
    sealed class OriClass
    {
        int num1, num2, num3;
        public OriClass( int a , int b ,int c)
        {
            num1 = a;
            num2 = b;
            num3 = c;
        }

        public double Sum( )
        {
            return num1 + num2 + num3;
        }
    }

    static class extensionMethod   //声明一个静态类
    {
        public static double Average(this OriClass class1 )  // 扩展方法，必须是public static ， 第一个参数必须是 This 被扩展参数名 参数实例名
        {
            return (class1.Sum()) / 3.0;
        }
    }
}

class Program
{
static void Main()
    {
        OriClass class1 = new OriClass(3, 4, 5);  //创建实例class

        Console.WriteLine($"The sum is {class1.Sum()}");  
        Console.WriteLine($"The Average is {class1.Average()}");  //直接使用扩展方法

    }
}

