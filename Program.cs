using System;

namespace MyConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string userName = "A_Hatoka";
            string userWallet = "leather wallet";
            int coins = 100;
            Console.WriteLine($"{userName} have {coins} in {userWallet}");
        }
    }
}