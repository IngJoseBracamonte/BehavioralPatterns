using BehavioralPatterns.TemplateMethod.Authenticator.Abstracts;

public class EmailAuthenticator : Authenticator
{
    protected override void CollectCredentials()
    {
        Console.WriteLine("Collecting email and password.");
    }

    protected override void ValidateCredentials()
    {
        Console.WriteLine("Validating email and password.");
    }
}
