using System;

class Animal { };
class Dog : Animal { };

interface IAnimalContiner<out T>
{
    T GetAnimal();   
}

class DogContainer : IAnimalContiner<Dog>
{
    public Dog GetAnimal() => new Dog();
}
class Program
{
    static void Main()
    {

        IAnimalContiner<Dog> dog1 = new DogContainer();
        IAnimalContiner<Animal> animal1 = dog1;

       
    }
}
