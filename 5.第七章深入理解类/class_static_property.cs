using ConsoleTestApp;
using System;
using static ConsoleTestApp.Trivial;

namespace ConsoleTestApp
{
	class Trivial
	{
		public static int MyValue { set; get; }

		public void PrintValue()
		{
			Console.WriteLine("Value from inside: {0}", MyValue);
		}
	}
}
class program
{
	static void Main()
	{
		Console.WriteLine("Init Value: {0}", Trivial.MyValue); //从外部访问

		Trivial.MyValue = 10;
        
		Console.WriteLine("Init Value: {0}", Trivial.MyValue);

		MyValue = 20; //因为使用了using static可以直接使用名字访问

		Console.WriteLine($"New Value : {MyValue}");

		Trivial tr = new Trivial();

		tr.PrintValue();

    }
}