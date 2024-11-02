using BehavioralPatterns.Mememto.TrafficLight.Interfaces;

namespace BehavioralPatterns.Mememto.TrafficLight.Models
{
    public class GreenLightState : IState
    {
        public void ChangeLight(TrafficLightBase context)
        {
            Console.WriteLine("Changing from Green to Yellow...");
            context.State = new YellowLightState();
        }
    }
}
