using BehavioralPatterns.VendingMachine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.VendingMachine.Models
{
    public class VendingMachine
    {
        private IState _noCoinState; 
        private IState _hasCoinState;
        private IState _dispensingState;
        private IState _currentState; 
        public VendingMachine()
        {
            _noCoinState =  new NoCoinState(this);
            _hasCoinState = new HasCoinState(this);
            _dispensingState = new DispensingState(this);
            _currentState = _noCoinState;
            // Estado inicia
          } 
        public void SetState(IState newState) 
        { 
            _currentState = newState; 
        } 
        public void InsertCoin() 
        { 
            _currentState.InsertCoin();
        }
        public void EjectCoin() 
        { 
            _currentState.EjectCoin(); 
        } 
        public void PressButton()
        {
            _currentState.PressButton(); 
            _currentState.Dispense();
        } 
        public IState GetNoCoinState() => _noCoinState;
        public IState GetHasCoinState() => _hasCoinState;
        public IState GetDispensingState() => _dispensingState;
    }
}
