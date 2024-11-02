using BehavioralPatterns.Strategy.TaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Strategy.TaxCalculator.Models
{
    public class TaxCalculator
    {
        private ITaxStrategy _taxStrategy;

        public void SetTaxStrategy(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public decimal CalculateTax(decimal amount)
        {
            return _taxStrategy.CalculateTax(amount);
        }
    }

}
