
using BehavioralPatterns.TemplateMethod.Authenticator.Abstracts;

public class TwoFactorAuthenticator : Authenticator
{
    protected override void CollectCredentials()
    {
        Console.WriteLine("Collecting username, password, and 2FA code.");
    }

    protected override void ValidateCredentials()
    {
        Console.WriteLine("Validating username, password, and 2FA code.");
    }
}