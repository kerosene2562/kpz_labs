using Mediator.Classes;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCentre = new CommandCentre();

            var runway1 = new Runway("London");
            var runway2 = new Runway("Boryspil");
            var aircraft1 = new Aircraft("Boeing-100");
            var aircraft2 = new Aircraft("Boeing-101");
            var aircraft3 = new Aircraft("Boeing-120");

            commandCentre.RegisterRunway(runway1);
            commandCentre.RegisterRunway(runway2);
            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);
            commandCentre.RegisterAircraft(aircraft3);

            aircraft3.RequestLanding();
            aircraft1.RequestLanding();
            aircraft2.RequestLanding();
            aircraft1.TakeOff();
            aircraft2.RequestLanding();
        }
    }
}