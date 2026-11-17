using System.IO;
using System;
using item;

namespace main
{
    class Maingame
    {
    
        static void Choosestarterweapon()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("-- Choose your weapon --");
            Console.WriteLine("1.Sword");
            Console.WriteLine("2.Shield");
            Console.WriteLine("3.Staff");
            Console.Write("What is your choie - ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case (1):
                {
                    Console.WriteLine("You picked up the "+ statusitem.sword.name + " and it has " + statusitem.sword.attack + " damage!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("-- IGNITE GAME --");
            Console.WriteLine("- 1.Enter to game");
            Console.WriteLine("- 2.Exit game");
            Console.Write("What is your choie - ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Choosestarterweapon();
            }
            

        }
    }
}