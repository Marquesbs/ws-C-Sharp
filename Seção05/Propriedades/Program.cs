using System;
using System.Globalization;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            System.Console.WriteLine(p.GetNome());
            System.Console.WriteLine(p.GetPreco().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(p.GetQuantidade());
        }
    }
}

