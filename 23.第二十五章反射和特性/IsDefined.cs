using System;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ReviewCommentAttribute : System.Attribute
{
    string Field1;
    string Version;

    public ReviewCommentAttribute(string field1, string version)
    {
        Field1 = field1;
        Version = version;
    }
}

[ReviewComment("Check it out", "2.4")]
class MyClass { }

class Program
{
static void Main()
    {
        MyClass mc = new MyClass();
        Type t = mc.GetType();
        bool isDefined =
            t.IsDefined(typeof(ReviewCommentAttribute), false);

        if (isDefined)
            Console.WriteLine($"ReviewComment is applied to type {t.Name}");
    }
}