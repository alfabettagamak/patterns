using System;

namespace PatternsExample.factory
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Доставляю по морю");
        }
    }
}