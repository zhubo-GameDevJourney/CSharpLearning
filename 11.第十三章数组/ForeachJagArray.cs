using System;

using System;

class Program
{
    static void Main()
    {
        //声明并初始化
        int[][][] jugArray2 = new int[3][][];

        jugArray2[0] = new int[2][];
        jugArray2[0][0] = new int[]{ 2, 3 };
        jugArray2[0][1] = new int[]{ 4, 5, 6 };

        jugArray2[1] = new int[3][];
        jugArray2[1][0] = new int[]{ 4, 5, 7, 9 };
        jugArray2[1][1] = new int[]{ 3, 6, 0 };
        jugArray2[1][2] = new int[]{ 8, 0, 2 };

        jugArray2[2] = new int[2][];
        jugArray2[2][0] = new int[]{ 1, 6, 9 };
        jugArray2[2][1] = new int[]{ 0, 2, 6 , 2};


        //遍历打印元素

       foreach(int[][] item1 in jugArray2)
            foreach (int[] item2 in item1)
            {
                Console.Write($" {{ ");

                foreach (int item3 in item2)
                {


                    Console.Write($"{item3}, ");

                }
                Console.WriteLine("};");
            }
    }
}

