using BehavioralPatterns.Mediator.Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mediator.Chat.Interfaces
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }

}
