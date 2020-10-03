using System;

namespace exercicios_estrutura_sequencial
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA = 0;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            DIFERENCA = A * B - C * D;

            System.Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
