using BehavioralPatterns.EventAggregator.FlightDelayed.interfaces;

namespace BehavioralPatterns.EventAggregator.FlightDelayed.Models
{
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<object>> _subscribers = new Dictionary<Type, List<object>>();

        public void Subscribe<TEvent>(Action<TEvent> handler)
        {
            if (!_subscribers.ContainsKey(typeof(TEvent)))
            {
                _subscribers[typeof(TEvent)] = new List<object>();
            }
            _subscribers[typeof(TEvent)].Add(handler);
        }

        public void Unsubscribe<TEvent>(Action<TEvent> handler)
        {
            if (_subscribers.ContainsKey(typeof(TEvent)))
            {
                _subscribers[typeof(TEvent)].Remove(handler);
            }
        }

        public void Publish<TEvent>(TEvent eventToPublish)
        {
            if (_subscribers.ContainsKey(eventToPublish.GetType()))
            {
                foreach (Action<TEvent> handler in _subscribers[eventToPublish.GetType()])
                {
                    handler(eventToPublish);
                }
            }
        }
    }

}
