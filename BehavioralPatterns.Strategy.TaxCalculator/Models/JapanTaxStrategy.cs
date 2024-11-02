using BehavioralPatterns.Strategy.TaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.TaxCalculator.Models
{
    public class JapanTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            // Supongamos un 8% de impuesto
            return amount * 0.08m;
        }
    }
}
