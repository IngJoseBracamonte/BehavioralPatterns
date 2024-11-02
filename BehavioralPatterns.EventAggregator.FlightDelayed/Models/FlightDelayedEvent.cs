using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class FlightDelayedEvent
    {
        public string FlightNumber { get; }
        public DateTime NewDepartureTime { get; }

        public FlightDelayedEvent(string flightNumber, DateTime newDepartureTime)
        {
            FlightNumber = flightNumber;
            NewDepartureTime = newDepartureTime;
        }
    }

}
