using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.TaxCalculator.Interface
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal amount);
    }
}
