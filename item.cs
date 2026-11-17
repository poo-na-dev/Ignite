using System;
using System.IO;
using iteme;

public namespace iteme
{
    public class item
    {
        public int attack;
        public string name;    
        }

    }
    public class itemstatus
    {
        item sword = new item();
        public void gg()
        {
            sword.name = "Sword";
            sword.attack = 1;
        }
    }

}