using BehavioralPatterns.Mememto.TrafficLight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Mememto.TrafficLight.Interfaces
{
    public interface IState
    {
        void ChangeLight(TrafficLightBase context);
    }
}
