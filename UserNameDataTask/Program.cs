using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi");
            string user = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sisesta arvu 1 kuni 3:");
            char number = Convert.ToChar(Console.ReadLine());

            switch (number)
            {
                case '1':
                    TaskOne(user);
                    break;
                case '2':
                    TaskTwo(user);
                    break;
                case '3':
                    TaskThree(user);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;
            }
        }
        public static void TaskOne(string name)
        {
            Console.WriteLine("Sinu eesnime tagurpidi:");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
            
        }

        public static void TaskTwo(string nameForWord)
        {
            
           Console.WriteLine($"Sinu eesnime esimene taht {nameForWord[0]}");
            
        }
        public static void TaskThree(string nameLenght)
        {
            int lenght = nameLenght.Length;
            Console.WriteLine($"Sinu eesnime pikkus {lenght}");
        }
    }
}
