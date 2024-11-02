using BehavioralPatterns.Visitor.InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Interfaces
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }

}
