using System.Globalization;

namespace Encapsulamento
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

        //métodos Get / Set
        public string GetNome() //método para que seja visualizado o nome do produto para o usuário
        {
            return _nome;
        }

        public void SetNome(string nome) //método para que seja atribuído na private _nome, o nome que for digitado de parâmetro de entrada.
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public double GetQuantidade()
        {
            return _quantidade;
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