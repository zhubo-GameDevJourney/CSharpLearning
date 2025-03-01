using System;

//假设我们有一个扑克牌游戏，现在创建一个4位关键字用来表示玩家手牌的牌型状态
//王牌 jokers 1000, 炸弹 bomb 0100 , 对子 0010, 连子0001；

//现在我们创建一个枚举enum来保存每一个位

[Flags]
enum CardDeckChecking : uint
{
    jokers = 0b1000,
    bomb = 0b0100,
    straight = 0b0010,
    pair = 0b0001
}

//现在创建一个类，以存放对是否有某种牌型的检测，以及检测方法，输出方法

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
        HaveJockers = op.HasFlag(CardDeckChecking.jokers); //检测是否有大小王
        HaveBomb = op.HasFlag(CardDeckChecking.bomb); //检测是否有炸弹
        HaveStraight = op.HasFlag(CardDeckChecking.straight); //检测是否有连子
        HavePair = op.HasFlag(CardDeckChecking.pair); //检测是否有对子

        //检测两种状态需要先创建一个新的关键字

        CardDeckChecking testFlag = CardDeckChecking.pair | CardDeckChecking.straight;
        HaveStaightAndPair = op.HasFlag(testFlag);
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