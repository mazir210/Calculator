using System;

namespace Calculator
{
    internal class Displayer
    {
        public void Display(string operatie, int result,int nr1 ,int nr2)
        {
            Console.WriteLine($"de resultaat van {operatie} van {nr1} en {nr2} is {result}");
        }
    }
}