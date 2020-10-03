using System;

namespace Projeto15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;
            System.Console.WriteLine("Dados da primeira pessoa: ");

            pessoa1 = new Dados();
            pessoa2 = new Dados();

            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa: ");;
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            }
            else
            {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }
        }
    }
}
