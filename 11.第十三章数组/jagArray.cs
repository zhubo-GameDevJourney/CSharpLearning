using System;

class Program
{
    static void Main()
    {
        //声明并初始化
        int[][][] jagArray1 = new int[2][][];

        jagArray1[0] = new int[2][];
        jagArray1[0][0] = new int[]{ 1, 2, 3};
        jagArray1[0][1] = new int[]{ 2, 3};

        jagArray1[1] = new int[3][];
        jagArray1[1][0] = new int[]{ 3, 4, 5};
        jagArray1[1][1] = new int[]{ 2, 4};
        jagArray1[1][2] = new int[]{ 2, 4, 6, 8};

        //遍历打印元素

        for(int i = 0; i < jagArray1.Length; i++)
            for(int j = 0; j < jagArray1[i].Length; j++)
            { 
                Console.Write($"jagArray1[{i}][{j}] = {{ ");
               
                for( int k = 0; k < jagArray1[i][j].Length; k++)
                {
                    

                Console.Write($"{jagArray1[i][j][k]},");
                    
                }
                Console.WriteLine("};");
            }
    }
}
