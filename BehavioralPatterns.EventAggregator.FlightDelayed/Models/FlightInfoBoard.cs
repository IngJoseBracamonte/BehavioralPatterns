using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class FlightInfoBoard
    {
        public FlightInfoBoard(IEventAggregator eventAggregator)
        {
            eventAggregator.Subscribe<FlightDelayedEvent>(OnFlightDelayed);
        }

        private void OnFlightDelayed(FlightDelayedEvent flightEvent)
        {
            Console.WriteLine($"Updating flight info board for flight {flightEvent.FlightNumber}, new departure at {flightEvent.NewDepartureTime}");
        }
    }

}
