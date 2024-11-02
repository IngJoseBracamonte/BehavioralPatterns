using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.interfaces
{
    public interface IEventAggregator
    {
        void Subscribe<TEvent>(Action<TEvent> handler); 
        void Unsubscribe<TEvent>(Action<TEvent> handler); 
        void Publish<TEvent>(TEvent eventToPublish);
    }
}
