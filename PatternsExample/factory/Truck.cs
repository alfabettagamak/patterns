using System;

namespace PatternsExample.factory
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Доставка по суше");
        }
    }
}