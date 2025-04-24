using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Interfaces;

namespace Mediator.Classes
{
    public class CommandCentre : IAirTrafficMediator
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Aircraft, Runway> _assignedRunways = new();

        public void RegisterRunway(Runway runway)
        {
            runway.SetMediator(this);
            _runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircraft.SetMediator(this);
            _aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var freeRunway = _runways.FirstOrDefault(r => r.IsAvailable);
            if (freeRunway != null)
            {
                freeRunway.Accept();
                _assignedRunways[aircraft] = freeRunway;
                Console.WriteLine($"Aircraft {aircraft.Name} landed on Runway {freeRunway.Name}");
            }
            else
            {
                Console.WriteLine($"No available runways for aircraft {aircraft.Name}!");
            }
        }

        public void NotifyTakeOff(Aircraft aircraft)
        {
            if (_assignedRunways.TryGetValue(aircraft, out var runway))
            {
                runway.Release();
                Console.WriteLine($"Aircraft {aircraft.Name} took off from Runway {runway.Name}");
                _assignedRunways.Remove(aircraft);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} was not found on any runway!");
            }
        }
    }
}
