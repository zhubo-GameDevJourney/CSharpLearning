using System;

class AddNum
{
    public int TrueValue { get; set; }
    
    public static int operator -( AddNum x)
    {
        AddNum outcome = new AddNum();
        outcome.TrueValue = 0;
        return outcome.TrueValue;
    }

    public static AddNum operator +(AddNum x , AddNum y)
    {
        AddNum outcome = new AddNum();
        outcome.TrueValue = x.TrueValue + y.TrueValue;
        return outcome;
    }
}


class Program
{
    static void Main()
    {
        AddNum class1 = new AddNum();
        AddNum class2 = new AddNum();

        class1.TrueValue = 2;
        class2.TrueValue = 3;

        Console.WriteLine($"-class1 = {-class1}");
        Console.WriteLine($"The TrueValue of class + class2  = {(class1 + class2).TrueValue}");
    }
}
