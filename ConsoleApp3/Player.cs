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
        public Player(string Name):base(Name, startLvl, startHp) 
        {

        }
        private List<Item> items = new List<Item>();
        public void takeItem(params Item[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                items.Add(item[i]);
                base.Lvl += item[i].Lvl;
            }
        }
        public void dropItem(params string[] name)
        {
            for (int j = 0; j < name.Length; j++)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Name == name[j])
                    {
                        base.Lvl -= items[i].Lvl;
                        items.RemoveAt(i);
                    }
                }
            }
        }
        public void inventory()
        {
            Console.WriteLine("--------------------INVENTORY----------------");
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}");
                Console.WriteLine($"Lvl: {item.Lvl}");
            }
        }
    }
}
