using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + ", " +  userName + '!');
            Console.WriteLine($"Hello, {userName} !");
        }
    }
}
