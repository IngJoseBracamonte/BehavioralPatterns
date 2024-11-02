using BehavioralPatterns.Mememto.TrafficLight.Interfaces;

namespace BehavioralPatterns.Mememto.TrafficLight.Models
{
    public class RedLightState : IState
    {
        public void ChangeLight(TrafficLightBase context)
        {
            Console.WriteLine("Changing from Red to Green...");
            context.State = new GreenLightState();
        }
    }
}
