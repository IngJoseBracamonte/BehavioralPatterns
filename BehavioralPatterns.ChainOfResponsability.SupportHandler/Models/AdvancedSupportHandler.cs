using BehavioralPatterns.ChainOfResponsability.SupportHandler.Abstracts;

namespace BehavioralPatterns.ChainOfResponsability.SupportHandler.Models
{
    public class AdvancedSupportHandler : SupportHandlerAbstract
    {
        public override void HandleRequest(string issue)
        {
            if (issue == "software_install")
            {
                Console.WriteLine("Advanced Support: Handling software installation.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue);
            }
        }
    }

}
