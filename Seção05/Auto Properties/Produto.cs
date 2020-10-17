using System.Globalization;

namespace AutoPropriedades
{
    public class Produto
    {
        private string _nome; //atributos privativos se começa com _ e letra minúscula.
        private double _preco;
        private int _quantidade;

        public Produto() 
        {
        
        }
        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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
        public double Preco
        {
            get 
            {
                return _preco;
            }
        }
        public double Quantidade
        {
            get
            {
                return _quantidade;
            }
        }

        public double ValorTotalEmEstoque() 
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) 
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) 
        {
            _quantidade -= quantidade;
        }
        public override string ToString() 
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}