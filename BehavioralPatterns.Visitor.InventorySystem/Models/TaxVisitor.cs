using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Models
{
    public class TaxVisitor : IVisitor
    {
        public void Visit(Book book)
        {
            double tax = book.Price * 0.10;
            Console.WriteLine($"Impuesto para el libro '{book.Title}' es: ${tax}");
        }

        public void Visit(Electronic electronic)
        {
            double tax = electronic.Price * 0.15;
            Console.WriteLine($"Impuesto para el electrónico '{electronic.Name}' es: ${tax}");
        }
    }

}
