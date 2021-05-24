using System;
using System.Collections.Generic;
using System.Text;

namespace BattleProgect
{
    class Battle
    {
        public void Fight(Hero hero01,Hero hero02)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*******************战斗开始********************");
            Console.WriteLine("***************************************");
            int count = 1;
            while (true) {
                if (hero01.HP>0&&hero02.HP>0) {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("这是第{0}回合", count);
                    count++;
                    Console.WriteLine("{0}向{1}发动攻击", hero01.Name, hero02.Name);
                    int hurt1to2 = hero01.Attack(hero02);
                    hero02.HP -= hurt1to2;
                    Console.WriteLine("此次攻击造成{0}点伤害，{1}还剩{2}点血量", hurt1to2, hero02.Name, hero02.HP);
                    if (hero02.HP > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("{0}发动反攻", hero02.Name);
                        int hurt2to1 = hero02.Attack(hero01);
                        hero01.HP -= hurt2to1;
                        Console.WriteLine("此次攻击造成{0}点伤害，{1}还剩{2}点血量", hurt2to1, hero01.Name, hero01.HP);
                    }
                    else
                    {
                        Console.WriteLine("{0}已死",hero02.Name);
                        break;
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("{0}已死", hero01.Name);
                    break;
                }
            }
        }
    }
}
