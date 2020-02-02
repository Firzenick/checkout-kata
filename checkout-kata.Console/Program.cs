using System;

namespace checkout_kata.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Basket.Scan("A99", 8);
            Basket.Total();
        }
    }
}
