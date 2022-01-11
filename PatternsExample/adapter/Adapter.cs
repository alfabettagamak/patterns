using System;

namespace PatternsExample.adapter
{
    public class Adapter : IClient
    {

        public ClientJava _ClientJava;

        public Adapter(ClientJava clientJava)
        {
            _ClientJava = clientJava;
        }

        public void DoSomething()
        {
            Console.WriteLine("Работаю на c# делаю что-то и");
            _ClientJava.DoSomethingJava();
        }
    }
}