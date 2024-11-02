using BehavioralPatterns.Observer.DeliveryNotifications.Models;
// Crear el sujeto
        Order order = new Order();
// Crear los observadores
        UserInterface uiObserver = new UserInterface();
        SystemLogger loggerObserver = new SystemLogger();

        // Registrar los observadores
        order.RegisterObserver(uiObserver);
        order.RegisterObserver(loggerObserver);

        // Cambiar el estado del pedido y notificar a los observadores
        order.SetOrderStatus("Procesando");
        order.SetOrderStatus("Enviado");
        order.SetOrderStatus("Completado");

//Explicación:
//Interfaz IOrderSubject: Define métodos para registrar, eliminar y notificar a los observadores.

//Interfaz IOrderObserver: Define un método Update que los observadores deben implementar para recibir actualizaciones.

//Clase Order: Implementa la interfaz IOrderSubject y notifica a los observadores cuando cambia el estado del pedido.

//Clases UserInterface y SystemLogger: Implementan la interfaz IOrderObserver y definen cómo deben actuar cuando reciben una actualización.

//Uso en Program: Crea una instancia de Order, registra observadores y actualiza el estado del pedido para ver cómo se notifican los observadores.