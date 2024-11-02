using BehavioralPatterns.Observer.DeliveryNotifications.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Observer.DeliveryNotifications.Models
{
    public class UserInterface : IOrderObserver
    {
        public void Update(string orderStatus)
        {
            Console.WriteLine($"Interfaz de Usuario: El estado del pedido ha cambiado a {orderStatus}");
        }
    }

}
