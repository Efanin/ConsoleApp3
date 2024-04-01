using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Enemy: Warrior
    {
        private static int minLvl = 3;
        private static int maxLvl = 8;
        private static int minHp = 50;
        private static int maxHp = 100;
        public Enemy():base(setName(), setLvl(), setHp())
        {

        }
        private static string setName()
        {
            Random random = new Random();
            string[] choiceName = { "Orc", "Goblin", "Troll", "Gnom", "Dragon", "Witcher" };
            return choiceName[random.Next(choiceName.Length - 1)];
        }
        private static int setLvl()
        {
            Random random = new Random();
            return random.Next(minLvl, maxLvl);
        }
        private static int setHp()
        {
            Random random = new Random();
            return random.Next(minHp, maxHp);
        }
    }
}
