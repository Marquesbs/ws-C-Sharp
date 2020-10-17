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

            System.Console.WriteLine("\nDados do Produto: " + p);
            System.Console.WriteLine();

            System.Console.Write("\nDigite o numero de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            System.Console.WriteLine("\nDados Atualizados: " + p);

            System.Console.Write("\nDigite o numero de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            System.Console.WriteLine("\nDados Atualizados: " + p);
        }
    }
}
