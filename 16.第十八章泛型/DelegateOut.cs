using System;

class Animal { public int NumberOfLegs = 4; }
class Dog : Animal {  }


delegate T MyDelegate<out T>();

class Program
{
    static void Main()
    {
        MyDelegate<Dog> dogmaker = () => (Dog)(new Animal());
        MyDelegate<Animal> animalmaker = dogmaker;
    }
}
