using BehavioralPatterns.Visitor.InventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Models
{
    public class Book : IVisitable
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
