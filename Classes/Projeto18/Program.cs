using System;
using System.Globalization;

namespace Projeto18
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod, valor, qnt;
            prod = new Produto();
            valor = new Produto();
            qnt = new Produto();

            System.Console.Write("Insira o nome do Produto: ");
            prod.nome = Console.ReadLine();
            System.Console.Write("Insira o preço do Produto: ");
            valor.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Insira a quantidade: ");
            qnt.quantidade = int.Parse(Console.ReadLine());

            
        }
    }
}
