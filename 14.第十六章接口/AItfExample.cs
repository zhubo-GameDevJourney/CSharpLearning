using System;

class Animal
{}

interface ILiveBirth
{
    string BabyCalled();
}

class Cat : Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
        return "Kitten";
    }

}

class Dog : Animal, ILiveBirth
{
    string ILiveBirth.BabyCalled()
    {
           return "puppy";
    }
}

class Bird : Animal
{ }

class Program
{
    static void Main()
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Cat();
        animals[1] = new Dog();
        animals[2] = new Bird();

        foreach(Animal a in animals)
        {
            ILiveBirth liveBirth = a as ILiveBirth;

            if (liveBirth != null)
                Console.WriteLine($"The Baby is called : {liveBirth.BabyCalled()}");
        }

    }
}
