using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.LightOn.Models
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("La luz está encendida.");
        }
        public void Off()
        {
            Console.WriteLine("La luz está apagada.");
        }
    }
}
