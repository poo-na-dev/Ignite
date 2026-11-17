using System.IO;
using System;
using System.Text;
using item;
using CharacterStat;

namespace main
{
    class Maingame
    {
    
        static void Starterstatus()
        {
            while (Charactor.you.free_point != 0)
            {
            Console.WriteLine("______________________________\n");
            Console.WriteLine("-- Build your own status --\n");
            Console.WriteLine("1.Strenght now have "+ Charactor.you.Strenght);
            Console.WriteLine("2.Defence now have "+ Charactor.you.Defense);
            Console.WriteLine("3.Inteligence now have "+ Charactor.you.Inteligence +"\n");
            Console.WriteLine("Now you have free stats "+ Charactor.you.free_point+" points!");
            Console.Write("Do you favor to add more stat? (y/n) - ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y')
            {
                Console.Clear();
                Console.WriteLine("What do you want to add this?");
                Console.WriteLine("1.Strenght  ");
                Console.WriteLine("2.Defence  ");
                Console.WriteLine("3.Inteligence \n");
                Console.Write("Answer : ");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                    {
                        case 1:
                            {
                                Console.Write("How many do you want to add? - ");
                                int count = Convert.ToInt32(Console.ReadLine());
                                if (count > Charactor.you.free_point) {Console.WriteLine("You add more free point do you have! try again"); break;}
                                Charactor.you.free_point -= count;
                                Charactor.you.Strenght += count;
                                Console.WriteLine("\nYou got upgraded Strength "+ count +" point!");
                                Task.Delay(100000);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("How many do you want to add? - ");
                                int count = Convert.ToInt32(Console.ReadLine());
                                if (count > Charactor.you.free_point) {Console.WriteLine("You add more free point do you have! try again"); break;}
                                Charactor.you.free_point -= count;
                                Charactor.you.Defense += count;
                                Console.WriteLine("\nYou got upgraded Defence "+ count +" point!");
                                Task.Delay(5000);
                                break;
                            }
                        case 3:
                            {
                                Console.Write("How many do you want to add? - ");
                                int count = Convert.ToInt32(Console.ReadLine());
                                if (count > Charactor.you.free_point) {Console.WriteLine("You add more free point do you have! try again"); break;}
                                Charactor.you.free_point -= count;
                                Charactor.you.Inteligence += count;
                                Console.WriteLine("\nYou got upgraded Inteligence "+ count +" point!");
                                Task.Delay(5000);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nYou enter the wrong key!");
                                Task.Delay(5000);
                                break;
                            }
                    }
            Console.Clear();

            }else
                {
                    Charactor.you.free_point = 0;
                    break;
                }
            }
        }
        static void Choosestarterweapon()
        {
            bool check = true;
            while (check)
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
                    check = false;
                    break;
                }
                case (2):
                { 
                    Console.WriteLine("You picked up the "+ Statusitem.shield.name + " and it has " + Statusitem.shield.attack + " damage!");
                    check = false;
                    break;
                }
                case (3):
                {
                    Console.WriteLine("You picked up the "+ Statusitem.staff.name + " and it has " + Statusitem.staff.attack + " damage!");
                    check = false;
                    break;
                }
                default:
                {
                    Console.WriteLine("You type doesnt match! let try again");
                    break;
                }
            }
                Task.Delay(1000);
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
                Console.Clear();
                Starterstatus();
            }
            else
            {
                Console.WriteLine("We will wait your comeback! , Braver");
            }
        }
    }
}