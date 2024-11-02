using BehavioralPatterns.VendingMachine.Interface;


namespace BehavioralPatterns.VendingMachine.Models
{
    public class NoCoinState : IState
    {
        private VendingMachine _vendingMachine;

        public NoCoinState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("Moneda insertada.");
            _vendingMachine.SetState(_vendingMachine.GetHasCoinState());
        }

        public void EjectCoin()
        {
            Console.WriteLine("No se puede devolver la moneda. No has insertado ninguna moneda.");
        }

        public void PressButton()
        {
            Console.WriteLine("No puedes seleccionar un producto. No has insertado ninguna moneda.");
        }

        public void Dispense()
        {
            Console.WriteLine("No se puede dispensar el producto. No has insertado ninguna moneda.");
        }
    }

}
