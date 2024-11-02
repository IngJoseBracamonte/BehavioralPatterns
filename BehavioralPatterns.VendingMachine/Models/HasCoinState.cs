using BehavioralPatterns.VendingMachine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.VendingMachine.Models
{
    public class HasCoinState : IState 
    { 
        private VendingMachine _vendingMachine; 
        public HasCoinState(VendingMachine vendingMachine)
        { 
            _vendingMachine = vendingMachine; 
        }
        public void InsertCoin()
        { 
            Console.WriteLine("Ya has insertado una moneda."); 
        }
        public void EjectCoin()
        { 
            Console.WriteLine("Moneda devuelta."); _vendingMachine.SetState(_vendingMachine.GetNoCoinState()); 
        } 
        public void PressButton()
        { 
            Console.WriteLine("Botón presionado."); _vendingMachine.SetState(_vendingMachine.GetDispensingState());
        } 
        public void Dispense() 
        { 
            Console.WriteLine("No se puede dispensar el producto sin presionar el botón.");
        } 
    }
}
