namespace PatternsExample.factory
{
    public class SeaLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}