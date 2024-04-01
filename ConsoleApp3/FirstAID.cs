using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class ExtensionFirstAID
    {
        public static void FirstAID(this Hero hero)
        {
            hero.Hp += 30;
        }
    }
}
