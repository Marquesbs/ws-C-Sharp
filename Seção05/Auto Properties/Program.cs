using System;
using System.Globalization;

namespace AutoPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(p.Quantidade);
        }
    }
}

