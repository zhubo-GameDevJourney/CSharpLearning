using System;

class Program
{
    static void Main()
    {
        int[,] Array1 = new int[2, 3]
        {
            {2,3,4 },
            {4,5,6 }
        };

        void Print(int[,] array)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Console.WriteLine($"Array1[{i}][{j}] = {Array1[i, j]}");

        }

        Print(Array1);
    }
}