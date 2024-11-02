using BehavioralPatterns.Visitor.InventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Models
{
    public class Electronic : IVisitable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Electronic(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
