using System;

namespace PatternsExample.zombie
{
    public class FastZobie : Zombie
    {
        public void Walk()
        {
            Console.WriteLine("TOP-TOP-TOP");
        }

        public void Talk()
        {
            Console.WriteLine("BRAINNNN");
        }

        public void OnHold()
        {
            Console.WriteLine(".............");
        }

        public void Run()
        {
            Console.WriteLine("run-run-run");
        }
    }
}