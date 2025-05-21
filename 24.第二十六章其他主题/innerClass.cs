using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Myclass
{
    private class MyCounter
    {
        public int Count { get; private set; }

        public static MyCounter operator ++(MyCounter current)  //重载运算符++, 返回Count++的类
        {
            current.Count++;
            return current;
        }
    }

    private MyCounter counter;

    public Myclass()  //默认构造函数
    {
        counter = new MyCounter();
    }

    public int Incr() { return (counter++).Count; }  

    public int GetValue() { return counter.Count; }


}

class Program
{
    static void Main()
    {
        Myclass mc = new Myclass(); //通过构造函数声明了嵌套类Mycount对象counter；

        mc.Incr();mc.Incr();

        Console.WriteLine($"Total: {mc.GetValue()}");
    }
}

