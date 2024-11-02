using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Models
{
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Electronic electronic);
    }

}
