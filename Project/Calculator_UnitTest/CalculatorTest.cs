using Calculator_Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace Calculator_UnitTest
{
  public  class CalculatorTest
    {
        
        private readonly CalculatorAdapter _calculatorAdapter;
        public CalculatorTest()
        {
            _calculatorAdapter = new CalculatorAdapter();
        }

        [Fact]
        public void Add_ShouldReturnResult()
        {
            int start = 4;
            int amount = 2;
            int result = _calculatorAdapter.Add(start, amount);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Subtract_ShouldReturnResult()
        {
            int start = 4;
            int amount = 2;
            int result = _calculatorAdapter.Subtract(start, amount);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnResult()
        {
            int start = 4;
            int by = 2;
            int result = _calculatorAdapter.Multiply(start, by);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_ShouldReturnResult()
        {
            int start = 4;
            int by = 2;
            int result = _calculatorAdapter.Divide(start, by);
            Assert.Equal(2, result);
        }
    }
}

