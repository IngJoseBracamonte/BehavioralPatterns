using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class PassengerNotificationSystem 
    {
        public PassengerNotificationSystem(IEventAggregator eventAggregator)
        { 
            eventAggregator.Subscribe<FlightDelayedEvent>(OnFlightDelayed); 
        }
        private void OnFlightDelayed(FlightDelayedEvent flightEvent) 
        {
            Console.WriteLine($"Notifying passengers of flight {flightEvent.FlightNumber} about new departure time at {flightEvent.NewDepartureTime}"); 
        } 
    }
}
