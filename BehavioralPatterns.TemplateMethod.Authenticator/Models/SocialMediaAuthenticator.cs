using BehavioralPatterns.TemplateMethod.Authenticator.Abstracts;

    public class SocialMediaAuthenticator : Authenticator
    {
        protected override void CollectCredentials()
        {
            Console.WriteLine("Redirecting to social media login.");
        }

        protected override void ValidateCredentials()
        {
            Console.WriteLine("Validating social media token.");
        }
    }

