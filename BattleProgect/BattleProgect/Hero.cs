using System;
using System.Collections.Generic;
using System.Text;

namespace BattleProgect
{
    class Hero
    {
        public String Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int BaseHurtLow { get; set; }
        public int BaseHurtHigh { get; set; }
        public int BaseDefenseLow { get; set; }
        public int BaseDefenseHigh { get; set; }
        public Hero(String name)
        {
            this.Name = name;
            this.HP = 1000;
            this.MP = 800;
            this.BaseHurtLow = 100;
            this.BaseHurtHigh = 300;
            this.BaseDefenseLow = 0;
            this.BaseDefenseHigh = 100;
        }
        public int Attack(Hero other)
        {
            Random random = new Random();
            int hurt = random.Next(BaseHurtLow, BaseHurtHigh);
            return hurt-other.Defence();
        }
        public int Defence()
        {
            Random random = new Random();
            return random.Next(BaseDefenseLow,BaseDefenseHigh);
        }
    }
}
