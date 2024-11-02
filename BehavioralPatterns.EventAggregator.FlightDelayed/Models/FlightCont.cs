using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class FlightControl
    {
        private readonly IEventAggregator _eventAggregator;

        public FlightControl(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void DelayFlight(string flightNumber, DateTime newDepartureTime)
        {
            var flightDelayedEvent = new FlightDelayedEvent(flightNumber, newDepartureTime);
            _eventAggregator.Publish(flightDelayedEvent);
        }
    }

}
