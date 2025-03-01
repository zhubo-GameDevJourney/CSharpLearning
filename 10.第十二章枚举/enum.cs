using System;

[Flags]
enum CardDeckSettings : uint
{
    SingleDeck = 0X01,
    LargePictures = 0X02,
    FancyNumbers = 0X04,
    Animation = 0X08
}

class Myclass
{
    bool UseSingleDeck = false,
         UseBigPics = false,
         UseFancyNumbers = false,
        USeAnimation = false,
        UseAnimationAndFancyNumbers = false;

    public void SetOptions( CardDeckSettings ops)
    {
        UseSingleDeck = ops.HasFlag(CardDeckSettings.SingleDeck);
        UseBigPics = ops.HasFlag(CardDeckSettings.LargePictures);
        UseFancyNumbers = ops.HasFlag(CardDeckSettings.FancyNumbers);
        USeAnimation = ops.HasFlag(CardDeckSettings.Animation);

        CardDeckSettings testFlags = CardDeckSettings.Animation | CardDeckSettings.FancyNumbers;
        UseAnimationAndFancyNumbers = ops.HasFlag(testFlags);
    }

    public void Print()
    {
        Console.WriteLine("Option settings:");
        Console.WriteLine($"Use Single Deck           -{UseSingleDeck}");
        Console.WriteLine($"Use Large Pictures           -{UseBigPics}");
        Console.WriteLine($"Use Fancy Numbers          -{UseFancyNumbers}");
        Console.WriteLine($"Show Animation         -{USeAnimation}");
        Console.WriteLine("Show Animation and FancyNumbers - {0}", UseAnimationAndFancyNumbers);

        
    }

}

class Program
{
    static void Main()
    {
        Myclass mc = new Myclass();
        CardDeckSettings ops = CardDeckSettings.SingleDeck | CardDeckSettings.FancyNumbers | CardDeckSettings.Animation;
        mc.SetOptions(ops);
        mc.Print();
    }
}

