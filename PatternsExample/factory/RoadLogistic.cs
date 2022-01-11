namespace PatternsExample.factory
{
    public class RoadLogistic : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}