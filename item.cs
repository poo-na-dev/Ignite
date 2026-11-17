using System;
using System.IO;

namespace item
{
    public static class Item
    {
        public int attack;
        public string name;    
        }

    }
    public class Itemstatus
    {
        item sword = new item();
        public void gg()
        {
            sword.name = "Sword";
            sword.attack = 1;
        }
    }

}