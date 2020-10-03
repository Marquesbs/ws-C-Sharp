using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int produto = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);
            double preco;

            if (produto == 1)
            {
                preco = quantidade * 4.0;
            }
            else if (produto == 2)
            {
                preco = quantidade * 4.5;
            }
            else if (produto == 3)
            {
                preco = quantidade * 5.0;
            }
            else if (produto == 4)
            {
                preco = quantidade * 2.0;
            }
            else
            {
                preco = quantidade * 1.5;
            }
            System.Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
