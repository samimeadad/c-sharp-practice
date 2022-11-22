// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum = " + Convert.ToInt32(x+y));

            Console.ReadKey();
        }
    }
}