using BehavioralPatterns.ChainOfResponsability.SupportHandler.Abstracts;

namespace BehavioralPatterns.ChainOfResponsability.SupportHandler.Models
{
    public class SupervisorSupportHandler : SupportHandlerAbstract
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "refund_request")
            {
                Console.WriteLine("Supervisor Support: Handling refund request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue);
            }
            else
            {
                Console.WriteLine("Issue not resolved: Escalate to upper management.");
            }
        }
    }

}
