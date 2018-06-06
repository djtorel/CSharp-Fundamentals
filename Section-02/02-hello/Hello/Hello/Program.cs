using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How many hourse of sleep did you get last night?");
            int houseOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);

            if(houseOfSleep > 8)
            {
                Console.WriteLine("You are well rested.");
            } else
            {
                Console.WriteLine("You need more sleep!");
            }
        }
    }
}