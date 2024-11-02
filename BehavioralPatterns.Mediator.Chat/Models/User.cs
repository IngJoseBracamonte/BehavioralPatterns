using BehavioralPatterns.Mediator.Chat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator.Chat.Models
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        protected string _name;

        public User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            _name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
