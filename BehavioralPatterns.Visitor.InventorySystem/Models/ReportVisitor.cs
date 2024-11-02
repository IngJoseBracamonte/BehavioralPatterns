using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Visitor.InventorySystem.Models
{
    public class ReportVisitor : IVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Reporte de Libro: Título - '{book.Title}', Precio - ${book.Price}");
        }

        public void Visit(Electronic electronic)
        {
            Console.WriteLine($"Reporte de Electrónico: Nombre - '{electronic.Name}', Precio - ${electronic.Price}");
        }
    }

}
