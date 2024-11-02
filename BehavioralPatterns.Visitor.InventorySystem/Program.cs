using BehavioralPatterns.Visitor.InventorySystem.Interfaces;
using BehavioralPatterns.Visitor.InventorySystem.Models;


List<IVisitable> products = new List<IVisitable>
{
    new Book("C# Programming", 29.99),
    new Electronic("Smartphone", 499.99)
};

IVisitor taxVisitor = new TaxVisitor();
IVisitor reportVisitor = new ReportVisitor();

foreach (var product in products)
{
    product.Accept(taxVisitor);
    product.Accept(reportVisitor);
}
