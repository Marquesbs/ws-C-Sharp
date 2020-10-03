using System;
using System.Globalization;

namespace Projeto18
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            System.Console.Write("Insira o nome do Produto: ");
            p.Nome = Console.ReadLine();
            System.Console.Write("Insira o preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Insira a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados do Produto: " + p);
        }
    }
}
