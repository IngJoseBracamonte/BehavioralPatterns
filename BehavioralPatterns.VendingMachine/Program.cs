using BehavioralPatterns.VendingMachine.Models;

VendingMachine vendingMachine = new VendingMachine();
// Interacciones con la máquina expendedora
vendingMachine.InsertCoin(); 
vendingMachine.PressButton();
vendingMachine.InsertCoin(); 
vendingMachine.EjectCoin();

/*Explicación:
Interfaz IState: Define los métodos que cada estado debe implementar.

Estados Concretos: Implementan la interfaz IState y encapsulan el comportamiento específico de cada estado.

Clase VendingMachine: Maneja el estado actual y delega el comportamiento a los estados concretos.

Uso en Program: Simula las interacciones con la máquina expendedora cambiando de estado según las acciones realizadas.
*/