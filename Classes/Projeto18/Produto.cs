using System;
using System.Globalization;

namespace Projeto18
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public int AdicionarProdutos()
        {
            System.Console.Write("Insira o nome do Produto: ");
            nome = Console.ReadLine();
            System.Console.Write("Insira o preço do Produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Insira a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            return quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }
        public int RemoverProdutos()
        {
            
            return 0;
        }
    }
}