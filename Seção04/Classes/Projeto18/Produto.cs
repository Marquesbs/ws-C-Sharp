using System;
using System.Globalization;

namespace Projeto18
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public int AdicionarProdutos()
        {
            System.Console.WriteLine("Insira a quantidade: ");
            Quantidade = int.Parse(Console.ReadLine());
            return 0;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome 
            + ", $" 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", " + Quantidade + " unidades, Total: $" 
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}