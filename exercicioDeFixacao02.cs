using System.Globalization;
using System;

namespace exercicioDeFixacao
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            System.Console.Write("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            System.Console.Write("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            System.Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Entre com o seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string last = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine();
            System.Console.WriteLine(last);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
