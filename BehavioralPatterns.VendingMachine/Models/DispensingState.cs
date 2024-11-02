using BehavioralPatterns.VendingMachine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.VendingMachine.Models
{
    public class DispensingState : IState
    {
        private VendingMachine _vendingMachine; 
        public DispensingState(VendingMachine vendingMachine) 
        {
            _vendingMachine = vendingMachine;
        }
        public void InsertCoin() 
        { 
            Console.WriteLine("Espere. Ya estamos dispensando su producto.");
        }
        public void EjectCoin()
        {
            Console.WriteLine("No se puede devolver la moneda después de presionar el botón.";
        }

        public void PressButton()
        {
            Console.WriteLine("Ya ha presionado el botón.");
        }

        public void Dispense()
        {
            Console.WriteLine("Producto dispensado."); 
            _vendingMachine.SetState(_vendingMachine.GetNoCoinState());
        }
    }
}
