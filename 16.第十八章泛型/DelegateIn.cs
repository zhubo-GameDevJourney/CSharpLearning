using System;

class Animal { public int NumberOfLegs = 4; }
class Dog : Animal { }


delegate void MyDelegate<in T>(T a);

class Program
{
    static void ActOnAnimal(Animal a)
    {
        Console.WriteLine(a.NumberOfLegs);
    }

    static void Main()
    {

        MyDelegate<Animal> act1 = ActOnAnimal;
        MyDelegate<Dog> dog1 = ActOnAnimal;
    }
}