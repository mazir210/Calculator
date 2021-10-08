using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            
            string operatie;


            //Exercise5(number1,number2,operator);
            //Exercise1();
            //Exercise2(4,3);
            //Exercise4(4,2,"Multiply");
            Exercise5(4, 2, "dd");

            Console.ReadLine();
        }
        public static void Exercise5(int number1, int number2, string operatie)
        {
            int uitkomst;

            switch (operatie)
            {
                case "Multiply":
                    uitkomst = number1 * number2;
                    Console.WriteLine(uitkomst);
                    break;
                case "ADD":
                    uitkomst = number1 + number2;
                    Console.WriteLine(uitkomst);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    throw new Exception("operatie moet ADD of Multiply Zijn");

                    break;

            }
           
            

          

        }

        public static void Exercise4(int number1, int number2, string operatie)
        {
            int uitkomst;
            Console.WriteLine("Exercise 4 ");

            if (operatie == "ADD")
            {
                uitkomst = number1 + number2;

            }
            else if (operatie == "Multiply")
            {
                uitkomst = number1 * number2;
            }
            else
            {
                throw new Exception("operatie moet ADD of Multiply Zijn");
            }

            Console.WriteLine(uitkomst);

        }



        public static void Exercise2(int number1, int number2)
        {
            Console.WriteLine("Exercise 2 && 3 ");

            var uitkomst = 0;
            uitkomst = number1 * number2;
            Console.WriteLine(uitkomst);

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

        
        
    }
}
