using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Player: Warrior
    {
        private static int startLvl = 5;
        private static int startHp = 100;
        public Inventory inventory;
        public Player(string Name):base(Name, startLvl, startHp) 
        {
            inventory = new Inventory(this);
        }
       
    }
}
