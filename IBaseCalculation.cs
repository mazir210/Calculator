using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public  interface IBaseCalculation
    {
        void Calculation(int nr1,int nr2);
        int CalculationRetun(int nr1, int nr2);
    }
}
