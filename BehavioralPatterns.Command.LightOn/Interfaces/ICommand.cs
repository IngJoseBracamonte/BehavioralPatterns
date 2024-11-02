using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Command.LightOn.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
