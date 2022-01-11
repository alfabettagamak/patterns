using System;

namespace PatternsExample.zombie
{
    public class ZombieSherrif : Zombie, Policeman
    {
        public void Walk()
        {
            Console.WriteLine("!!!!top");
        }

        public void Talk()
        {
            Console.WriteLine("ARRRRRR!!");
        }

        public void OnHold()
        {
            Console.WriteLine("ZZZZZZZ-z-z-");
        }

        public void shoot()
        {
            Console.WriteLine("bum-bum");
        }
    }
}