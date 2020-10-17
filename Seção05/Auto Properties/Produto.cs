using System.Globalization;

namespace AutoPropriedades
{
    public class Produto
    {
        private string _nome; //atributos privativos se começa com _ e letra minúscula.
        public double Preco {get; private set;}
        public int Quantidade {get; private set;}

        public Produto() 
        {
        
        }
        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //propriedades substituem Get e Set
        public string Nome {
            get 
            {
                return _nome; //substitui o GetNome() 
            }
            set //substitui o SetNome()
            { 
                if (value != null && value.Length > 1) //value substitui o parâmetro de entrada do método Set.
                {
                    _nome = Nome;
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}