using BehavioralPatterns.ChainOfResponsability.SupportHandler.Models;
        // Crear los manejadores
        var basicSupport = new BasicSupportHandler();
        var advancedSupport = new AdvancedSupportHandler();
        var supervisorSupport = new SupervisorSupportHandler();

        // Configurar la cadena de responsabilidad
        basicSupport.SetNextHandler(advancedSupport);
        advancedSupport.SetNextHandler(supervisorSupport);

        // Procesar las solicitudes
        Console.WriteLine("Handling password reset:");
        basicSupport.HandleRequest("password_reset");

        Console.WriteLine("Handling software installation:");
        basicSupport.HandleRequest("software_install");

        Console.WriteLine("Handling refund request:");
        basicSupport.HandleRequest("refund_request");

        Console.WriteLine("Handling unknown issue:");
        basicSupport.HandleRequest("unknown_issue");


//Explicación:
//Interfaz SupportHandler: Define el método HandleRequest y un mecanismo para establecer el siguiente manejador.

//Manejadores Concretos: Implementan HandleRequest para manejar problemas específicos o pasar la solicitud al siguiente manejador.

//Uso en Program: Configura la cadena de responsabilidad y envía diversas solicitudes para que sean manejadas por el primer manejador que las pueda procesar.

