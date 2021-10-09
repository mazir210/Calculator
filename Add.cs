using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Add : IBaseCalculation
    {
        public void Calculation(int nr1, int nr2)
        {
            var uitkomst = 0;
            uitkomst = nr1 + nr2;
            Console.WriteLine($"Adding of {nr1} and {nr2} is :{uitkomst}");
        }

        public int CalculationRetun(int nr1, int nr2)
        {
            return nr1 + nr2;
        }
    }
}
