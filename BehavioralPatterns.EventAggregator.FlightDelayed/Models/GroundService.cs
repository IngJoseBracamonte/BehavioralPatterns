using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class GroundService {
        public GroundService(IEventAggregator eventAggregator)
        { 
            eventAggregator.Subscribe<FlightDelayedEvent>(OnFlightDelayed);
        } 
        private void OnFlightDelayed(FlightDelayedEvent flightEvent) 
        {
            Console.WriteLine($"Informing ground services about delay of flight {flightEvent.FlightNumber}, new departure at {flightEvent.NewDepartureTime}");
        } 
    }
}
