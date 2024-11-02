using BehavioralPatterns.ChainOfResponsability.SupportHandler.Abstracts;

namespace BehavioralPatterns.ChainOfResponsability.SupportHandler.Models
{
    public class BasicSupportHandler : SupportHandlerAbstract
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "password_reset")
            {
                Console.WriteLine("Basic Support: Handling password reset.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue);
            }
        }
    }

}
