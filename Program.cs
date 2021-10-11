using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1=4;
            int number2=2;
            
            string operatieAdd = "ADD";
            string operatieMulti = "Multiply";
            Startup(operatieAdd, number1, number2);

            Startup(operatieMulti, number1, number2);


            //Exercise5(number1,number2,operator);
            //Exercise1();
            //Exercise2(4,3);
            //Exercise4(4,2,"Multiply");
            //Exercise5(4, 2, "dd");
            //Exercise6();



            Console.ReadLine();
        }
        public static void Startup(string operatie, int nr1, int nr2)
        {
            var result = new Calculator().Bereken(operatie, nr1, nr2);

            new Displayer().Display(operatie, result, nr1, nr2);
        }

        public static void Exercise6()
        {
            int number1 = 4;
            int number2 = 2;
            var multiply = new Multiplay();
            var adding = new Add();
            multiply.Calculation(number1, number2);
            adding.Calculation(number1, number2);

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
