using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer.DeliveryNotifications.Interfaces
{
    public interface IOrderSubject
    {
        void RegisterObserver(IOrderObserver observer);
        void RemoveObserver(IOrderObserver observer);
        void NotifyObservers();
    }

}
