using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace item
{
    public class Item
    {
        public int attack;
        public string name;  
        public Item(string name,int attack)
        {
            this.name = name;
            this.attack = attack;
        }  
        
    }
    public static class statusitem
    {
        public static Item sword = new Item("Sword",1); 
    }

}