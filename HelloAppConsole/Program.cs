using System;

namespace HelloAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте введите свое имя:");
            string name = Console.ReadLine();     
            Console.WriteLine($"Привет {name}");
            Console.ReadLine();

        }
    }
}
