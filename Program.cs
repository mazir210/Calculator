using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2(4,3);
            Console.ReadLine();
        }

        public static void Exercise1()
        {
            Console.WriteLine("Oef Elbaz monir ");
            var number1 = 3;
            var number2 = 4;
            var uitkomst = 0;
            uitkomst = number1 * number2;
            Console.WriteLine(uitkomst);

        }

        public static void Exercise2(int number1,int number2)
        {
            Console.WriteLine("Exercise 2 && 3 ");
            
            var uitkomst = 0;
            uitkomst = number1 * number2;
            Console.WriteLine(uitkomst);

        }
    }
}
