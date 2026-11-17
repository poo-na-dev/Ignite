using System.IO;
using System;

namespace main
{
    class maingame
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