using System;

class Program
{
    public static ref int MaxNum(int[] a)
    {
        int maxIndex = 0;
        int maxNum = 0;

        for (int i = 0; i < a.GetLength(0); i++)
        {
            if (a[i] > maxNum )
            {
                maxIndex = i;
                maxNum = a[maxIndex];
            }
        }

        return ref a[maxIndex];
    }

     
    static void Main()
    {
        int[] array1 = { 2, 10, 3 };

        ref int theMaxNum = ref  MaxNum(array1);

        Console.WriteLine($"{array1[0]},{array1[1]},{array1[2]}.");

        theMaxNum = 5;


        Console.WriteLine($"{array1[0]},{array1[1]},{array1[2]}.");
        
    }
}
