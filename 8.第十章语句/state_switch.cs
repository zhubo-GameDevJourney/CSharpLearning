using System;

class Animal
{
    public string Amtype { set; get; }  //属性后面不需要()

}

class Program
{
    static void Main()
    {
        Animal animal = new Animal();
        animal.Amtype = "dog";

        switch(animal)
        {
            case Animal a when a.Amtype == "dog":  //when case,要使用一个新的实例，该实例不用声明
                Console.WriteLine("Animal is dog.");
                break;   //case 语句末尾要使用跳转语句

            case Animal a when a.Amtype == "cat":
                Console.WriteLine("Animal is cat");
                break;

            default:
                Console.WriteLine("Something wrong.");
                break;

        }

    }
}
