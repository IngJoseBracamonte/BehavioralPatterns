using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.TemplateMethod.Authenticator.Abstracts
{
    public abstract class Authenticator
    {
        public void Authenticate()
        {
            CollectCredentials();
            ValidateCredentials();
            CreateSession();
        }

        protected abstract void CollectCredentials();
        protected abstract void ValidateCredentials();

        private void CreateSession()
        {
            Console.WriteLine("Session created for the user.");
        }
    }

}
