using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n===== Soma de dois números Inteiros =====\n");
            Console.ResetColor();

            Console.WriteLine("Digite os números a serem somados, um em");
            Console.WriteLine("cada linha.\n");

            Console.Write("Número 1..: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2..: ");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Resultado ===\n");
            Console.ResetColor();

            Console.WriteLine($"{a} + {b} = {soma}\n");
        }
    }
}
