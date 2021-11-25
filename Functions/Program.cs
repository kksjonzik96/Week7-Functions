using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+', '-', '*' voi '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    lahutamine(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    korrutamine(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;
            }


        }
        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void lahutamine(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        public static void korrutamine(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }
    }
}
