using System;


class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static explicit operator int(Person a)
    {
        return a.Age;
    }

    public static implicit operator Person(int age)
    {
        return new Person("Nemo", age);
    }

}

class Employee : Person
{
    public Employee(string name, int age) : base(name, age)
    {
    }
}

class Program
{
    static void Main()
    {
        Person tom = new("tom", 30);

        int age = (int)tom;
        Console.WriteLine($"Person Info : name : {tom.Name} Age : {age}");

        Person bill = 25;
        Console.WriteLine($"Person Info : name : {bill.Name} Age : {bill.Age}");

        Employee Bob = new Employee("Bob", 25);

        float fVar = (int)Bob;

    }
}




