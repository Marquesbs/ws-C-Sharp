using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine("PAR!");
            }
            else
            {
                System.Console.WriteLine("ÍMPAR!");
            }
        }
    }
}
