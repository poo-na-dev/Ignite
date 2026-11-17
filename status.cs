using System;

namespace CharacterStat
{
    public class You
    {
        public int free_point ; 
        public int Strenght ;
        public int Defense ;
        public int Inteligence;
        public You(int free_point,int Strenght,int Defense,int Inteligence)
        {
            this.free_point = free_point; 
            this.Strenght = Strenght;
            this.Defense = Defense;
            this.Inteligence = Inteligence;
        }
    }
    public class Charactor
    {
        public static You you = new You(10,0,0,0);
    }
}