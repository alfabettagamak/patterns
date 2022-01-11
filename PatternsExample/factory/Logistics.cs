using System;

namespace PatternsExample.factory
{
    public abstract class Logistics
    {

        public abstract ITransport CreateTransport(); // фабричный метод

        public void PlanDelivery()
        {
            var transport = CreateTransport();
            Console.WriteLine("План доставки такой:");
            transport.Deliver();
        }
    }
}