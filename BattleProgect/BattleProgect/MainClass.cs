using System;

namespace BattleProgect
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("后羿");
            Hero hero2 = new Hero("项羽");
            Battle battle = new Battle();
            battle.Fight(hero1, hero2);
        }
    }
}
