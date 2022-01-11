using System;

namespace PatternsExample.zombie
{
    public class ClassicZombie : Zombie
    {
        public void Walk()
        {
            Console.WriteLine("top-top-top");
        }

        public void Talk()
        {
            Console.WriteLine("Arrrrrrrrrr");
        }

        public void OnHold()
        {
            Console.WriteLine("zzzzzzz");
        }
    }
}