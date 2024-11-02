using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.ChainOfResponsability.SupportHandler.Abstracts
{
    public abstract class SupportHandlerAbstract
    {
        protected SupportHandlerAbstract _nextHandler;

        public void SetNextHandler(SupportHandlerAbstract nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(string issue);
    }

}
