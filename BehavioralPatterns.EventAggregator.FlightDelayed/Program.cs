using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;
using BehavioralPatterns.EventAggregator.FlightDelayed.Models;


IEventAggregator eventAggregator = new EventAggregator();

var flightInfoBoard = new FlightInfoBoard(eventAggregator);
var passengerNotificationSystem = new PassengerNotificationSystem(eventAggregator);
var groundService = new GroundService(eventAggregator);

var flightControl = new FlightControl(eventAggregator);

// Simular el retraso de un vuelo
flightControl.DelayFlight("AB123", DateTime.Now.AddHours(2));
