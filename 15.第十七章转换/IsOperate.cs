using System;

class Employee : Person { }

class Person
{
    public string Name = "someone";
    public int Age;

}

class Program
{
    static void Main()
    {
        Employee bill = new Employee() { Name = "bill", Age = 25};

        if(bill is Person)
        {
            Person p = bill;
            Console.WriteLine($"Person Info : {p.Name}, {p.Age}");
        }


    }
}
