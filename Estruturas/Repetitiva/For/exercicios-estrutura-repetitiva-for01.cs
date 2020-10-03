using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());

            for (int n = 1; n <= x; n++)
            {
                if (n % 2 != 0)
                {
                    System.Console.WriteLine(n);
                }
            }
        }
    }
}
