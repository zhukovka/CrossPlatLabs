using System;

namespace Lab1ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок.Програма знаходить довжину рядка N та визначає, чи є N(і яким) числом Фібоначчі.");
            string input = Console.ReadLine();
            int len = Lab1ClassLibrary1.Fib.Len(input);
            Console.WriteLine("Довжина рядка N: " + len);
            int fib = Lab1ClassLibrary1.Fib.FibonacciLength(input);
            if (fib == -1)
            {
                Console.WriteLine("не є числом Фібоначчі.");
            } else
            {
                Console.WriteLine("є числом Фібоначчі номер " + fib);
            }
            Console.ReadKey();
        }
    }
}
