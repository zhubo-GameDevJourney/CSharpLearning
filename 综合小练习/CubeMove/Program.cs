using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System;

namespace test
{
    internal class Program
    {
        static private int xPositon = 0;
        static private int yPosition = 0;

        static void Main()
        {

            Start();
            BuildCube(xPositon, yPosition);

            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;
                MoveCube(key);
            }
        }

        private static void Start()
        {
            Console.SetWindowSize(600, 400);
            Console.SetBufferSize(600, 400);


            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.CursorVisible = false;

        }

        private static void BuildCube(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("■");
        }

        private static void MoveCube(char key)
        {
            Console.SetCursorPosition(xPositon, yPosition);
            Console.Write(" ");

            switch (key)
            {
                case 'w':
                case 'W':
                    yPosition--;
                    break;
                case 's':
                case 'S':
                    yPosition++;
                    break;
                case 'a':
                case 'A':
                    xPositon -= 2;
                    break;
                case 'd':
                case 'D':
                    xPositon += 2;
                    break;
                default:
                    break;

            }

            var newPos = NumRangeCheck(xPositon, yPosition);
            xPositon = newPos.Item1;
            yPosition = newPos.Item2;

            BuildCube(xPositon, yPosition);

        }

        private static Tuple<int, int> NumRangeCheck(int x, int y)
        {
            x = Math.Clamp(x, 0, Console.BufferWidth - 2);
            x = x % 2 == 0 ? x : x - 1;

            y = Math.Clamp(y, 0, Console.BufferHeight - 1);

            return new Tuple<int, int>(x, y);


        }

    }

}

