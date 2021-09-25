using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            
            Console.WriteLine("\n===== Soma de dois números Inteiros =====\n");
            Console.WriteLine("Digite os números a serem somados, um em");
            Console.WriteLine("cada linha.\n");

            Console.Write("Número 1..: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número 2..: ");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("\n=== Resultado ===\n");
            Console.WriteLine($"{a} + {b} = {soma}\n");
            
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("==== Soma de dois Números ====");
            //Console.WriteLine();
            //Console.Write("Digite um número: ");
            //Console.ResetColor();
            //string aBase = Console.ReadLine();
            //double a = Convert.ToDouble(aBase);
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.Write("Digite outro número: ");
            //Console.ResetColor();
            //string bBase = Console.ReadLine();
            //double b = Convert.ToDouble(bBase);
            //double soma = a + b;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("== Resultado ==");
            //Console.ResetColor();
            //Console.WriteLine();
            //Console.WriteLine($"{a} + {b} = {soma}");
            //Console.WriteLine();
        }
    }
}
