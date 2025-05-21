using System;
using System.Buffers;

namespace Range_Random_Attribute

{
    internal class Program

    {
        static void Main(string[] args)
        {

            int monsterDefense = 10;
            int monsterHealth = 20;

            bool runing = false;
            while (monsterHealth > 0 && !runing)
            {

                Console.WriteLine("按A发起攻击，按Q逃跑,按C清除战斗记录");
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'A':
                    case 'a':
                        Console.WriteLine("你选择了攻击！");
                        Attack();
                        break;
                    case 'Q':
                    case 'q':
                        runing = true;
                        Console.WriteLine("你选择了逃跑！");
                        return;
                    case 'C':
                    case 'c':
                        Console.Clear();
                        break;
                }

            }
            Console.WriteLine("怪物生命值为0");

            void Attack()
            {
                Random seed = new Random();

                int playerAttack = seed.Next(8, 13);
                Console.WriteLine($"你尝试发起攻击，攻击力为: {playerAttack}，怪物防御力为: {monsterDefense}， 生命值:  {monsterHealth}");
                if (playerAttack > monsterDefense)
                {
                    int damage = playerAttack - monsterDefense;
                    monsterHealth -= damage; // Update monster health
                    Console.WriteLine($"攻击成功，怪物受到{damage}点伤害！");
                    Console.WriteLine($"怪物剩余生命值: {monsterHealth}!");
                    Console.WriteLine("-------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"攻击失败，怪物防御力过高！");
                    Console.WriteLine("-------------------------------------------------");
                }
            }
        }
    }
}