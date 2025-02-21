using System;

class Employee
{
    public string LastName;
    public string FirstName;
    public string CityOfBirth;

    public string this[int index]
    {
        set
        {
            switch(index)
            {
                case 0:
                    LastName = value;
                    break;
                case 1:
                    FirstName = value;
                    break;
                case 2:
                    CityOfBirth = value;
                    break;

                default:
                    throw new ArgumentOutOfRangeException("index");

            }
        }

        get
        {
            switch (index)
            {
                case 0:
                    return LastName;
                case 1:
                    return FirstName;
                case 2:
                    return CityOfBirth;

                default:
                    throw new ArgumentOutOfRangeException("index");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee Tim = new Employee();
        Tim[0] = "Cook";
        Tim[1] = "Tim";
        Tim[2] = "NEW York";

        Console.WriteLine($"Our new employee is {Tim[0]} - {Tim[1]},and birth city is {Tim[2]}.");
    }
}
