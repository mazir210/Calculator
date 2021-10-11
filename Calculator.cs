using System;

namespace Calculator
{
    public class Calculator
    {
        public int Bereken(string operatie, int x, int y)
        {
            int uitkomst;

            switch (operatie)
            {
                case "Multiply":
                    uitkomst = x * y;
                   
                    break;
                case "ADD":
                    uitkomst = x + y;
                    
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    throw new Exception("operatie moet ADD of Multiply Zijn");

                 
            }

            return uitkomst;
        }
    }
}