using BehavioralPatterns.Mediator.Chat.Interfaces;

namespace BehavioralPatterns.Mediator.Chat.Models
{
    public class ChatMediator : IChatMediator
{
    private List<User> _users;

    public ChatMediator()
    {
        _users = new List<User>();
    }

    public void RegisterUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users)
        {
            // No enviar el mensaje al usuario que lo envió
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}

}
