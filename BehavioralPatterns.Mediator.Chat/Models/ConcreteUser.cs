using BehavioralPatterns.Mediator.Chat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator.Chat.Models
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IChatMediator mediator, string name)
            : base(mediator, name) { }

        public override void Send(string message)
        {
            Console.WriteLine($"{_name} enviando mensaje: {message}");
            _mediator.SendMessage(message, this); // Asegúrate de que el método del mediador acepta la clase base User
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} recibió mensaje: {message}");
        }
    }


}
