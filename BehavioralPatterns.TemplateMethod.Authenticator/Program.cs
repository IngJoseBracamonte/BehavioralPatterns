using BehavioralPatterns.TemplateMethod.Authenticator.Abstracts;

        Authenticator emailAuth = new EmailAuthenticator();
        emailAuth.Authenticate();

        Console.WriteLine();

        Authenticator socialMediaAuth = new SocialMediaAuthenticator();
        socialMediaAuth.Authenticate();

        Console.WriteLine();

        Authenticator twoFactorAuth = new TwoFactorAuthenticator();
        twoFactorAuth.Authenticate();

