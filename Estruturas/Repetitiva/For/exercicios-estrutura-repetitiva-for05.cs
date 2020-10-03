using System;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int cont = 1;cont <= n ; cont++)
            {
                fatorial *= cont;
            }
            System.Console.WriteLine(fatorial);
        }
    }
}
