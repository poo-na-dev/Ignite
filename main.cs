using System.IO;
using System;
using System.Text;
using item;

namespace main
{
    class Maingame
    {
    
        static void Choosestarterweapon()
        {
            Console.WriteLine("______________________________\n");
            Console.WriteLine("-- Choose your weapon --\n");
            Console.WriteLine("1.Sword");
            Console.WriteLine("2.Shield");
            Console.WriteLine("3.Staff\n");
            Console.Write("What is your choie - ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case (1):
                {
                    
                    Console.WriteLine("You picked up the "+ Statusitem.sword.name + " and it has " + Statusitem.sword.attack + " damage!");
                    break;
                }
                case (2):
                {
                    
                    Console.WriteLine("You picked up the "+ Statusitem.shield.name + " and it has " + Statusitem.shield.attack + " damage!");
                    break;
                }
                case (3):
                {
                    
                    Console.WriteLine("You picked up the "+ Statusitem.staff.name + " and it has " + Statusitem.staff.attack + " damage!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________\n");
            Console.WriteLine("-- IGNITE GAME --\n");
            Console.WriteLine("- 1.Enter to game");
            Console.WriteLine("- 2.Exit game\n");
            Console.Write("What is your choie - ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Clear();
                Choosestarterweapon();
            }
            

        }
    }
}