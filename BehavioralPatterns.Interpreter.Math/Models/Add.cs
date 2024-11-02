using BehavioralPatterns.Interpreter.Math.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Interpreter.Math.Models
{
    public class Add : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public Add(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }

}
