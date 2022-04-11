using System;

namespace MyConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string userName;
            string userZodiac;
            string userAge;
            string userWork;

            Console.WriteLine("Имя твоё какое будет?");
            userName = Console.ReadLine();

            Console.WriteLine("Под каким созвездем на свет вылез?");
            userZodiac = Console.ReadLine();
            
            Console.WriteLine("Сколько зим видывал?");
            userAge = Console.ReadLine();
            
            Console.WriteLine("На какой галере трудишься?");
            userWork = Console.ReadLine();

            Console.WriteLine($"Имя твое: {userName},\nЗнак твой: {userZodiac},\n" +
                              $"Годиков тебе: {userAge},\nГалера твоя: {userWork}");
        }
    }
}