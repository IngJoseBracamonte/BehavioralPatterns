namespace BehavioralPatterns.Observer.DeliveryNotifications.Interfaces
{
    public interface IOrderObserver
    {
        void Update(string orderStatus);
    }
}