using BehavioralPatterns.Mediator.Chat.Interfaces;
using BehavioralPatterns.Mediator.Chat.Models;

IChatMediator chatMediator = new ChatMediator();

User user1 = new ConcreteUser(chatMediator, "Alice");
User user2 = new ConcreteUser(chatMediator, "Bob");
User user3 = new ConcreteUser(chatMediator, "Charlie");

chatMediator.RegisterUser(user1);
chatMediator.RegisterUser(user2);
chatMediator.RegisterUser(user3);

user1.Send("Hola a todos!");
user2.Send("Hola Alice!");

//Explicación:
//Interfaz IChatMediator: Ajustada para aceptar la clase base User.

//Clase ConcreteUser: Elimina la dependencia de tipos específicos y usa la clase base User.

//Clase ChatMediator: Ajustada para trabajar con User en lugar de ConcreteUser.


