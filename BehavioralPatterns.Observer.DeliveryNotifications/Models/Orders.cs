using BehavioralPatterns.Observer.DeliveryNotifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer.DeliveryNotifications.Models
{
    public class Order : IOrderSubject
    {
        private List<IOrderObserver> _observers;
        private string _orderStatus;

        public Order()
        {
            _observers = new List<IOrderObserver>();
        }

        public void RegisterObserver(IOrderObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IOrderObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_orderStatus);
            }
        }

        public void SetOrderStatus(string status)
        {
            _orderStatus = status;
            NotifyObservers();
        }
    }

}
