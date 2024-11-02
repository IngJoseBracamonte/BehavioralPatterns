using BehavioralPatterns.Strategy.TaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.TaxCalculator.Models
{
    public class USTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            // Supongamos un 10% de impuesto
            return amount * 0.10m;
        }
    }
}
