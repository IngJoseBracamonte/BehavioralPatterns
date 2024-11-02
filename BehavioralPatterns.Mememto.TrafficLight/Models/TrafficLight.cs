using BehavioralPatterns.Mememto.TrafficLight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mememto.TrafficLight.Models
{
    public class TrafficLightBase
    {
        public IState State { get; set; }

        public TrafficLightBase()
        {
            State = new RedLightState();
        }

        public void Change()
        {
            State.ChangeLight(this);
        }
    }
}
