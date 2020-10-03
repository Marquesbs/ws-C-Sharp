using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if (B % A == 0)
            {
                System.Console.WriteLine("São Múltiplos");
            }
            else
            {
                System.Console.WriteLine("Não São Múltiplos");
            }
        }
    }
}
