using System;

[Flags]
enum CardDeckChecking : uint
{
    jokers = 0b1000,
    bomb = 0b0100,
    straight = 0b0010,
    pair = 0b0001
}

class Myclass
{
    //牌型检测结果初始化
    bool HaveJockers = false,
        HaveBomb = false,
        HaveStraight = false,
        HavePair = false,
        HaveStaightAndPair = false; //我们可以检测是否同时有对子和连子



    //牌型检测方法


            

    public void CardChecking(CardDeckChecking op)
    {

        //创建嵌套方法MyHasFlag
        bool MyHasFlag(CardDeckChecking op1)
        {
            return (op & op1) == op1;
        }
        HaveJockers = MyHasFlag(CardDeckChecking.jokers); //检测是否有大小王
        HaveBomb = MyHasFlag(CardDeckChecking.bomb); //检测是否有炸弹
        HaveStraight = MyHasFlag(CardDeckChecking.straight); //检测是否有连子
        HavePair = MyHasFlag(CardDeckChecking.pair); //检测是否有对子

        //检测两种状态需要先创建一个新的关键字

        CardDeckChecking testFlag = CardDeckChecking.pair | CardDeckChecking.straight;
        HaveStaightAndPair = MyHasFlag(testFlag);
    }

    //输出牌型方法

    public void Print()
    {
        Console.WriteLine($"The result are :");
        Console.WriteLine($"HaveBomb     --- {HaveBomb}");
        Console.WriteLine($"HaveJockers  --- {HaveJockers}");
        Console.WriteLine($"HaveStraight --- {HaveStraight}");
        Console.WriteLine($"HavePair     ---  {HavePair}");
        Console.WriteLine($"HaveStraightAndPair --- {HaveStaightAndPair}");
    }
}

class Program
{
    static void Main()
    {
        Myclass class1 = new Myclass(); //创建类实例

        
        CardDeckChecking op = CardDeckChecking.jokers | CardDeckChecking.bomb | CardDeckChecking.straight; //假设我们玩家的手牌中有王、炸弹、连子

        class1.CardChecking(op);
        class1.Print();



    }
}
