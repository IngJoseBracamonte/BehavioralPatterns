using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.VendingMachine.Interface
{
    public interface IState
    {
        void InsertCoin();
        void EjectCoin();
        void PressButton(); 
        void Dispense();
    }
}
