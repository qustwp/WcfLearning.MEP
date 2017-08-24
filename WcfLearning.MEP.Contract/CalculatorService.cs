using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfLearning.MEP.Contract
{
    public class CalculatorService:ICalculatorService
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0) throw new Exception("");

            return a / b;
        }
    }
}
