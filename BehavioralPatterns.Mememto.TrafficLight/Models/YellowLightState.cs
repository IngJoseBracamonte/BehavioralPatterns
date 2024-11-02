using BehavioralPatterns.Mememto.TrafficLight.Interfaces;

namespace BehavioralPatterns.Mememto.TrafficLight.Models
{
    public class YellowLightState : IState
    {
        public void ChangeLight(TrafficLightBase context)
        {

            Console.WriteLine("Changing from Yellow to Red...");
            context.State = new RedLightState();
        }
    }
}
