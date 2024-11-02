using BehavioralPatterns.Interpreter.Math.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns.Interpreter.Math.Models
{
    public class Number : IExpression
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public int Interpret()
        {
            return _value;
        }
    }

}
