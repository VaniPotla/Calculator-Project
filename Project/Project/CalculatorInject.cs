using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Interface;

namespace Calculator
{
    class CalculatorInject
    {
        private ICalculatorAdapter _Calculator;
        public CalculatorInject(ICalculatorAdapter _Calculator)
        {
            this._Calculator = _Calculator;
        }
        public int Add(int start, int amount)
        {
            return _Calculator.Add(start, amount);
        }

        public int Divide(int start, int by)
        {
            return _Calculator.Divide(start, by);
        }

        public int Multiply(int start, int by)
        {
            return _Calculator.Multiply(start, by);
        }

        public int Subtract(int start, int amount)
        {
            return _Calculator.Subtract(start, amount);
        }
    }
}
